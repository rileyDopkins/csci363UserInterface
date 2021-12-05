
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 95D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 89D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 110D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 105D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 88D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 98D);
            this.timer_day = new System.Windows.Forms.Timer(this.components);
            this.timer_systemTest = new System.Windows.Forms.Timer(this.components);
            this.timer_bloodSugarTest = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpBx_SystemStatus = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_battery = new System.Windows.Forms.Label();
            this.lbl_sensorStatus = new System.Windows.Forms.Label();
            this.lbl_pumpStatus = new System.Windows.Forms.Label();
            this.lbl_needleStatus = new System.Windows.Forms.Label();
            this.lbl_sensor = new System.Windows.Forms.Label();
            this.lbl_pump = new System.Windows.Forms.Label();
            this.lbl_needle = new System.Windows.Forms.Label();
            this.grpBx_system = new System.Windows.Forms.GroupBox();
            this.comboBx_general = new System.Windows.Forms.ComboBox();
            this.lbl_general = new System.Windows.Forms.Label();
            this.comboBx_userMode = new System.Windows.Forms.ComboBox();
            this.lbl_UserMode = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_testScenarios = new System.Windows.Forms.Label();
            this.btn_test = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_reservoir = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_addDose = new System.Windows.Forms.Button();
            this.lbl_lastDoseTitle = new System.Windows.Forms.Label();
            this.lbl_bsTitle = new System.Windows.Forms.Label();
            this.lbl_units = new System.Windows.Forms.Label();
            this.lbl_mgDL = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_bs = new System.Windows.Forms.Label();
            this.lbl_lastDose = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_reservoirUnits = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_24HourTimer = new System.Windows.Forms.Label();
            this.blb_batteryREAL = new System.Windows.Forms.Label();
            this.doseHelpButton = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.grpBx_SystemStatus.SuspendLayout();
            this.grpBx_system.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_day
            // 
            this.timer_day.Enabled = true;
            this.timer_day.Interval = 1000;
            this.timer_day.Tick += new System.EventHandler(this.timer_day_Tick);
            // 
            // timer_systemTest
            // 
            this.timer_systemTest.Interval = 30000;
            this.timer_systemTest.Tick += new System.EventHandler(this.timer_systemTest_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 46);
            this.label4.TabIndex = 20;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 46);
            this.label6.TabIndex = 20;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 21;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpBx_SystemStatus);
            this.tabPage3.Controls.Add(this.grpBx_system);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1116, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpBx_SystemStatus
            // 
            this.grpBx_SystemStatus.Controls.Add(this.label2);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_battery);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_sensorStatus);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_pumpStatus);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_needleStatus);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_sensor);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_pump);
            this.grpBx_SystemStatus.Controls.Add(this.lbl_needle);
            this.grpBx_SystemStatus.Enabled = false;
            this.grpBx_SystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBx_SystemStatus.Location = new System.Drawing.Point(20, 141);
            this.grpBx_SystemStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBx_SystemStatus.Name = "grpBx_SystemStatus";
            this.grpBx_SystemStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBx_SystemStatus.Size = new System.Drawing.Size(322, 196);
            this.grpBx_SystemStatus.TabIndex = 5;
            this.grpBx_SystemStatus.TabStop = false;
            this.grpBx_SystemStatus.Text = "System Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "100%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_battery
            // 
            this.lbl_battery.AutoSize = true;
            this.lbl_battery.Location = new System.Drawing.Point(16, 32);
            this.lbl_battery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_battery.Name = "lbl_battery";
            this.lbl_battery.Size = new System.Drawing.Size(119, 20);
            this.lbl_battery.TabIndex = 10;
            this.lbl_battery.Text = "Battery Status: ";
            // 
            // lbl_sensorStatus
            // 
            this.lbl_sensorStatus.AutoSize = true;
            this.lbl_sensorStatus.Location = new System.Drawing.Point(126, 132);
            this.lbl_sensorStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sensorStatus.Name = "lbl_sensorStatus";
            this.lbl_sensorStatus.Size = new System.Drawing.Size(49, 20);
            this.lbl_sensorStatus.TabIndex = 8;
            this.lbl_sensorStatus.Text = "Good";
            this.lbl_sensorStatus.Click += new System.EventHandler(this.lbl_sensorStatus_Click);
            // 
            // lbl_pumpStatus
            // 
            this.lbl_pumpStatus.AutoSize = true;
            this.lbl_pumpStatus.Location = new System.Drawing.Point(167, 98);
            this.lbl_pumpStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pumpStatus.Name = "lbl_pumpStatus";
            this.lbl_pumpStatus.Size = new System.Drawing.Size(49, 20);
            this.lbl_pumpStatus.TabIndex = 7;
            this.lbl_pumpStatus.Text = "Good";
            // 
            // lbl_needleStatus
            // 
            this.lbl_needleStatus.AutoSize = true;
            this.lbl_needleStatus.Location = new System.Drawing.Point(126, 65);
            this.lbl_needleStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_needleStatus.Name = "lbl_needleStatus";
            this.lbl_needleStatus.Size = new System.Drawing.Size(49, 20);
            this.lbl_needleStatus.TabIndex = 6;
            this.lbl_needleStatus.Text = "Good";
            // 
            // lbl_sensor
            // 
            this.lbl_sensor.AutoSize = true;
            this.lbl_sensor.Location = new System.Drawing.Point(16, 132);
            this.lbl_sensor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sensor.Name = "lbl_sensor";
            this.lbl_sensor.Size = new System.Drawing.Size(119, 20);
            this.lbl_sensor.TabIndex = 4;
            this.lbl_sensor.Text = "Sensor Status: ";
            // 
            // lbl_pump
            // 
            this.lbl_pump.AutoSize = true;
            this.lbl_pump.Location = new System.Drawing.Point(16, 98);
            this.lbl_pump.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pump.Name = "lbl_pump";
            this.lbl_pump.Size = new System.Drawing.Size(159, 20);
            this.lbl_pump.TabIndex = 3;
            this.lbl_pump.Text = "Insulin Pump Status: ";
            // 
            // lbl_needle
            // 
            this.lbl_needle.AutoSize = true;
            this.lbl_needle.Location = new System.Drawing.Point(16, 65);
            this.lbl_needle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_needle.Name = "lbl_needle";
            this.lbl_needle.Size = new System.Drawing.Size(118, 20);
            this.lbl_needle.TabIndex = 2;
            this.lbl_needle.Text = "Needle Status: ";
            // 
            // grpBx_system
            // 
            this.grpBx_system.Controls.Add(this.comboBx_general);
            this.grpBx_system.Controls.Add(this.lbl_general);
            this.grpBx_system.Controls.Add(this.comboBx_userMode);
            this.grpBx_system.Controls.Add(this.lbl_UserMode);
            this.grpBx_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBx_system.Location = new System.Drawing.Point(20, 14);
            this.grpBx_system.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBx_system.Name = "grpBx_system";
            this.grpBx_system.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBx_system.Size = new System.Drawing.Size(287, 113);
            this.grpBx_system.TabIndex = 0;
            this.grpBx_system.TabStop = false;
            this.grpBx_system.Text = "System Settings";
            // 
            // comboBx_general
            // 
            this.comboBx_general.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_general.FormattingEnabled = true;
            this.comboBx_general.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBx_general.Location = new System.Drawing.Point(118, 30);
            this.comboBx_general.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBx_general.Name = "comboBx_general";
            this.comboBx_general.Size = new System.Drawing.Size(99, 28);
            this.comboBx_general.TabIndex = 3;
            this.comboBx_general.SelectedIndexChanged += new System.EventHandler(this.comboBx_general_SelectedIndexChanged);
            // 
            // lbl_general
            // 
            this.lbl_general.AutoSize = true;
            this.lbl_general.Location = new System.Drawing.Point(16, 32);
            this.lbl_general.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_general.Name = "lbl_general";
            this.lbl_general.Size = new System.Drawing.Size(70, 20);
            this.lbl_general.TabIndex = 2;
            this.lbl_general.Text = "General:";
            // 
            // comboBx_userMode
            // 
            this.comboBx_userMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_userMode.Enabled = false;
            this.comboBx_userMode.FormattingEnabled = true;
            this.comboBx_userMode.Items.AddRange(new object[] {
            "MANUAL",
            "AUTO"});
            this.comboBx_userMode.Location = new System.Drawing.Point(118, 65);
            this.comboBx_userMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBx_userMode.Name = "comboBx_userMode";
            this.comboBx_userMode.Size = new System.Drawing.Size(99, 28);
            this.comboBx_userMode.TabIndex = 1;
            this.comboBx_userMode.SelectedIndexChanged += new System.EventHandler(this.comboBx_userMode_SelectedIndexChanged);
            // 
            // lbl_UserMode
            // 
            this.lbl_UserMode.AutoSize = true;
            this.lbl_UserMode.Location = new System.Drawing.Point(16, 67);
            this.lbl_UserMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserMode.Name = "lbl_UserMode";
            this.lbl_UserMode.Size = new System.Drawing.Size(91, 20);
            this.lbl_UserMode.TabIndex = 0;
            this.lbl_UserMode.Text = "User Mode:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lbl_testScenarios);
            this.tabPage2.Controls.Add(this.btn_test);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1116, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            // 
            // lbl_testScenarios
            // 
            this.lbl_testScenarios.AutoSize = true;
            this.lbl_testScenarios.Location = new System.Drawing.Point(21, 37);
            this.lbl_testScenarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_testScenarios.Name = "lbl_testScenarios";
            this.lbl_testScenarios.Size = new System.Drawing.Size(135, 24);
            this.lbl_testScenarios.TabIndex = 5;
            this.lbl_testScenarios.Text = "Test Scenarios";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(70, 271);
            this.btn_test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(140, 38);
            this.btn_test.TabIndex = 4;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Low Battery",
            "Needle Failure",
            "Pump Failure",
            "Sensor Failure",
            "Battery Replaced",
            "Needle Replaced",
            "Sensor Fixed",
            "Battery Replaced"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 63);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 172);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.doseHelpButton);
            this.tabPage1.Controls.Add(this.lbl_reservoir);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btn_addDose);
            this.tabPage1.Controls.Add(this.lbl_lastDoseTitle);
            this.tabPage1.Controls.Add(this.lbl_bsTitle);
            this.tabPage1.Controls.Add(this.lbl_units);
            this.tabPage1.Controls.Add(this.lbl_mgDL);
            this.tabPage1.Controls.Add(this.chart3);
            this.tabPage1.Controls.Add(this.lbl_bs);
            this.tabPage1.Controls.Add(this.lbl_lastDose);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbl_reservoirUnits);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1116, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // lbl_reservoir
            // 
            this.lbl_reservoir.AutoSize = true;
            this.lbl_reservoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_reservoir.Location = new System.Drawing.Point(19, 292);
            this.lbl_reservoir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reservoir.Name = "lbl_reservoir";
            this.lbl_reservoir.Size = new System.Drawing.Size(151, 20);
            this.lbl_reservoir.TabIndex = 50;
            this.lbl_reservoir.Text = "16.0 units remaining";
            this.lbl_reservoir.Click += new System.EventHandler(this.lbl_reservoir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(248, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 29);
            this.label11.TabIndex = 49;
            this.label11.Text = "Blood Sugar History";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_addDose
            // 
            this.btn_addDose.Enabled = false;
            this.btn_addDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addDose.Location = new System.Drawing.Point(23, 248);
            this.btn_addDose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addDose.Name = "btn_addDose";
            this.btn_addDose.Size = new System.Drawing.Size(143, 41);
            this.btn_addDose.TabIndex = 48;
            this.btn_addDose.Text = "Add dose";
            this.btn_addDose.UseVisualStyleBackColor = true;
            this.btn_addDose.Click += new System.EventHandler(this.btn_addDose_Click);
            // 
            // lbl_lastDoseTitle
            // 
            this.lbl_lastDoseTitle.AutoSize = true;
            this.lbl_lastDoseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_lastDoseTitle.Location = new System.Drawing.Point(3, 122);
            this.lbl_lastDoseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastDoseTitle.Name = "lbl_lastDoseTitle";
            this.lbl_lastDoseTitle.Size = new System.Drawing.Size(195, 29);
            this.lbl_lastDoseTitle.TabIndex = 47;
            this.lbl_lastDoseTitle.Text = "Last Insulin Dose";
            this.lbl_lastDoseTitle.Click += new System.EventHandler(this.lbl_lastDoseTitle_Click);
            // 
            // lbl_bsTitle
            // 
            this.lbl_bsTitle.AutoSize = true;
            this.lbl_bsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_bsTitle.Location = new System.Drawing.Point(18, 6);
            this.lbl_bsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bsTitle.Name = "lbl_bsTitle";
            this.lbl_bsTitle.Size = new System.Drawing.Size(147, 29);
            this.lbl_bsTitle.TabIndex = 46;
            this.lbl_bsTitle.Text = "Blood Sugar";
            this.lbl_bsTitle.Click += new System.EventHandler(this.lbl_bsTitle_Click);
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_units.Location = new System.Drawing.Point(112, 210);
            this.lbl_units.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(43, 20);
            this.lbl_units.TabIndex = 45;
            this.lbl_units.Text = "units";
            this.lbl_units.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_units.Click += new System.EventHandler(this.lbl_units_Click);
            // 
            // lbl_mgDL
            // 
            this.lbl_mgDL.AutoSize = true;
            this.lbl_mgDL.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_mgDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mgDL.Location = new System.Drawing.Point(102, 93);
            this.lbl_mgDL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mgDL.Name = "lbl_mgDL";
            this.lbl_mgDL.Size = new System.Drawing.Size(53, 20);
            this.lbl_mgDL.TabIndex = 44;
            this.lbl_mgDL.Text = "mg/dL";
            this.lbl_mgDL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_mgDL.Click += new System.EventHandler(this.lbl_mgDL_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(208, 47);
            this.chart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.MarkerSize = 10;
            series5.Name = "Blood Sugar";
            series5.Points.Add(dataPoint21);
            series5.Points.Add(dataPoint22);
            series5.Points.Add(dataPoint23);
            series5.Points.Add(dataPoint24);
            series5.Points.Add(dataPoint25);
            series5.Points.Add(dataPoint26);
            series5.Points.Add(dataPoint27);
            series5.Points.Add(dataPoint28);
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.MarkerSize = 10;
            series6.Name = "Insulin Injection";
            series6.Points.Add(dataPoint29);
            series6.Points.Add(dataPoint30);
            this.chart3.Series.Add(series5);
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(261, 244);
            this.chart3.TabIndex = 43;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // lbl_bs
            // 
            this.lbl_bs.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_bs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bs.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_bs.Location = new System.Drawing.Point(22, 34);
            this.lbl_bs.Name = "lbl_bs";
            this.lbl_bs.Size = new System.Drawing.Size(143, 88);
            this.lbl_bs.TabIndex = 51;
            this.lbl_bs.Text = "100";
            this.lbl_bs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_bs.TextChanged += new System.EventHandler(this.lbl_bs_TextChanged);
            this.lbl_bs.Click += new System.EventHandler(this.lbl_bs_Click);
            // 
            // lbl_lastDose
            // 
            this.lbl_lastDose.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lastDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lastDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDose.Location = new System.Drawing.Point(22, 151);
            this.lbl_lastDose.Name = "lbl_lastDose";
            this.lbl_lastDose.Size = new System.Drawing.Size(143, 88);
            this.lbl_lastDose.TabIndex = 52;
            this.lbl_lastDose.Text = "1.5";
            this.lbl_lastDose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_lastDose.Click += new System.EventHandler(this.lbl_lastDose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(59, -15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 23;
            // 
            // lbl_reservoirUnits
            // 
            this.lbl_reservoirUnits.AutoSize = true;
            this.lbl_reservoirUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservoirUnits.Location = new System.Drawing.Point(82, 271);
            this.lbl_reservoirUnits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reservoirUnits.Name = "lbl_reservoirUnits";
            this.lbl_reservoirUnits.Size = new System.Drawing.Size(0, 20);
            this.lbl_reservoirUnits.TabIndex = 7;
            this.lbl_reservoirUnits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(49, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(8, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1124, 400);
            this.tabControl.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(334, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(56, 22);
            this.progressBar1.TabIndex = 53;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_24HourTimer
            // 
            this.lbl_24HourTimer.AutoSize = true;
            this.lbl_24HourTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_24HourTimer.Location = new System.Drawing.Point(396, 1);
            this.lbl_24HourTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_24HourTimer.Name = "lbl_24HourTimer";
            this.lbl_24HourTimer.Size = new System.Drawing.Size(118, 20);
            this.lbl_24HourTimer.TabIndex = 54;
            this.lbl_24HourTimer.Text = "Clock: 00:00:00";
            this.lbl_24HourTimer.Click += new System.EventHandler(this.lbl_24HourTimer_Click);
            // 
            // blb_batteryREAL
            // 
            this.blb_batteryREAL.AutoSize = true;
            this.blb_batteryREAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.blb_batteryREAL.Location = new System.Drawing.Point(274, 1);
            this.blb_batteryREAL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blb_batteryREAL.Name = "blb_batteryREAL";
            this.blb_batteryREAL.Size = new System.Drawing.Size(60, 20);
            this.blb_batteryREAL.TabIndex = 55;
            this.blb_batteryREAL.Text = "Battery";
            // 
            // doseHelpButton
            // 
            this.doseHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doseHelpButton.Location = new System.Drawing.Point(171, 264);
            this.doseHelpButton.Name = "doseHelpButton";
            this.doseHelpButton.Size = new System.Drawing.Size(27, 25);
            this.doseHelpButton.TabIndex = 53;
            this.doseHelpButton.Text = "?";
            this.doseHelpButton.UseVisualStyleBackColor = true;
            this.doseHelpButton.Click += new System.EventHandler(this.doseHelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 428);
            this.Controls.Add(this.blb_batteryREAL);
            this.Controls.Add(this.lbl_24HourTimer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.grpBx_SystemStatus.ResumeLayout(false);
            this.grpBx_SystemStatus.PerformLayout();
            this.grpBx_system.ResumeLayout(false);
            this.grpBx_system.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_day;
        private System.Windows.Forms.Timer timer_systemTest;
        private System.Windows.Forms.Timer timer_bloodSugarTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpBx_SystemStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_battery;
        private System.Windows.Forms.Label lbl_sensorStatus;
        private System.Windows.Forms.Label lbl_pumpStatus;
        private System.Windows.Forms.Label lbl_needleStatus;
        private System.Windows.Forms.Label lbl_sensor;
        private System.Windows.Forms.Label lbl_pump;
        private System.Windows.Forms.Label lbl_needle;
        private System.Windows.Forms.GroupBox grpBx_system;
        private System.Windows.Forms.ComboBox comboBx_general;
        private System.Windows.Forms.Label lbl_general;
        private System.Windows.Forms.ComboBox comboBx_userMode;
        private System.Windows.Forms.Label lbl_UserMode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_reservoir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_addDose;
        private System.Windows.Forms.Label lbl_lastDoseTitle;
        private System.Windows.Forms.Label lbl_bsTitle;
        private System.Windows.Forms.Label lbl_units;
        private System.Windows.Forms.Label lbl_mgDL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label lbl_bs;
        private System.Windows.Forms.Label lbl_lastDose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_reservoirUnits;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_24HourTimer;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbl_testScenarios;
        private System.Windows.Forms.Label blb_batteryREAL;
        private System.Windows.Forms.Button doseHelpButton;
    }
}

