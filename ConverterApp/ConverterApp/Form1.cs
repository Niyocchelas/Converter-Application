using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
    //Improved on by Nicholas Aylmore: April 2017
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;
        double[] convertArray = new double[5];
        int cnt = 0;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //The code for calculating the Centermeters to Inches equation
        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {

            const double CM_TO_INCH = 0.3937;

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    //This will display the results if more than 5 are entered and hold in an array in the 'Results' box
                    dbl_Convert = dbl_UofM * CM_TO_INCH;
                    txt_Convert.Text = dbl_Convert.ToString();
                    convertArray[cnt] = dbl_Convert;
                    cnt++;
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                    lbl_Convert.Text = " inches.";
                    //string[] items = Regex.Split(txt_Convert.Text + lbl_Convert.Text, "\r\n");
                }
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        Results.Items.Add(convertArray[i]);
                    }
                }
                
            }
        }

        //The code for calculating the Celcius to Fahrenheit equation
        private void C_to_F_Click(object sender, EventArgs e)
        {
            const double C_TO_F = 1.8;
                     
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    //This will display the results if more than 5 are entered and hold in an array in the 'Results' box
                    dbl_Convert = dbl_UofM * C_TO_F + 32;
                    txt_Convert.Text = dbl_Convert.ToString();
                    convertArray[cnt] = dbl_Convert;
                    cnt++;
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " celcius is converted to ";
                    lbl_Convert.Text = " fahrenheit.";
                }
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        Results.Items.Add(convertArray[i]);
                    }
                }
            }
        }

        //The code for calculating the Centermeters to Feet equation
        private void CM_to_FT_Click(object sender, EventArgs e)
        {
            const double CM_TO_FT = 0.0328084;
                    

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    //This will display the results if more than 5 are entered and hold in an array in the 'Results' box
                    dbl_Convert = dbl_UofM * CM_TO_FT;
                    txt_Convert.Text = dbl_Convert.ToString();
                    convertArray[cnt] = dbl_Convert;
                    cnt++;
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " Centimeters is converted to ";
                    lbl_Convert.Text = " feet.";
                }
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        Results.Items.Add(convertArray[i]);
                    }
                }
            }
        }

        //The code for calculating the Kilometers to Miles equation
        private void KM_to_MI_Click(object sender, EventArgs e)
        {
            const double KM_TO_MI = 0.621371;
                    

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    //This will display the results if more than 5 are entered and hold in an array in the 'Results' box
                    dbl_Convert = dbl_UofM * KM_TO_MI;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometers is converted to ";
                    lbl_Convert.Text = " Miles.";
                }
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        Results.Items.Add(convertArray[i]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //the code for calculating the Meters to Feet equation
        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FT = 3.28084;

          
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    //This will display the results if more than 5 are entered and hold in an array in the 'Results' box
                    dbl_Convert = dbl_UofM * M_TO_FT;
                    txt_Convert.Text = dbl_Convert.ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " meters is converted to ";
                    lbl_Convert.Text = " feet.";                   
                }
                else
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        Results.Items.Add(convertArray[i]);
                    }
                }
            }
        }

    }
}
