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


        //stores up to a maximum value of search results.
        string[] previousSearchArray;

        //handles which position to write too
        int currIndex = 0;

        //variable to manage how big the previous search list can be when initialised
        public int maxIndex = 15;


        public frm_Main()
        {
            InitializeComponent();

            //stops the result box being edited
            txt_Convert.ReadOnly = true;
            
            //init the array.
            previousSearchArray = new string[maxIndex];

        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;


        //manages the exit button, closing application.
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Centimeters to inches conversion button
        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            //holds constant value to convert with
            const double CM_TO_INCH = 0.3937;
           
            // validate user entry and convert to a double

            //checks parse success
            if (! double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                //if failed clear fields and show message box.
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                //otherwise convert and update display.
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = dbl_UofM + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";

                //finally add the result to the recent list
                addToPreviousSearches(lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text);

            }
        }


        //celsius to fahrenheit
        private void btn_cels_to_Fah_Click(object sender, EventArgs e)
        {
            //holds constant value to convert with
            const double CEL_TO_FAH = 32;

            //checks parse success
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                //if failed clear fields and show message box.
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                //otherwise convert and update display.
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM + CEL_TO_FAH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Celsius is converted to ";
                lbl_Convert.Text = " Fahrenheit.";

                //finally add the result to the recent list
                addToPreviousSearches(lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text);

            }
        }

        //Convert Centimetres to Feet
        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            //holds constant value to convert with
            const double CM_TO_FEET = 0.0328084;

            //checks parse success
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                //if failed clear fields and show message box.
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                //otherwise convert and update display.
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * CM_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Centimetres is converted to ";
                lbl_Convert.Text = " Feet.";

                //finally add the result to the recent list
                addToPreviousSearches(lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text);

            }
        }


        //convert Kilometres to Miles
        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            //holds constant value to convert with
            const double KM_TO_MILES = 0.621371;

            //checks parse success
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                //if failed clear fields and show message box.
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                //otherwise convert and update display.
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * KM_TO_MILES;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " Kilometres is converted to ";
                lbl_Convert.Text = " Miles.";

                //finally add the result to the recent list
                addToPreviousSearches(lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text);

            }
        }

        
     
        //convert metres to feet
        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            //holds constant value to convert with
            const double M_TO_FEET = 3.28084;


            //checks parse success
            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                //if failed clear fields and show message box.
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                //otherwise convert and update display.
                dbl_UofM = Math.Abs(dbl_UofM);
                dbl_Convert = dbl_UofM * M_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " metres is converted to ";
                lbl_Convert.Text = " Feet.";

                //finally add the result to the recent list
                addToPreviousSearches(lbl_Display.Text + txt_Convert.Text + lbl_Convert.Text);

            }

        }


        //used to log the conversion incase it is used again.
        private void addToPreviousSearches(string str)
        {
            
            //if string is not contained with list
            if (!checkRecentForString(str))
            {
                //append string with current index value and add to that position within array.
                previousSearchArray[currIndex] = ((currIndex + 1).ToString() + ": " + str);
                //increase postition
                currIndex++;
                //if at the end (max size)
                if (currIndex > (maxIndex - 1))
                {
                    //reset and replace from 0
                    currIndex = 0;
                }
            }

            //clear all list items
            PrevSearchList.Items.Clear();

            //loop through and update display
            foreach (string item in previousSearchArray)
            {
                //if not null
                if (item != null)
                {
                    PrevSearchList.Items.Add(item);
                }


            }

        }







        //checks if keypress is negative symbol and handles.
        private void txt_UnitOfMeasure_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if minus key pressed
            if (e.KeyChar == '-')
            {
                //display warning
                Neg_Label.Visible = true;
                //don't handle keypress.
                e.Handled = true;
            }
        }

        //checks even if text is changed at all for symbol
        private void txt_UnitOfMeasure_TextChanged(object sender, EventArgs e)
        {

            if (!txt_UnitOfMeasure.Text.Contains("-"))
            {
                Neg_Label.Visible = false;
            }

        }


        private bool checkRecentForString(string str)
        {
            //local found bool
            bool found = false;

            //if not null
            if(previousSearchArray[0] != null)
            {
                //loop through to find all strings
                foreach (string recentString in previousSearchArray)
                {
                    //if not empty
                    if (recentString != null)
                    {
                        //split into two parts using the :
                        string[] splitString = recentString.Split(':');

                        //if the split string isnt null (should never be)
                        if (splitString[1] != null)
                        {
                            //check the string matches the passed string
                            if (splitString[1] == " " + str)
                            {
                                //return found
                                found = true;
                                return found;
                            }
                        }
                    }
                }
            }

            //default nothing found, return false
            return found;




        }
    }
}
