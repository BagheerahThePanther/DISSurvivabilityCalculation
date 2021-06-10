using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISSurvivabilityCalculation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            contextMenuStripDGV.Items[0].Click += new EventHandler(contextMenuItem_Clicked);
        }

        private List<Unit> units = new List<Unit> { };

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddNetworkDevice_Click(object sender, EventArgs e)
        {
            if (textBoxNetworkDeviceName.Text != "" && units.Find(unit => unit.Name == textBoxNetworkDeviceName.Text && unit.Type == Type.NetworkDevice) == default(Unit))
            {

                units.Add(new Unit(Type.NetworkDevice, textBoxNetworkDeviceName.Text, Decimal.ToDouble(numericUpDownNetworkDevsSurvivability.Value)));
                refreshNetworkDevicesTable();
                refreshComboboxes();
            }
            else
            {
                MessageBox.Show("Устройство инфраструктуры сети с этим именем уже существует");
            }
        }

        private void buttonAddHostDevice_Click(object sender, EventArgs e)
        {
            if (textBoxHostDevsName.Text != "" && units.Find(unit => unit.Name == textBoxHostDevsName.Text && unit.Type == Type.HostDevice) == default(Unit))
            {
                units.Add(new Unit(Type.HostDevice, textBoxHostDevsName.Text, Decimal.ToDouble(numericUpDownHostDevsSurvivability.Value)));
                refreshHostDevicesTable();
                refreshComboboxes();
            }
            else
            {
                MessageBox.Show("Оконечное устройство с этим именем уже существует");
            }
        }


        private void buttonAddConnection_Click(object sender, EventArgs e)
        {
            if (textBoxConnectionName.Text != "" && units.Find(unit => unit.Name == textBoxConnectionName.Text && unit.Type == Type.Connection) == default(Unit) && comboBoxConnFrom.Text != comboBoxConnTo.Text)
            {
                units.Add(new Unit(Type.Connection, textBoxConnectionName.Text, Decimal.ToDouble(numericUpDownConnectionSurvivability.Value),
                    units.Find(unit => unit.Name == comboBoxConnFrom.Text), units.Find(unit => unit.Name == comboBoxConnTo.Text)));
                refreshConnectionsTable();
                refreshComboboxes();
            }
            else
            {
                MessageBox.Show("Соединение с этим именем уже существует или указанное соединение включает одно и то же устройство");
            }
        }


        private void contextMenuStripDGV_Opening(object sender, CancelEventArgs e)
        {

        }

        private void refreshComboboxes()
        {
            comboBoxConnFrom.Items.Clear();
            comboBoxConnTo.Items.Clear();

            foreach (var unit in units.FindAll(elem => elem.Type == Type.HostDevice || elem.Type == Type.NetworkDevice))
            {
                comboBoxConnFrom.Items.Add(unit.Name);
                comboBoxConnTo.Items.Add(unit.Name);
            }
            comboBoxConnFrom.SelectedItem = comboBoxConnFrom.Items.Count > 0 ? comboBoxConnFrom.Items[0] : null;
            comboBoxConnTo.SelectedItem = comboBoxConnTo.Items.Count > 0 ? comboBoxConnTo.Items[0] : null;
        }


        private void refreshNetworkDevicesTable()
        {
            dataGridViewNetworkDevs.Rows.Clear();
            var sequence = units.Where(unit => unit.Type == Type.NetworkDevice).Select(unit => new { DeviceName = unit.Name, NetworkDeviceSurvivabilitySurvivability = unit.Survivability });
            foreach (var element in sequence)
            {
                dataGridViewNetworkDevs.Rows.Add(new object[] { element.DeviceName, element.NetworkDeviceSurvivabilitySurvivability });
            }
        }
        private void refreshHostDevicesTable()
        {
            dataGridViewHostDevs.Rows.Clear();
            var sequence = units.Where(unit => unit.Type == Type.HostDevice).Select(unit => new { DeviceName = unit.Name, HostDeviceSurvivability = unit.Survivability });
            foreach (var element in sequence)
            {
                dataGridViewHostDevs.Rows.Add(new object[] { element.DeviceName, element.HostDeviceSurvivability});
            }
        }

        private void refreshConnectionsTable()
        {
            dataGridViewConnections.Rows.Clear();
            var sequence = units.Where(unit => unit.Type == Type.Connection);
            foreach (var element in sequence)
            {
                dataGridViewConnections.Rows.Add(new object[] { element.Name, element.Device1.Name, element.Device2.Name, element.Survivability});
            }
        }


        private void contextMenuItem_Clicked(object sender, EventArgs e)
        {
            switch (contextMenuStripDGV.SourceControl.Name)
            {
                case "dataGridViewNetworkDevs":
                    foreach (DataGridViewRow row in dataGridViewNetworkDevs.SelectedRows)
                    {
                        units.Remove(new Unit(Type.NetworkDevice, (string)row.Cells["DeviceName"].Value, (double)row.Cells["NetworkDeviceSurvivability"].Value));
                        List<Unit> removingUnit = units.FindAll(unit => unit.Type == Type.Connection && (unit.Device1.Name == (string)row.Cells["DeviceName"].Value || unit.Device2.Name == (string)row.Cells["DeviceName"].Value));
                        foreach(Unit u in removingUnit)
                        {
                            units.Remove(u);
                            foreach (DataGridViewRow r in dataGridViewConnections.Rows)
                            {
                                if ((string)r.Cells["ConnectionName"].Value == u.Name)
                                {
                                    dataGridViewConnections.Rows.RemoveAt(r.Index);
                                }
                            }
                        }
                        dataGridViewNetworkDevs.Rows.RemoveAt(row.Index);
                        refreshComboboxes();
                    }
                    break;
                case "dataGridViewHostDevs":
                    foreach (DataGridViewRow row in dataGridViewHostDevs.SelectedRows)
                    {
                        units.Remove(new Unit(Type.HostDevice, (string)row.Cells["HostName"].Value, (double)row.Cells["HostSurvivability"].Value));
                        List<Unit> removingUnit = units.FindAll(unit => unit.Type == Type.Connection && (unit.Device1.Name == (string)row.Cells["HostName"].Value || unit.Device2.Name == (string)row.Cells["HostName"].Value));
                        foreach (Unit u in removingUnit)
                        {
                            units.Remove(u);
                            foreach (DataGridViewRow r in dataGridViewConnections.Rows)
                            {
                                if ((string)r.Cells["ConnectionName"].Value == u.Name)
                                {
                                    dataGridViewConnections.Rows.RemoveAt(r.Index);
                                }
                            }
                        }
                        dataGridViewHostDevs.Rows.RemoveAt(row.Index);
                        refreshComboboxes();
                    }
                    break;
                case "dataGridViewConnections":
                    foreach (DataGridViewRow row in dataGridViewConnections.SelectedRows)
                    {
                        units.Remove(new Unit(Type.HostDevice, (string)row.Cells["ConnectionName"].Value, (double)row.Cells["ConnectionSurvivability"].Value));
                        dataGridViewConnections.Rows.RemoveAt(row.Index);
                        refreshComboboxes();
                    }
                    break;
            }
        }

        private void comboBoxConnFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Вычисление живучести S-норма - максимум, T-норма - минимум

            // Живучесть канала - минимум живучести устройств и соединения
            // Создадим список каналов из списка всего что у нас есть
            // Из списка всего оставляем список соединений и вычисляем их новые живучести

            List<Unit> channels = units.FindAll(unit => unit.Type == Type.Connection);
            List<Unit> devices = units.FindAll(unit => unit.Type == Type.NetworkDevice || unit.Type == Type.HostDevice);
            channels.ForEach(channel => { channel.Survivability = Math.Min(channel.Survivability, Math.Min(channel.Device1.Survivability, channel.Device2.Survivability)); });
            
            // Вывод в лог инфы о каналах

            foreach(Unit channel in channels)
            {
                textBoxProgressLog.AppendText("Канал " + channel.Name + " между узлами " + channel.Device1.Name + " и " + channel.Device2.Name + 
                    " имеет живучесть " + channel.Survivability + Environment.NewLine);
            }

            // Нужно найти живучесть для каждого устройства к каждому
            // Нужна матрица смежности. Наверное это будет двумерный массив. Надо пронумеровать устройства.

            Dictionary<int, Unit> numberedDevices = new Dictionary<int, Unit>();
            int tmp = 0;
            foreach(Unit unit in devices)
            {
                numberedDevices.Add(tmp, unit);
                tmp++;
            }

            // А вот и массив

            int devicesCount = devices.Count();
            double[,] adjacencyMatrix = new double[devicesCount, devicesCount];
            for(int i = 0; i < devicesCount; i++)
            {
                for(int j = 0; j < devicesCount; j++)
                { // Заполняем матрицу смежности. Веса это живучесть, где связи нет - там 0
                    Unit channelFound = channels.Find(channel => channel.Device1.Name == numberedDevices[i].Name && channel.Device2.Name == numberedDevices[j].Name
                    || channel.Device1.Name == numberedDevices[j].Name && channel.Device2.Name == numberedDevices[i].Name);
                    adjacencyMatrix[i,j] = channelFound == default(Unit) ? -1 : channelFound.Survivability;
                }
            }

            // Сделаем вывод матрицы смежности чтобы было че показать в логах

            textBoxProgressLog.AppendText(Environment.NewLine + "Матрица смежности для устройств со следующими условными номерами: ");

            for (int i = 0; i < numberedDevices.Count(); i++)
            {
                textBoxProgressLog.AppendText(Environment.NewLine + "Номеру " + i + " соответствует устройство с названием " + numberedDevices[i].Name); 
            }
            textBoxProgressLog.AppendText(Environment.NewLine + "\t");

            for (int i = 0; i < devicesCount; i++)
            {
                textBoxProgressLog.AppendText("\t" +  i);
            }

            for (int i = 0; i < devicesCount; i++)
            {
                textBoxProgressLog.AppendText(Environment.NewLine + i + "\t|\t");
                for (int j = 0; j < devicesCount; j++)
                { 
                    textBoxProgressLog.AppendText((adjacencyMatrix[i, j] < 0 ? 0 : adjacencyMatrix[i, j]) + "\t");
                }
                textBoxProgressLog.AppendText("\t|");
            }
            textBoxProgressLog.AppendText(Environment.NewLine);

            //


            // Теперь надо для каждого устройства к каждому заполнять еще какую-то матрицу
            // Если устройств 10, то и матриц 10. В итоге для каждого устройства найдем живучесть пути до всех остальных

            double[,] survivabilityMatrix = new double[devicesCount - 1, devicesCount];
            double[,] survivabilityMatrixFinal = new double[devicesCount, devicesCount];

            for (int currentDevice = 0; currentDevice < devicesCount; currentDevice++)
            {
                // Начало рассчета матрицы для текущего устройства
                for(int currentPathLength = 1; currentPathLength < devicesCount; currentPathLength++)
                {
                    // Ищем в предыдущей строке устройства назначения для которых живучесть больше 0.
                    List<int> devicesWithPathLingthMinus1 = new List<int>();
                    if (currentPathLength > 1) {
                        for (int destinationDevice = 0; destinationDevice < devicesCount; destinationDevice++)
                        {
                            if(survivabilityMatrix[currentPathLength - 2, destinationDevice] > 0)
                            {
                                devicesWithPathLingthMinus1.Add(destinationDevice);
                            }
                        }
                    }
                    for (int destinationDevice = 0; destinationDevice < devicesCount; destinationDevice++)
                    {
                        if (currentPathLength == 1)
                        {
                            survivabilityMatrix[currentPathLength - 1, destinationDevice] = adjacencyMatrix[currentDevice, destinationDevice];
                        }
                        else
                        {
                            // Смотрим все пути в матрице смежности из устройств предыдущей строки в устройство назначения,
                            // Выбираем минимальную живучесть в пути как живучесть всего этого пути,
                            // Выбираем максимально живучий путь как путь из текущего устройства в устройство назначения и записываем в таблицу его
                            double survToDestination = -1;
                            foreach(int dev in devicesWithPathLingthMinus1)
                            {
                                // Находим минимум из пути в предыдущую точку и пути из нее в точку назначения
                                // Берем максимум от всех таких путей
                                if (adjacencyMatrix[dev, destinationDevice] > 0)
                                {
                                    survToDestination = Math.Max(Math.Min(survivabilityMatrix[currentPathLength - 2, dev], adjacencyMatrix[dev, destinationDevice]), survToDestination);
                                }
                            }

                            survivabilityMatrix[currentPathLength - 1, destinationDevice] = survToDestination;
                        }
                    }
                }
                // Тут заканчивается рассчет матрицы для текущего устройства и нужно что-то вычислить, потом уже считать матрицу для другого устройства
                // А еще ее можно вывести в лог
                // TODO: вывести в лог матрицу

                textBoxProgressLog.AppendText(Environment.NewLine + "Матрица для устройства " + numberedDevices[currentDevice].Name + " под условным номером " + currentDevice + Environment.NewLine + "\t");

                for (int i = 0; i < devicesCount; i++)
                {
                    textBoxProgressLog.AppendText("\t" + i);
                }

                for (int i = 1; i < devicesCount; i++)
                {
                    textBoxProgressLog.AppendText(Environment.NewLine + i + "\t|\t");
                    for (int j = 0; j < devicesCount; j++)
                    {
                        textBoxProgressLog.AppendText((survivabilityMatrix[i - 1, j] < 0 ? 0 : survivabilityMatrix[i - 1, j]) + "\t");
                    }
                    textBoxProgressLog.AppendText("\t|");
                }
                textBoxProgressLog.AppendText(Environment.NewLine);

                //



                // Вроде надо найти максимум по столбцам
                for (int destinationDevice = 0; destinationDevice < devicesCount; destinationDevice++)
                {
                    double max = -1;
                    for (int row = 1; row < devicesCount; row++)
                    {
                        max = Math.Max(survivabilityMatrix[row - 1, destinationDevice], max);
                    } // Максимум по столбцам уходит в строку общей матрицы
                    survivabilityMatrixFinal[currentDevice, destinationDevice] = max;
                }

            }

            textBoxProgressLog.AppendText(Environment.NewLine + "Матрица с живучестью путей от одного устройства к другому для всех устройств: "+ Environment.NewLine + "\t");

            for (int i = 0; i < devicesCount; i++)
            {
                textBoxProgressLog.AppendText("\t" + i);
            }

            for (int i = 0; i < devicesCount; i++)
            {
                textBoxProgressLog.AppendText(Environment.NewLine + i + "\t|\t");
                for (int j = 0; j < devicesCount; j++)
                {
                    textBoxProgressLog.AppendText((survivabilityMatrixFinal[i, j] < 0 ? 0 : survivabilityMatrixFinal[i, j]) + "\t");
                }
                textBoxProgressLog.AppendText("\t|");
            }
            textBoxProgressLog.AppendText(Environment.NewLine);

            //


            // Финальный подсчет живучести всей РИС
            // Это минимум по всем путям от устройства к устройству
            // То есть минимум по таблице survivabilityMatrixFinal
            double result = 1;
            for(int i = 0; i < devicesCount; i++)
            {
                for(int j = 0; j < devicesCount; j++)
                {
                    result = Math.Min(survivabilityMatrixFinal[i, j], result);
                }
            }
            textBoxResult.Text = "Живучесть РИС = " + result.ToString();
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            textBoxProgressLog.Clear();
        }
    }
}
