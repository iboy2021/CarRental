using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
    //ICA//
{
    public partial class Form2 : Form
    {
        //This is the constructor
        private Form1 ff;
        public Form2(Form1 form1)
        {
            // need private variable so it can be accessed in other 
            // procedures
            ff = form1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmSetReturn_Click(object sender, EventArgs e)
        {
            //read values from text boxes
            bool SedValid, MinValid, SUVValid;
            double STempValue, MTempValue, UTempValue;

            StreamWriter sw;

            SedValid = double.TryParse(txtSedanFee.Text, out STempValue);
            MinValid = double.TryParse(txtMinivanFee.Text, out MTempValue);
            SUVValid = double.TryParse(txtSUVFee.Text, out UTempValue);
            // check values
            if (SedValid && MinValid && SUVValid)
            {
                // if values good
                // set properties
                ff.SedDayRate = STempValue;
                ff.MinDayRate = MTempValue;
                ff.SUVDayRate = UTempValue;
                // save values in file
                sw = File.CreateText(ff.CarRentConfig);
                sw.WriteLine(ff.SedDayRate);
                sw.WriteLine(ff.MinDayRate);
                sw.WriteLine(ff.SUVDayRate);

                sw.Close();

                // go back to Form 1 
                this.Hide();

            }
            else
            {
                // if values not good
                // replace all text box values with current values

                ff.setValuesOnSecondForm();
                
            }
        }
    }
}
