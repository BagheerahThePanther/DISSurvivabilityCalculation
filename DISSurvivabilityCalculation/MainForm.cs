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
    }
}
