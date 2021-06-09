
namespace DISSurvivabilityCalculation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerSecond = new System.Windows.Forms.SplitContainer();
            this.textBoxNetworkDeviceName = new System.Windows.Forms.TextBox();
            this.groupBoxNetworkDevices = new System.Windows.Forms.GroupBox();
            this.groupBoxHostDevices = new System.Windows.Forms.GroupBox();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelNetworkDevicesSurvivability = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNetworkDevice = new System.Windows.Forms.Button();
            this.splitContainerThird = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Survivability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerFourth = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddHostDevice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHostDevsSurvivability = new System.Windows.Forms.NumericUpDown();
            this.textBoxHostDevsName = new System.Windows.Forms.TextBox();
            this.buttonAddConnection = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecond)).BeginInit();
            this.splitContainerSecond.Panel2.SuspendLayout();
            this.splitContainerSecond.SuspendLayout();
            this.groupBoxNetworkDevices.SuspendLayout();
            this.groupBoxHostDevices.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerThird)).BeginInit();
            this.splitContainerThird.Panel1.SuspendLayout();
            this.splitContainerThird.Panel2.SuspendLayout();
            this.splitContainerThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFourth)).BeginInit();
            this.splitContainerFourth.Panel1.SuspendLayout();
            this.splitContainerFourth.Panel2.SuspendLayout();
            this.splitContainerFourth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHostDevsSurvivability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxConnections);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxHostDevices);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxNetworkDevices);
            this.splitContainerMain.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerSecond);
            this.splitContainerMain.Size = new System.Drawing.Size(1015, 529);
            this.splitContainerMain.SplitterDistance = 332;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerSecond
            // 
            this.splitContainerSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSecond.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSecond.Name = "splitContainerSecond";
            this.splitContainerSecond.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerSecond.Panel2
            // 
            this.splitContainerSecond.Panel2.Controls.Add(this.splitContainerThird);
            this.splitContainerSecond.Size = new System.Drawing.Size(679, 529);
            this.splitContainerSecond.SplitterDistance = 290;
            this.splitContainerSecond.TabIndex = 0;
            // 
            // textBoxNetworkDeviceName
            // 
            this.textBoxNetworkDeviceName.Location = new System.Drawing.Point(137, 67);
            this.textBoxNetworkDeviceName.Name = "textBoxNetworkDeviceName";
            this.textBoxNetworkDeviceName.Size = new System.Drawing.Size(166, 20);
            this.textBoxNetworkDeviceName.TabIndex = 0;
            // 
            // groupBoxNetworkDevices
            // 
            this.groupBoxNetworkDevices.AutoSize = true;
            this.groupBoxNetworkDevices.Controls.Add(this.label4);
            this.groupBoxNetworkDevices.Controls.Add(this.buttonAddNetworkDevice);
            this.groupBoxNetworkDevices.Controls.Add(this.label1);
            this.groupBoxNetworkDevices.Controls.Add(this.labelNetworkDevicesSurvivability);
            this.groupBoxNetworkDevices.Controls.Add(this.numericUpDown2);
            this.groupBoxNetworkDevices.Controls.Add(this.textBoxNetworkDeviceName);
            this.groupBoxNetworkDevices.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNetworkDevices.Name = "groupBoxNetworkDevices";
            this.groupBoxNetworkDevices.Size = new System.Drawing.Size(309, 136);
            this.groupBoxNetworkDevices.TabIndex = 2;
            this.groupBoxNetworkDevices.TabStop = false;
            this.groupBoxNetworkDevices.Text = "Устройства инфраструктуры сети";
            // 
            // groupBoxHostDevices
            // 
            this.groupBoxHostDevices.Controls.Add(this.label7);
            this.groupBoxHostDevices.Controls.Add(this.buttonAddHostDevice);
            this.groupBoxHostDevices.Controls.Add(this.label2);
            this.groupBoxHostDevices.Controls.Add(this.label3);
            this.groupBoxHostDevices.Controls.Add(this.numericUpDownHostDevsSurvivability);
            this.groupBoxHostDevices.Controls.Add(this.textBoxHostDevsName);
            this.groupBoxHostDevices.Location = new System.Drawing.Point(12, 153);
            this.groupBoxHostDevices.Name = "groupBoxHostDevices";
            this.groupBoxHostDevices.Size = new System.Drawing.Size(309, 137);
            this.groupBoxHostDevices.TabIndex = 3;
            this.groupBoxHostDevices.TabStop = false;
            this.groupBoxHostDevices.Text = "Оконечные устройства";
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.Controls.Add(this.label10);
            this.groupBoxConnections.Controls.Add(this.label9);
            this.groupBoxConnections.Controls.Add(this.comboBox2);
            this.groupBoxConnections.Controls.Add(this.comboBox1);
            this.groupBoxConnections.Controls.Add(this.label8);
            this.groupBoxConnections.Controls.Add(this.buttonAddConnection);
            this.groupBoxConnections.Controls.Add(this.label5);
            this.groupBoxConnections.Controls.Add(this.label6);
            this.groupBoxConnections.Controls.Add(this.numericUpDown1);
            this.groupBoxConnections.Controls.Add(this.textBox1);
            this.groupBoxConnections.Location = new System.Drawing.Point(12, 296);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(309, 221);
            this.groupBoxConnections.TabIndex = 3;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Соединения";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = true;
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(6, 68);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // labelNetworkDevicesSurvivability
            // 
            this.labelNetworkDevicesSurvivability.AutoSize = true;
            this.labelNetworkDevicesSurvivability.Location = new System.Drawing.Point(6, 52);
            this.labelNetworkDevicesSurvivability.Name = "labelNetworkDevicesSurvivability";
            this.labelNetworkDevicesSurvivability.Size = new System.Drawing.Size(66, 13);
            this.labelNetworkDevicesSurvivability.TabIndex = 4;
            this.labelNetworkDevicesSurvivability.Text = "Живучесть:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование устройства:";
            // 
            // buttonAddNetworkDevice
            // 
            this.buttonAddNetworkDevice.AutoSize = true;
            this.buttonAddNetworkDevice.Location = new System.Drawing.Point(6, 94);
            this.buttonAddNetworkDevice.Name = "buttonAddNetworkDevice";
            this.buttonAddNetworkDevice.Size = new System.Drawing.Size(297, 23);
            this.buttonAddNetworkDevice.TabIndex = 6;
            this.buttonAddNetworkDevice.Text = "Добавить устройство";
            this.buttonAddNetworkDevice.UseVisualStyleBackColor = true;
            // 
            // splitContainerThird
            // 
            this.splitContainerThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerThird.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerThird.Location = new System.Drawing.Point(0, 0);
            this.splitContainerThird.Name = "splitContainerThird";
            // 
            // splitContainerThird.Panel1
            // 
            this.splitContainerThird.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainerThird.Panel2
            // 
            this.splitContainerThird.Panel2.Controls.Add(this.splitContainerFourth);
            this.splitContainerThird.Size = new System.Drawing.Size(679, 235);
            this.splitContainerThird.SplitterDistance = 224;
            this.splitContainerThird.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Survivability,
            this.DeleteButton});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(224, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование устройства";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 90;
            // 
            // Survivability
            // 
            this.Survivability.HeaderText = "Живучесть";
            this.Survivability.Name = "Survivability";
            this.Survivability.ReadOnly = true;
            this.Survivability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Survivability.Width = 70;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "X";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Width = 20;
            // 
            // splitContainerFourth
            // 
            this.splitContainerFourth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFourth.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFourth.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFourth.Name = "splitContainerFourth";
            // 
            // splitContainerFourth.Panel1
            // 
            this.splitContainerFourth.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainerFourth.Panel2
            // 
            this.splitContainerFourth.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainerFourth.Size = new System.Drawing.Size(451, 235);
            this.splitContainerFourth.SplitterDistance = 223;
            this.splitContainerFourth.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(223, 235);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование устройства";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Живучесть";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 20;
            // 
            // buttonAddHostDevice
            // 
            this.buttonAddHostDevice.AutoSize = true;
            this.buttonAddHostDevice.Location = new System.Drawing.Point(6, 101);
            this.buttonAddHostDevice.Name = "buttonAddHostDevice";
            this.buttonAddHostDevice.Size = new System.Drawing.Size(297, 23);
            this.buttonAddHostDevice.TabIndex = 13;
            this.buttonAddHostDevice.Text = "Добавить устройство";
            this.buttonAddHostDevice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование устройства:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Живучесть:";
            // 
            // numericUpDownHostDevsSurvivability
            // 
            this.numericUpDownHostDevsSurvivability.AutoSize = true;
            this.numericUpDownHostDevsSurvivability.DecimalPlaces = 2;
            this.numericUpDownHostDevsSurvivability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownHostDevsSurvivability.Location = new System.Drawing.Point(6, 75);
            this.numericUpDownHostDevsSurvivability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHostDevsSurvivability.Name = "numericUpDownHostDevsSurvivability";
            this.numericUpDownHostDevsSurvivability.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownHostDevsSurvivability.TabIndex = 9;
            // 
            // textBoxHostDevsName
            // 
            this.textBoxHostDevsName.Location = new System.Drawing.Point(137, 74);
            this.textBoxHostDevsName.Name = "textBoxHostDevsName";
            this.textBoxHostDevsName.Size = new System.Drawing.Size(166, 20);
            this.textBoxHostDevsName.TabIndex = 7;
            // 
            // buttonAddConnection
            // 
            this.buttonAddConnection.AutoSize = true;
            this.buttonAddConnection.Location = new System.Drawing.Point(6, 187);
            this.buttonAddConnection.Name = "buttonAddConnection";
            this.buttonAddConnection.Size = new System.Drawing.Size(297, 23);
            this.buttonAddConnection.TabIndex = 20;
            this.buttonAddConnection.Text = "Добавить соединение";
            this.buttonAddConnection.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Наименование соединения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Живучесть:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Последовательно добавляйте информацию о таких \r\nустройствах как маршрутизаторы и " +
    "коммутаторы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Последовательно добавляйте информацию о таких \r\nустройствах как рабочие станции и" +
    " серверы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 52);
            this.label8.TabIndex = 21;
            this.label8.Text = "Последовательно добавляйте информацию о \r\nсоединениях между устройствами, выбрав\r" +
    "\nдва устройства и добавив наименование и \r\nживучесть соединения";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(157, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Соединение от:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "До:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(598, 235);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование соединения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Живучесть";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "X";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 20;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(224, 235);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование соединения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Живучесть";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "X";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 529);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainForm";
            this.Text = "Оценка живучести РИС";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerSecond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecond)).EndInit();
            this.splitContainerSecond.ResumeLayout(false);
            this.groupBoxNetworkDevices.ResumeLayout(false);
            this.groupBoxNetworkDevices.PerformLayout();
            this.groupBoxHostDevices.ResumeLayout(false);
            this.groupBoxHostDevices.PerformLayout();
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.splitContainerThird.Panel1.ResumeLayout(false);
            this.splitContainerThird.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerThird)).EndInit();
            this.splitContainerThird.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainerFourth.Panel1.ResumeLayout(false);
            this.splitContainerFourth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFourth)).EndInit();
            this.splitContainerFourth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHostDevsSurvivability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.GroupBox groupBoxHostDevices;
        private System.Windows.Forms.GroupBox groupBoxNetworkDevices;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBoxNetworkDeviceName;
        private System.Windows.Forms.SplitContainer splitContainerSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNetworkDevicesSurvivability;
        private System.Windows.Forms.Button buttonAddNetworkDevice;
        private System.Windows.Forms.SplitContainer splitContainerThird;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddHostDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHostDevsSurvivability;
        private System.Windows.Forms.TextBox textBoxHostDevsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Survivability;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeleteButton;
        private System.Windows.Forms.SplitContainer splitContainerFourth;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

