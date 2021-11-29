
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer_day = new System.Windows.Forms.Timer(this.components);
            this.timer_systemTest = new System.Windows.Forms.Timer(this.components);
            this.timer_bloodSugarTest = new System.Windows.Forms.Timer(this.components);
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_reservoirUnits = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage3.SuspendLayout();
            this.grpBx_SystemStatus.SuspendLayout();
            this.grpBx_system.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
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
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpBx_personalInfo);
            this.tabPage3.Controls.Add(this.grpBx_SystemStatus);
            this.tabPage3.Controls.Add(this.grpBx_system);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1703, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Information";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpBx_personalInfo
            // 
            this.grpBx_personalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBx_personalInfo.Location = new System.Drawing.Point(512, 249);
            this.grpBx_personalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_personalInfo.Name = "grpBx_personalInfo";
            this.grpBx_personalInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_personalInfo.Size = new System.Drawing.Size(453, 190);
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
            this.grpBx_SystemStatus.Location = new System.Drawing.Point(509, 17);
            this.grpBx_SystemStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_SystemStatus.Name = "grpBx_SystemStatus";
            this.grpBx_SystemStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_SystemStatus.Size = new System.Drawing.Size(459, 213);
            this.grpBx_SystemStatus.TabIndex = 5;
            this.grpBx_SystemStatus.TabStop = false;
            this.grpBx_SystemStatus.Text = "System Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Low. Replace soon.";
            // 
            // lbl_battery
            // 
            this.lbl_battery.AutoSize = true;
            this.lbl_battery.Location = new System.Drawing.Point(21, 39);
            this.lbl_battery.Name = "lbl_battery";
            this.lbl_battery.Size = new System.Drawing.Size(145, 25);
            this.lbl_battery.TabIndex = 10;
            this.lbl_battery.Text = "Battery Status: ";
            // 
            // lbl_sensorStatus
            // 
            this.lbl_sensorStatus.AutoSize = true;
            this.lbl_sensorStatus.Location = new System.Drawing.Point(223, 162);
            this.lbl_sensorStatus.Name = "lbl_sensorStatus";
            this.lbl_sensorStatus.Size = new System.Drawing.Size(130, 25);
            this.lbl_sensorStatus.TabIndex = 8;
            this.lbl_sensorStatus.Text = "Not functional";
            // 
            // lbl_pumpStatus
            // 
            this.lbl_pumpStatus.AutoSize = true;
            this.lbl_pumpStatus.Location = new System.Drawing.Point(223, 121);
            this.lbl_pumpStatus.Name = "lbl_pumpStatus";
            this.lbl_pumpStatus.Size = new System.Drawing.Size(56, 25);
            this.lbl_pumpStatus.TabIndex = 7;
            this.lbl_pumpStatus.Text = "good";
            // 
            // lbl_needleStatus
            // 
            this.lbl_needleStatus.AutoSize = true;
            this.lbl_needleStatus.Location = new System.Drawing.Point(223, 80);
            this.lbl_needleStatus.Name = "lbl_needleStatus";
            this.lbl_needleStatus.Size = new System.Drawing.Size(56, 25);
            this.lbl_needleStatus.TabIndex = 6;
            this.lbl_needleStatus.Text = "good";
            // 
            // lbl_sensor
            // 
            this.lbl_sensor.AutoSize = true;
            this.lbl_sensor.Location = new System.Drawing.Point(21, 162);
            this.lbl_sensor.Name = "lbl_sensor";
            this.lbl_sensor.Size = new System.Drawing.Size(147, 25);
            this.lbl_sensor.TabIndex = 4;
            this.lbl_sensor.Text = "Sensor Status: ";
            // 
            // lbl_pump
            // 
            this.lbl_pump.AutoSize = true;
            this.lbl_pump.Location = new System.Drawing.Point(21, 121);
            this.lbl_pump.Name = "lbl_pump";
            this.lbl_pump.Size = new System.Drawing.Size(196, 25);
            this.lbl_pump.TabIndex = 3;
            this.lbl_pump.Text = "Insulin Pump Status: ";
            // 
            // lbl_needle
            // 
            this.lbl_needle.AutoSize = true;
            this.lbl_needle.Location = new System.Drawing.Point(21, 80);
            this.lbl_needle.Name = "lbl_needle";
            this.lbl_needle.Size = new System.Drawing.Size(146, 25);
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
            this.grpBx_system.Location = new System.Drawing.Point(27, 17);
            this.grpBx_system.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_system.Name = "grpBx_system";
            this.grpBx_system.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBx_system.Size = new System.Drawing.Size(451, 302);
            this.grpBx_system.TabIndex = 0;
            this.grpBx_system.TabStop = false;
            this.grpBx_system.Text = "System Settings";
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(131, 245);
            this.btn_saveSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(197, 34);
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
            this.comboBx_general.Location = new System.Drawing.Point(157, 37);
            this.comboBx_general.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBx_general.Name = "comboBx_general";
            this.comboBx_general.Size = new System.Drawing.Size(131, 33);
            this.comboBx_general.TabIndex = 3;
            this.comboBx_general.SelectedIndexChanged += new System.EventHandler(this.comboBx_general_SelectedIndexChanged);
            // 
            // lbl_general
            // 
            this.lbl_general.AutoSize = true;
            this.lbl_general.Location = new System.Drawing.Point(21, 39);
            this.lbl_general.Name = "lbl_general";
            this.lbl_general.Size = new System.Drawing.Size(87, 25);
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
            this.comboBx_userMode.Location = new System.Drawing.Point(157, 80);
            this.comboBx_userMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBx_userMode.Name = "comboBx_userMode";
            this.comboBx_userMode.Size = new System.Drawing.Size(131, 33);
            this.comboBx_userMode.TabIndex = 1;
            this.comboBx_userMode.SelectedIndexChanged += new System.EventHandler(this.comboBx_userMode_SelectedIndexChanged);
            // 
            // lbl_UserMode
            // 
            this.lbl_UserMode.AutoSize = true;
            this.lbl_UserMode.Location = new System.Drawing.Point(21, 82);
            this.lbl_UserMode.Name = "lbl_UserMode";
            this.lbl_UserMode.Size = new System.Drawing.Size(114, 25);
            this.lbl_UserMode.TabIndex = 0;
            this.lbl_UserMode.Text = "User Mode:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1703, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-4, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1711, 492);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1703, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(29, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 23;
            // 
            // lbl_reservoirUnits
            // 
            this.lbl_reservoirUnits.AutoSize = true;
            this.lbl_reservoirUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservoirUnits.Location = new System.Drawing.Point(60, 359);
            this.lbl_reservoirUnits.Name = "lbl_reservoirUnits";
            this.lbl_reservoirUnits.Size = new System.Drawing.Size(0, 25);
            this.lbl_reservoirUnits.TabIndex = 7;
            this.lbl_reservoirUnits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(373, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is a placeholder for where the graph could go (?)";
            // 
            // lbl_reservoir
            // 
            this.lbl_reservoir.AutoSize = true;
            this.lbl_reservoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_reservoir.Location = new System.Drawing.Point(37, 407);
            this.lbl_reservoir.Name = "lbl_reservoir";
            this.lbl_reservoir.Size = new System.Drawing.Size(186, 25);
            this.lbl_reservoir.TabIndex = 50;
            this.lbl_reservoir.Text = "16.0 units remaining";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label11.Location = new System.Drawing.Point(354, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(548, 36);
            this.label11.TabIndex = 49;
            this.label11.Text = "Bood Sugar and Insulin Doses over time";
            // 
            // btn_addDose
            // 
            this.btn_addDose.Enabled = false;
            this.btn_addDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addDose.Location = new System.Drawing.Point(63, 361);
            this.btn_addDose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addDose.Name = "btn_addDose";
            this.btn_addDose.Size = new System.Drawing.Size(133, 38);
            this.btn_addDose.TabIndex = 48;
            this.btn_addDose.Text = "Add dose";
            this.btn_addDose.UseVisualStyleBackColor = true;
            // 
            // lbl_lastDoseTitle
            // 
            this.lbl_lastDoseTitle.AutoSize = true;
            this.lbl_lastDoseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_lastDoseTitle.Location = new System.Drawing.Point(33, 209);
            this.lbl_lastDoseTitle.Name = "lbl_lastDoseTitle";
            this.lbl_lastDoseTitle.Size = new System.Drawing.Size(244, 36);
            this.lbl_lastDoseTitle.TabIndex = 47;
            this.lbl_lastDoseTitle.Text = "Last Insulin Dose";
            // 
            // lbl_bsTitle
            // 
            this.lbl_bsTitle.AutoSize = true;
            this.lbl_bsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_bsTitle.Location = new System.Drawing.Point(33, 33);
            this.lbl_bsTitle.Name = "lbl_bsTitle";
            this.lbl_bsTitle.Size = new System.Drawing.Size(181, 36);
            this.lbl_bsTitle.TabIndex = 46;
            this.lbl_bsTitle.Text = "Blood Sugar";
            // 
            // lbl_units
            // 
            this.lbl_units.AutoSize = true;
            this.lbl_units.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_units.Location = new System.Drawing.Point(99, 316);
            this.lbl_units.Name = "lbl_units";
            this.lbl_units.Size = new System.Drawing.Size(53, 25);
            this.lbl_units.TabIndex = 45;
            this.lbl_units.Text = "units";
            this.lbl_units.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_mgDL
            // 
            this.lbl_mgDL.AutoSize = true;
            this.lbl_mgDL.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_mgDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mgDL.Location = new System.Drawing.Point(95, 143);
            this.lbl_mgDL.Name = "lbl_mgDL";
            this.lbl_mgDL.Size = new System.Drawing.Size(67, 25);
            this.lbl_mgDL.TabIndex = 44;
            this.lbl_mgDL.Text = "mg/dL";
            this.lbl_mgDL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(342, 71);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(573, 300);
            this.chart3.TabIndex = 43;
            this.chart3.Text = "chart3";
            // 
            // lbl_bs
            // 
            this.lbl_bs.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_bs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_bs.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bs.Location = new System.Drawing.Point(33, 71);
            this.lbl_bs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bs.Name = "lbl_bs";
            this.lbl_bs.Size = new System.Drawing.Size(190, 108);
            this.lbl_bs.TabIndex = 51;
            this.lbl_bs.Text = "100";
            this.lbl_bs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_lastDose
            // 
            this.lbl_lastDose.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lastDose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_lastDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastDose.Location = new System.Drawing.Point(33, 245);
            this.lbl_lastDose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lastDose.Name = "lbl_lastDose";
            this.lbl_lastDose.Size = new System.Drawing.Size(190, 108);
            this.lbl_lastDose.TabIndex = 52;
            this.lbl_lastDose.Text = "1.5";
            this.lbl_lastDose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 507);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.grpBx_SystemStatus.ResumeLayout(false);
            this.grpBx_SystemStatus.PerformLayout();
            this.grpBx_system.ResumeLayout(false);
            this.grpBx_system.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_day;
        private System.Windows.Forms.Timer timer_systemTest;
        private System.Windows.Forms.Timer timer_bloodSugarTest;
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_reservoirUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
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
    }
}

