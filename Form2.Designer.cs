
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.domainUD_units = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_administer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(72, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manual Insulin Dose";
            // 
            // domainUD_units
            // 
            this.domainUD_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.domainUD_units.Items.Add("0.5");
            this.domainUD_units.Items.Add("1.0");
            this.domainUD_units.Items.Add("1.5");
            this.domainUD_units.Items.Add("2.0");
            this.domainUD_units.Items.Add("2.5");
            this.domainUD_units.Items.Add("3.0");
            this.domainUD_units.Items.Add("3.5");
            this.domainUD_units.Items.Add("4.0");
            this.domainUD_units.Items.Add("4.5");
            this.domainUD_units.Items.Add("5.0");
            this.domainUD_units.Location = new System.Drawing.Point(205, 61);
            this.domainUD_units.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.domainUD_units.Name = "domainUD_units";
            this.domainUD_units.Size = new System.Drawing.Size(123, 26);
            this.domainUD_units.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insulin Dose (in units):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(203, 118);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 37);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_administer
            // 
            this.btn_administer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_administer.Location = new System.Drawing.Point(40, 118);
            this.btn_administer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_administer.Name = "btn_administer";
            this.btn_administer.Size = new System.Drawing.Size(125, 37);
            this.btn_administer.TabIndex = 6;
            this.btn_administer.Text = "Administer";
            this.btn_administer.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 183);
            this.Controls.Add(this.btn_administer);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainUD_units);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUD_units;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_administer;
    }
}