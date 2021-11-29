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
    }
}
