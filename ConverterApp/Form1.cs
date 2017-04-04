using System;
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
{
    public partial class frm_Main : Form
    {


        


        public frm_Main()
        {
            InitializeComponent();

            txt_Convert.ReadOnly = true;
            
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
           
            // validate user entry and convert to a double

            if (! double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
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
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = dbl_UofM + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
                
            }
        }



        private void btn_cels_to_Fah_Click(object sender, EventArgs e)
        {
            const double CEL_TO_FAH = 32;

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
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM + CEL_TO_FAH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Celsius is converted to ";
                lbl_Convert.Text = " Fahrenheit.";
               
            }
        }

        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            const double CM_TO_FEET = 0.0328084;

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
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * CM_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Centimetres is converted to ";
                lbl_Convert.Text = " Feet.";
               
            }
        }

        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            const double KM_TO_MILES = 0.621371;

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
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * KM_TO_MILES;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometres is converted to ";
                lbl_Convert.Text = " Miles.";
                
            }
        }

        
        private void txt_UnitOfMeasure_TextChanged(object sender, EventArgs e)
        {

            if (!txt_UnitOfMeasure.Text.Contains("-"))
            {
                Neg_Label.Visible = false;
            }

    }


        private void txt_UnitOfMeasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if minus key pressed
            if(e.KeyChar == '-')
            {
                //display warning
                Neg_Label.Visible = true;
                //don't handle keypress.
                e.Handled = true;
                
            }


        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FEET = 3.28084;

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
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * M_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " metres is converted to ";
                lbl_Convert.Text = " Feet.";
                
            }

        }






    }
}
