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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SETTINGS TAB:
            // set dropdownlist vals to a default
            comboBx_general.SelectedIndex = 0;
            comboBx_userMode.SelectedIndex = 0;
        }

        private void comboBx_general_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBx_general.SelectedIndex == 1)
            {
                //if it changes to on:
                //enable manual vs/auto selection
                comboBx_userMode.Enabled = true;
                if (comboBx_userMode.SelectedIndex == 0)
                {
                    btn_addDose.Enabled = true;
                }
                else if (comboBx_userMode.SelectedIndex == 1)
                {
                    btn_addDose.Enabled = false;
                }
                //enable system status groupBox
                grpBx_SystemStatus.Enabled = true;
            }
            else if (comboBx_general.SelectedIndex == 0)
            {
                //if it changes to off:
                //disable manual vs/auto selection
                comboBx_userMode.SelectedIndex = 0; //return to default MANUAL
                comboBx_userMode.Enabled = false;  //disable the thing
                btn_addDose.Enabled = false;
                //disable system status groupBox, set all vals to initial
                grpBx_SystemStatus.Enabled = false;  //disable groupbox
                
            }
        }

        private void comboBx_userMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBx_userMode.SelectedIndex == 0) //MANUAL
            {
                btn_addDose.Enabled = true;
            }
            else if (comboBx_userMode.SelectedIndex == 1)  //AUTO
            {
                btn_addDose.Enabled = false;
            }
        }

        private void lbl_bs_Click(object sender, EventArgs e)
        {
            int bloodSugarNumber;
            bloodSugarNumber = int.Parse(lbl_bs.Text);
            if (bloodSugarNumber > 50)
            {
                //bad
            }
            else if (bloodSugarNumber < 50 && bloodSugarNumber > 80)
            {
                //warning
            } else
            {
                //nominal
            }
        }

        private void lbl_reservoir_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mgDL_Click(object sender, EventArgs e)
        {

        }

        private void btn_addDose_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_lastDose_Click(object sender, EventArgs e)
        {

        }

        private void lbl_lastDoseTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_units_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //Battery progress code
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void addBloodSugarPoint(int hour, int bloodSugar)
        {
            chart3.Series["Blood Sugar"].Points.AddXY(hour, bloodSugar);
        }

        private void addInjectionPoint(int hour, int bloodSugar)
        {
            chart3.Series["Insulin Injection"].Points.AddXY(hour, bloodSugar);
        }
    }
}
