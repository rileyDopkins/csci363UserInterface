
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 95D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint63 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint64 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 89D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint65 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint66 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 110D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint67 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 105D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint68 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint69 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 88D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint70 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 98D);
            this.timer_day = new System.Windows.Forms.Timer(this.components);
            this.timer_systemTest = new System.Windows.Forms.Timer(this.components);
            this.timer_bloodSugarTest = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpBx_personalInfo = new System.Windows.Forms.GroupBox();
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
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.comboBx_general = new System.Windows.Forms.ComboBox();
            this.lbl_general = new System.Windows.Forms.Label();
            this.comboBx_userMode = new System.Windows.Forms.ComboBox();
            this.lbl_UserMode = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.timer_day.Interval = 86400000;
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
            this.tabPage3.Controls.Add(this.grpBx_personalInfo);
            this.tabPage3.Controls.Add(this.grpBx_SystemStatus);
            this.tabPage3.Controls.Add(this.grpBx_system);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1275, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpBx_personalInfo
            // 
            this.grpBx_personalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBx_personalInfo.Location = new System.Drawing.Point(384, 202);
            this.grpBx_personalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx_personalInfo.Name = "grpBx_personalInfo";
            this.grpBx_personalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx_personalInfo.Size = new System.Drawing.Size(340, 154);
            this.grpBx_personalInfo.TabIndex = 6;
            this.grpBx_personalInfo.TabStop = false;
            this.grpBx_personalInfo.Text = "Personal Information";
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
            this.grpBx_SystemStatus.Location = new System.Drawing.Point(382, 14);
            this.grpBx_SystemStatus.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx_SystemStatus.Name = "grpBx_SystemStatus";
            this.grpBx_SystemStatus.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx_SystemStatus.Size = new System.Drawing.Size(344, 173);
            this.grpBx_SystemStatus.TabIndex = 5;
            this.grpBx_SystemStatus.TabStop = false;
            this.grpBx_SystemStatus.Text = "System Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Low. Replace soon.";
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
            this.lbl_sensorStatus.Location = new System.Drawing.Point(167, 132);
            this.lbl_sensorStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sensorStatus.Name = "lbl_sensorStatus";
            this.lbl_sensorStatus.Size = new System.Drawing.Size(107, 20);
            this.lbl_sensorStatus.TabIndex = 8;
            this.lbl_sensorStatus.Text = "Not functional";
            // 
            // lbl_pumpStatus
            // 
            this.lbl_pumpStatus.AutoSize = true;
            this.lbl_pumpStatus.Location = new System.Drawing.Point(167, 98);
            this.lbl_pumpStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pumpStatus.Name = "lbl_pumpStatus";
            this.lbl_pumpStatus.Size = new System.Drawing.Size(45, 20);
            this.lbl_pumpStatus.TabIndex = 7;
            this.lbl_pumpStatus.Text = "good";
            // 
            // lbl_needleStatus
            // 
            this.lbl_needleStatus.AutoSize = true;
            this.lbl_needleStatus.Location = new System.Drawing.Point(167, 65);
            this.lbl_needleStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_needleStatus.Name = "lbl_needleStatus";
            this.lbl_needleStatus.Size = new System.Drawing.Size(45, 20);
            this.lbl_needleStatus.TabIndex = 6;
            this.lbl_needleStatus.Text = "good";
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
            this.grpBx_system.Controls.Add(this.btn_saveSettings);
            this.grpBx_system.Controls.Add(this.comboBx_general);
            this.grpBx_system.Controls.Add(this.lbl_general);
            this.grpBx_system.Controls.Add(this.comboBx_userMode);
            this.grpBx_system.Controls.Add(this.lbl_UserMode);
            this.grpBx_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBx_system.Location = new System.Drawing.Point(20, 14);
            this.grpBx_system.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx_system.Name = "grpBx_system";
            this.grpBx_system.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx_system.Size = new System.Drawing.Size(338, 245);
            this.grpBx_system.TabIndex = 0;
            this.grpBx_system.TabStop = false;
            this.grpBx_system.Text = "System Settings";
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(98, 199);
            this.btn_saveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(148, 28);
            this.btn_saveSettings.TabIndex = 5;
            this.btn_saveSettings.Text = "Save Changes";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            // 
            // comboBx_general
            // 
            this.comboBx_general.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBx_general.FormattingEnabled = true;
            this.comboBx_general.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.comboBx_general.Location = new System.Drawing.Point(118, 30);
            this.comboBx_general.Margin = new System.Windows.Forms.Padding(2);
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
            this.comboBx_userMode.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // lbl_reservoir
            // 
            this.lbl_reservoir.AutoSize = true;
            this.lbl_reservoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_reservoir.Location = new System.Drawing.Point(19, 343);
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
            this.label11.Location = new System.Drawing.Point(232, 50);
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
            this.btn_addDose.Location = new System.Drawing.Point(23, 286);
            this.btn_addDose.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addDose.Name = "btn_addDose";
            this.btn_addDose.Size = new System.Drawing.Size(143, 55);
            this.btn_addDose.TabIndex = 48;
            this.btn_addDose.Text = "Add dose";
            this.btn_addDose.UseVisualStyleBackColor = true;
            this.btn_addDose.Click += new System.EventHandler(this.btn_addDose_Click);
            // 
            // lbl_lastDoseTitle
            // 
            this.lbl_lastDoseTitle.AutoSize = true;
            this.lbl_lastDoseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_lastDoseTitle.Location = new System.Drawing.Point(2, 167);
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
            this.lbl_bsTitle.Location = new System.Drawing.Point(19, 50);
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
            this.lbl_units.Location = new System.Drawing.Point(113, 254);
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
            this.lbl_mgDL.Location = new System.Drawing.Point(103, 137);
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
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(171, 79);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.MarkerSize = 10;
            series13.Name = "Blood Sugar";
            series13.Points.Add(dataPoint61);
            series13.Points.Add(dataPoint62);
            series13.Points.Add(dataPoint63);
            series13.Points.Add(dataPoint64);
            series13.Points.Add(dataPoint65);
            series13.Points.Add(dataPoint66);
            series13.Points.Add(dataPoint67);
            series13.Points.Add(dataPoint68);
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Legend = "Legend1";
            series14.MarkerSize = 10;
            series14.Name = "Insulin Injection";
            series14.Points.Add(dataPoint69);
            series14.Points.Add(dataPoint70);
            this.chart3.Series.Add(series13);
            this.chart3.Series.Add(series14);
            this.chart3.Size = new System.Drawing.Size(460, 244);
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
            this.lbl_bs.Location = new System.Drawing.Point(23, 79);
            this.lbl_bs.Name = "lbl_bs";
            this.lbl_bs.Size = new System.Drawing.Size(143, 88);
            this.lbl_bs.TabIndex = 51;
            this.lbl_bs.Text = "100";
            this.lbl_bs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_bs.Click += new System.EventHandler(this.lbl_bs_Click);
            // 
            // lbl_lastDose
            // 
            this.lbl_lastDose.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lastDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lastDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDose.Location = new System.Drawing.Point(23, 196);
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
            this.label7.Location = new System.Drawing.Point(60, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 23;
            // 
            // lbl_reservoirUnits
            // 
            this.lbl_reservoirUnits.AutoSize = true;
            this.lbl_reservoirUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservoirUnits.Location = new System.Drawing.Point(83, 315);
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
            this.tabControl.ItemSize = new System.Drawing.Size(49, 18);
            this.tabControl.Location = new System.Drawing.Point(-3, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1283, 400);
            this.tabControl.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(56, 22);
            this.progressBar1.TabIndex = 53;
            this.progressBar1.Value = 100;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 428);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.grpBx_SystemStatus.ResumeLayout(false);
            this.grpBx_SystemStatus.PerformLayout();
            this.grpBx_system.ResumeLayout(false);
            this.grpBx_system.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grpBx_personalInfo;
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
        private System.Windows.Forms.Button btn_saveSettings;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

