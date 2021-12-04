using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_administer_Click(object sender, EventArgs e)
        {
            if(float.Parse(domainUD_units.Text) > 3)
            {
                errorInslulinInjection('+');
            } else
            {
                form1.addBloodSugarPoint(0, 0);
                form1.updateInsulinDose(domainUD_units.Text);
                this.Close();
            }   
        }

        private void domainUD_units_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorInslulinInjection(char error)
        {
            if(error == '+')
            {
                errorLabel.Text = "Dose Too High";
                errorLabel.Visible = true;
            }
        }
    }
}
