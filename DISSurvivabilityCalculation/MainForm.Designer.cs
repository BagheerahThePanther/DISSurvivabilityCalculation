
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxConnTo = new System.Windows.Forms.ComboBox();
            this.comboBoxConnFrom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddConnection = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownConnectionSurvivability = new System.Windows.Forms.NumericUpDown();
            this.textBoxConnectionName = new System.Windows.Forms.TextBox();
            this.groupBoxHostDevices = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddHostDevice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHostDevsSurvivability = new System.Windows.Forms.NumericUpDown();
            this.textBoxHostDevsName = new System.Windows.Forms.TextBox();
            this.groupBoxNetworkDevices = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNetworkDevice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNetworkDevicesSurvivability = new System.Windows.Forms.Label();
            this.numericUpDownNetworkDevsSurvivability = new System.Windows.Forms.NumericUpDown();
            this.textBoxNetworkDeviceName = new System.Windows.Forms.TextBox();
            this.splitContainerSecond = new System.Windows.Forms.SplitContainer();
            this.splitContainerThird = new System.Windows.Forms.SplitContainer();
            this.dataGridViewNetworkDevs = new System.Windows.Forms.DataGridView();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetworkDeviceSurvivability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerFourth = new System.Windows.Forms.SplitContainer();
            this.dataGridViewHostDevs = new System.Windows.Forms.DataGridView();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostSurvivability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
            this.ConnectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionSurvivability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConnectionSurvivability)).BeginInit();
            this.groupBoxHostDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHostDevsSurvivability)).BeginInit();
            this.groupBoxNetworkDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNetworkDevsSurvivability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecond)).BeginInit();
            this.splitContainerSecond.Panel2.SuspendLayout();
            this.splitContainerSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerThird)).BeginInit();
            this.splitContainerThird.Panel1.SuspendLayout();
            this.splitContainerThird.Panel2.SuspendLayout();
            this.splitContainerThird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetworkDevs)).BeginInit();
            this.contextMenuStripDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFourth)).BeginInit();
            this.splitContainerFourth.Panel1.SuspendLayout();
            this.splitContainerFourth.Panel2.SuspendLayout();
            this.splitContainerFourth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHostDevs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.splitContainerMain.Size = new System.Drawing.Size(954, 529);
            this.splitContainerMain.SplitterDistance = 332;
            this.splitContainerMain.TabIndex = 0;
            // 
            // groupBoxConnections
            // 
            this.groupBoxConnections.Controls.Add(this.label10);
            this.groupBoxConnections.Controls.Add(this.label9);
            this.groupBoxConnections.Controls.Add(this.comboBoxConnTo);
            this.groupBoxConnections.Controls.Add(this.comboBoxConnFrom);
            this.groupBoxConnections.Controls.Add(this.label8);
            this.groupBoxConnections.Controls.Add(this.buttonAddConnection);
            this.groupBoxConnections.Controls.Add(this.label5);
            this.groupBoxConnections.Controls.Add(this.label6);
            this.groupBoxConnections.Controls.Add(this.numericUpDownConnectionSurvivability);
            this.groupBoxConnections.Controls.Add(this.textBoxConnectionName);
            this.groupBoxConnections.Location = new System.Drawing.Point(12, 296);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.Size = new System.Drawing.Size(309, 221);
            this.groupBoxConnections.TabIndex = 3;
            this.groupBoxConnections.TabStop = false;
            this.groupBoxConnections.Text = "Соединения";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Соединение от:";
            // 
            // comboBoxConnTo
            // 
            this.comboBoxConnTo.FormattingEnabled = true;
            this.comboBoxConnTo.Location = new System.Drawing.Point(157, 112);
            this.comboBoxConnTo.Name = "comboBoxConnTo";
            this.comboBoxConnTo.Size = new System.Drawing.Size(146, 21);
            this.comboBoxConnTo.TabIndex = 23;
            // 
            // comboBoxConnFrom
            // 
            this.comboBoxConnFrom.FormattingEnabled = true;
            this.comboBoxConnFrom.Location = new System.Drawing.Point(11, 112);
            this.comboBoxConnFrom.Name = "comboBoxConnFrom";
            this.comboBoxConnFrom.Size = new System.Drawing.Size(140, 21);
            this.comboBoxConnFrom.TabIndex = 22;
            this.comboBoxConnFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxConnFrom_SelectedIndexChanged);
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
            // buttonAddConnection
            // 
            this.buttonAddConnection.AutoSize = true;
            this.buttonAddConnection.Location = new System.Drawing.Point(6, 187);
            this.buttonAddConnection.Name = "buttonAddConnection";
            this.buttonAddConnection.Size = new System.Drawing.Size(297, 23);
            this.buttonAddConnection.TabIndex = 20;
            this.buttonAddConnection.Text = "Добавить соединение";
            this.buttonAddConnection.UseVisualStyleBackColor = true;
            this.buttonAddConnection.Click += new System.EventHandler(this.buttonAddConnection_Click);
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
            // numericUpDownConnectionSurvivability
            // 
            this.numericUpDownConnectionSurvivability.AutoSize = true;
            this.numericUpDownConnectionSurvivability.DecimalPlaces = 2;
            this.numericUpDownConnectionSurvivability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownConnectionSurvivability.Location = new System.Drawing.Point(6, 158);
            this.numericUpDownConnectionSurvivability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownConnectionSurvivability.Name = "numericUpDownConnectionSurvivability";
            this.numericUpDownConnectionSurvivability.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownConnectionSurvivability.TabIndex = 16;
            // 
            // textBoxConnectionName
            // 
            this.textBoxConnectionName.Location = new System.Drawing.Point(137, 157);
            this.textBoxConnectionName.Name = "textBoxConnectionName";
            this.textBoxConnectionName.Size = new System.Drawing.Size(166, 20);
            this.textBoxConnectionName.TabIndex = 14;
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
            // buttonAddHostDevice
            // 
            this.buttonAddHostDevice.AutoSize = true;
            this.buttonAddHostDevice.Location = new System.Drawing.Point(6, 101);
            this.buttonAddHostDevice.Name = "buttonAddHostDevice";
            this.buttonAddHostDevice.Size = new System.Drawing.Size(297, 23);
            this.buttonAddHostDevice.TabIndex = 13;
            this.buttonAddHostDevice.Text = "Добавить устройство";
            this.buttonAddHostDevice.UseVisualStyleBackColor = true;
            this.buttonAddHostDevice.Click += new System.EventHandler(this.buttonAddHostDevice_Click);
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
            // groupBoxNetworkDevices
            // 
            this.groupBoxNetworkDevices.AutoSize = true;
            this.groupBoxNetworkDevices.Controls.Add(this.label4);
            this.groupBoxNetworkDevices.Controls.Add(this.buttonAddNetworkDevice);
            this.groupBoxNetworkDevices.Controls.Add(this.label1);
            this.groupBoxNetworkDevices.Controls.Add(this.labelNetworkDevicesSurvivability);
            this.groupBoxNetworkDevices.Controls.Add(this.numericUpDownNetworkDevsSurvivability);
            this.groupBoxNetworkDevices.Controls.Add(this.textBoxNetworkDeviceName);
            this.groupBoxNetworkDevices.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNetworkDevices.Name = "groupBoxNetworkDevices";
            this.groupBoxNetworkDevices.Size = new System.Drawing.Size(309, 136);
            this.groupBoxNetworkDevices.TabIndex = 2;
            this.groupBoxNetworkDevices.TabStop = false;
            this.groupBoxNetworkDevices.Text = "Устройства инфраструктуры сети";
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
            // buttonAddNetworkDevice
            // 
            this.buttonAddNetworkDevice.AutoSize = true;
            this.buttonAddNetworkDevice.Location = new System.Drawing.Point(6, 94);
            this.buttonAddNetworkDevice.Name = "buttonAddNetworkDevice";
            this.buttonAddNetworkDevice.Size = new System.Drawing.Size(297, 23);
            this.buttonAddNetworkDevice.TabIndex = 6;
            this.buttonAddNetworkDevice.Text = "Добавить устройство";
            this.buttonAddNetworkDevice.UseVisualStyleBackColor = true;
            this.buttonAddNetworkDevice.Click += new System.EventHandler(this.buttonAddNetworkDevice_Click);
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
            // labelNetworkDevicesSurvivability
            // 
            this.labelNetworkDevicesSurvivability.AutoSize = true;
            this.labelNetworkDevicesSurvivability.Location = new System.Drawing.Point(6, 52);
            this.labelNetworkDevicesSurvivability.Name = "labelNetworkDevicesSurvivability";
            this.labelNetworkDevicesSurvivability.Size = new System.Drawing.Size(66, 13);
            this.labelNetworkDevicesSurvivability.TabIndex = 4;
            this.labelNetworkDevicesSurvivability.Text = "Живучесть:";
            // 
            // numericUpDownNetworkDevsSurvivability
            // 
            this.numericUpDownNetworkDevsSurvivability.AutoSize = true;
            this.numericUpDownNetworkDevsSurvivability.DecimalPlaces = 2;
            this.numericUpDownNetworkDevsSurvivability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownNetworkDevsSurvivability.Location = new System.Drawing.Point(6, 68);
            this.numericUpDownNetworkDevsSurvivability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNetworkDevsSurvivability.Name = "numericUpDownNetworkDevsSurvivability";
            this.numericUpDownNetworkDevsSurvivability.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownNetworkDevsSurvivability.TabIndex = 2;
            // 
            // textBoxNetworkDeviceName
            // 
            this.textBoxNetworkDeviceName.Location = new System.Drawing.Point(137, 67);
            this.textBoxNetworkDeviceName.Name = "textBoxNetworkDeviceName";
            this.textBoxNetworkDeviceName.Size = new System.Drawing.Size(166, 20);
            this.textBoxNetworkDeviceName.TabIndex = 0;
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
            this.splitContainerSecond.Size = new System.Drawing.Size(618, 529);
            this.splitContainerSecond.SplitterDistance = 290;
            this.splitContainerSecond.TabIndex = 0;
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
            this.splitContainerThird.Panel1.Controls.Add(this.dataGridViewNetworkDevs);
            // 
            // splitContainerThird.Panel2
            // 
            this.splitContainerThird.Panel2.Controls.Add(this.splitContainerFourth);
            this.splitContainerThird.Size = new System.Drawing.Size(618, 235);
            this.splitContainerThird.SplitterDistance = 203;
            this.splitContainerThird.TabIndex = 0;
            // 
            // dataGridViewNetworkDevs
            // 
            this.dataGridViewNetworkDevs.AllowUserToAddRows = false;
            this.dataGridViewNetworkDevs.AllowUserToDeleteRows = false;
            this.dataGridViewNetworkDevs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNetworkDevs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceName,
            this.NetworkDeviceSurvivability});
            this.dataGridViewNetworkDevs.ContextMenuStrip = this.contextMenuStripDGV;
            this.dataGridViewNetworkDevs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNetworkDevs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNetworkDevs.Name = "dataGridViewNetworkDevs";
            this.dataGridViewNetworkDevs.ReadOnly = true;
            this.dataGridViewNetworkDevs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNetworkDevs.Size = new System.Drawing.Size(203, 235);
            this.dataGridViewNetworkDevs.TabIndex = 0;
            this.dataGridViewNetworkDevs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeviceName
            // 
            this.DeviceName.HeaderText = "Наименование устройства";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceName.Width = 90;
            // 
            // NetworkDeviceSurvivability
            // 
            this.NetworkDeviceSurvivability.HeaderText = "Живучесть";
            this.NetworkDeviceSurvivability.Name = "NetworkDeviceSurvivability";
            this.NetworkDeviceSurvivability.ReadOnly = true;
            this.NetworkDeviceSurvivability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NetworkDeviceSurvivability.Width = 70;
            // 
            // contextMenuStripDGV
            // 
            this.contextMenuStripDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteRow});
            this.contextMenuStripDGV.Name = "contextMenuStripDGV";
            this.contextMenuStripDGV.Size = new System.Drawing.Size(119, 26);
            this.contextMenuStripDGV.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripDGV_Opening);
            // 
            // toolStripMenuItemDeleteRow
            // 
            this.toolStripMenuItemDeleteRow.Name = "toolStripMenuItemDeleteRow";
            this.toolStripMenuItemDeleteRow.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemDeleteRow.Text = "Удалить";
            this.toolStripMenuItemDeleteRow.ToolTipText = "Удаление выделенной записи";
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
            this.splitContainerFourth.Panel1.Controls.Add(this.dataGridViewHostDevs);
            // 
            // splitContainerFourth.Panel2
            // 
            this.splitContainerFourth.Panel2.Controls.Add(this.dataGridViewConnections);
            this.splitContainerFourth.Size = new System.Drawing.Size(411, 235);
            this.splitContainerFourth.SplitterDistance = 203;
            this.splitContainerFourth.TabIndex = 0;
            // 
            // dataGridViewHostDevs
            // 
            this.dataGridViewHostDevs.AllowUserToAddRows = false;
            this.dataGridViewHostDevs.AllowUserToDeleteRows = false;
            this.dataGridViewHostDevs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHostDevs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostName,
            this.HostSurvivability});
            this.dataGridViewHostDevs.ContextMenuStrip = this.contextMenuStripDGV;
            this.dataGridViewHostDevs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHostDevs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHostDevs.Name = "dataGridViewHostDevs";
            this.dataGridViewHostDevs.ReadOnly = true;
            this.dataGridViewHostDevs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHostDevs.Size = new System.Drawing.Size(203, 235);
            this.dataGridViewHostDevs.TabIndex = 1;
            // 
            // HostName
            // 
            this.HostName.HeaderText = "Наименование устройства";
            this.HostName.Name = "HostName";
            this.HostName.ReadOnly = true;
            this.HostName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HostName.Width = 90;
            // 
            // HostSurvivability
            // 
            this.HostSurvivability.HeaderText = "Живучесть";
            this.HostSurvivability.Name = "HostSurvivability";
            this.HostSurvivability.ReadOnly = true;
            this.HostSurvivability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HostSurvivability.Width = 70;
            // 
            // dataGridViewConnections
            // 
            this.dataGridViewConnections.AllowUserToAddRows = false;
            this.dataGridViewConnections.AllowUserToDeleteRows = false;
            this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionName,
            this.ConnectionSurvivability});
            this.dataGridViewConnections.ContextMenuStrip = this.contextMenuStripDGV;
            this.dataGridViewConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConnections.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewConnections.Name = "dataGridViewConnections";
            this.dataGridViewConnections.ReadOnly = true;
            this.dataGridViewConnections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConnections.Size = new System.Drawing.Size(204, 235);
            this.dataGridViewConnections.TabIndex = 2;
            // 
            // ConnectionName
            // 
            this.ConnectionName.HeaderText = "Наименование соединения";
            this.ConnectionName.Name = "ConnectionName";
            this.ConnectionName.ReadOnly = true;
            this.ConnectionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConnectionName.Width = 90;
            // 
            // ConnectionSurvivability
            // 
            this.ConnectionSurvivability.HeaderText = "Живучесть";
            this.ConnectionSurvivability.Name = "ConnectionSurvivability";
            this.ConnectionSurvivability.ReadOnly = true;
            this.ConnectionSurvivability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConnectionSurvivability.Width = 70;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 529);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainForm";
            this.Text = "Оценка живучести РИС";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConnectionSurvivability)).EndInit();
            this.groupBoxHostDevices.ResumeLayout(false);
            this.groupBoxHostDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHostDevsSurvivability)).EndInit();
            this.groupBoxNetworkDevices.ResumeLayout(false);
            this.groupBoxNetworkDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNetworkDevsSurvivability)).EndInit();
            this.splitContainerSecond.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSecond)).EndInit();
            this.splitContainerSecond.ResumeLayout(false);
            this.splitContainerThird.Panel1.ResumeLayout(false);
            this.splitContainerThird.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerThird)).EndInit();
            this.splitContainerThird.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetworkDevs)).EndInit();
            this.contextMenuStripDGV.ResumeLayout(false);
            this.splitContainerFourth.Panel1.ResumeLayout(false);
            this.splitContainerFourth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFourth)).EndInit();
            this.splitContainerFourth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHostDevs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.GroupBox groupBoxHostDevices;
        private System.Windows.Forms.GroupBox groupBoxNetworkDevices;
        private System.Windows.Forms.NumericUpDown numericUpDownNetworkDevsSurvivability;
        private System.Windows.Forms.TextBox textBoxNetworkDeviceName;
        private System.Windows.Forms.SplitContainer splitContainerSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNetworkDevicesSurvivability;
        private System.Windows.Forms.Button buttonAddNetworkDevice;
        private System.Windows.Forms.SplitContainer splitContainerThird;
        private System.Windows.Forms.DataGridView dataGridViewNetworkDevs;
        private System.Windows.Forms.Button buttonAddHostDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHostDevsSurvivability;
        private System.Windows.Forms.TextBox textBoxHostDevsName;
        private System.Windows.Forms.SplitContainer splitContainerFourth;
        private System.Windows.Forms.DataGridView dataGridViewHostDevs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxConnTo;
        private System.Windows.Forms.ComboBox comboBoxConnFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownConnectionSurvivability;
        private System.Windows.Forms.TextBox textBoxConnectionName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewConnections;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDGV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetworkDeviceSurvivability;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostSurvivability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionSurvivability;
    }
}

