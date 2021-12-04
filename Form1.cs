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
        int h, m, s, d; //timer


        float reservoir = 300;

        private void Form1_Load(object sender, EventArgs e)
        {
            //SETTINGS TAB:
            // set dropdownlist vals to a default
            comboBx_general.SelectedIndex = 0;
            comboBx_userMode.SelectedIndex = 0;

            //24 HOUR TIMER:
            h = 0;
            m = 0;
            s = 0;
            d = 0;
            //txtBx_time.Text = String.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", h, m, s, d);
            timer_day.Start();
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
            Form2 f2 = new Form2(this);
            f2.ShowDialog();
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

        public void addBloodSugarPoint(int hour, float bloodSugar)
        {
            chart3.Series["Blood Sugar"].Points.AddXY(hour, bloodSugar);
        }

        public void addInjectionPoint(int hour, float bloodSugar)
        {
            chart3.Series["Insulin Injection"].Points.AddXY(hour, bloodSugar);
        }

        public void updateInsulinDose(String dose)
        {
            lbl_lastDose.Text = dose;
        }
        
        //Quick test stuff
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_bs.Text = "75";
            addBloodSugarPoint(9, 75);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_bs.Text = "45";
            addBloodSugarPoint(10, 45);
            addInjectionPoint(10, 45);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_bs.Text = "85";
            addBloodSugarPoint(11, 85);
        }

        private void timer_day_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            }
            lbl_24HourTimer.Text = String.Format("Clock: {0:D2}:{1:D2}:{2:D2}", h, m, s);

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            int checkedItem = checkedListBox1.SelectedIndex;
            Console.WriteLine(checkedItem);
            testEmitter(checkedItem);
        }

        public void testEmitter(int testName)
        {
            if(testName == 0)
            {
                progressBar1.Value = 15;
                //progressBar1.BackColor = Color.Red; maybe ill fix it, if i FEEL like it
                //write in error pop up
                MessageBox.Show("Error.\n\n" +
                    "<<Device will vibrate and sound an alarm>>", "Warning!");
            }





        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_systemTest_Tick(object sender, EventArgs e)
        {

        }

        private void lbl_bs_TextChanged(object sender, EventArgs e)
        {
            //This logic will need to move, here for testing
            float bloodSugarNumber;
            bloodSugarNumber = float.Parse(lbl_bs.Text);
            if (bloodSugarNumber < 50 || bloodSugarNumber > 110)
            {
                lbl_bs.BackColor = Color.Red;
            }
            else if (bloodSugarNumber > 50 && bloodSugarNumber < 80)
            {
                lbl_bs.BackColor = Color.Orange;
            }
            else
            {
                lbl_bs.BackColor = DefaultBackColor;
            }
        }

        private void lbl_24HourTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
