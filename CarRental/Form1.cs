using System.Windows.Forms;

namespace CarRental
    //Mukhammadjon Rajabov ICA\\ 
{
    public partial class Form1 : Form
    {
        private string carType;
        const string SEDAN = "Sedan";
        const string MINIVAN = "Minivan";
        const string SUV = "SUV";

        private double sedDayRate;
        private double minDayRate;
        private double sUVDayRate;
        // declared the form2 object
        private Form2 settingForm;


        private string CarRentTrancsactionLog = "CarRentTransLog.txt";
        public string CarRentConfig = "CarRentConfig.txt";

        public double SedDayRate
        {
            get { return sedDayRate; }
            set { sedDayRate = value; }
        }

        public double MinDayRate
        {
            get { return minDayRate; }
            set { minDayRate = value; }
        }

        public double SUVDayRate
        {
            get { return sUVDayRate; }
            set { sUVDayRate = value; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double totalPr;
            int days;
            string CarRentCustomerName;
            bool DaysValid;
            double dailyRate = 0;
            StreamWriter sw;

            // Input
            // days = double.Parse(txtCarRentedDays.Text);
            DaysValid = int.TryParse(txtCarRentedDays.Text, out days);
            CarRentCustomerName = txtCustomerName.Text;
            if (DaysValid)
            {

                switch (carType)
                {
                    case SEDAN:
                        dailyRate = SedDayRate;
                        break;
                    case MINIVAN:
                        dailyRate = MinDayRate;
                        break;
                    case SUV:
                        dailyRate = SUVDayRate;
                        break;
                    default:
                        lstOut.Items.Add("This should never happen");
                        break;
                }


                // Processing
                totalPr = days * (dailyRate);

                // Output
                lstOut.Items.Add(" Customer Name is " + CarRentCustomerName);
                lstOut.Items.Add(" Car Type is " + carType);
                lstOut.Items.Add(" Daily Rate is " + dailyRate.ToString("C2"));
                lstOut.Items.Add(" Day(s) Rented " + days.ToString("N0"));
                lstOut.Items.Add(" Total Price is " + totalPr.ToString("C2"));
                sw = File.AppendText(CarRentTrancsactionLog);
                sw.WriteLine("************* Beginning of Transaction " +
                    DateTime.Now.ToString("G") + "*************");
                sw.WriteLine(" Customer Name is " + CarRentCustomerName);
                sw.WriteLine(" Car Type is " + carType);
                sw.WriteLine(" Daily Rate is " + dailyRate.ToString("C2"));
                sw.WriteLine(" Day(s) Rented " + days.ToString("N0"));
                sw.WriteLine(" Total Price is " + totalPr.ToString("C2"));
                sw.Close();
                // This change the focus to the clear buttom
                btnClear.Focus();
            }
            else
            {
                lstOut.Items.Add("Please enter a positive whole number for day(s)");
            }
        }
        /*
        // THIS IS SAMPLE CODE DO NOT PUT THIS PERMANENTLY IN YOUR CODE
        // TRY IT OUT AND THEN COMMENT IT OUT
        //
        lstOut.Items.Add(DateTime.Now.ToString("D"));
        lstOut.Items.Add(DateTime.Now.ToString("d"));
        lstOut.Items.Add(DateTime.Now.ToString("T"));
        lstOut.Items.Add(DateTime.Now.ToString("t"));
        lstOut.Items.Add(DateTime.Now.ToString("G"));
        */

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCarRentedDays.Clear();
            lstOut.Items.Clear();
            rdSedan.Focus();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want to Quit?", "Exiting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                // this will close the form and end the program..
                // Note closing a form doesn't always end the program
                this.Close();
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Azure;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //here we create object
            settingForm = new Form2(this);
            rdSedan.Checked = true;
            rdSedan.Focus();

            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {
                    reader = File.OpenText(CarRentConfig);
                    fileBad = false;
                    double tempValue;
                    //Skipping validity checks so as not to confuse the input

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    SedDayRate = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    MinDayRate = tempValue;

                    valValid = double.TryParse(reader.ReadLine(), out tempValue);
                    SUVDayRate = tempValue;

                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuration file was not found. Please select a different file \n Error message was:" +
                        ex.Message
                        );
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();
                    CarRentConfig = openFileDialog1.FileName;


                }
            } while (fileBad);


        }

        private void rdoSedan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSedan.Checked)
            {
                carType = SEDAN;
            }
        }

        private void rdoMinivan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMinivan.Checked)
            {
                carType = MINIVAN;
            }
        }

        private void rdoSUV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSUV.Checked)
            {
                carType = SUV;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setValuesOnSecondForm();
            settingForm.ShowDialog();
            
        }

        public void setValuesOnSecondForm()
        {
            settingForm.txtSedanFee.Text = SedDayRate.ToString();
            settingForm.txtMinivanFee.Text = MinDayRate.ToString();
            settingForm.txtSUVFee.Text = SUVDayRate.ToString();
        }

        private void btnDisplayLogs_Click(object sender, EventArgs e)
        {
            const int MAX_LOG_SIZE = 2000;
            string[] CarRentLog = new string[MAX_LOG_SIZE];
            int numLogLines = 0;
            StreamReader sr;
            sr = File.OpenText(CarRentTrancsactionLog);
            while (!sr.EndOfStream)
            {
                CarRentLog[numLogLines] = sr.ReadLine();
                numLogLines++;
            }
            sr.Close();
            int begTrans = -2;
            int endTrans = 3;

            for (int i = 0; i < numLogLines; i++)
            {
                if (CarRentLog[i].Contains("Car Type is " + carType))
                {
                    for (int j = i + begTrans; j <= i + endTrans; j++)
                    {
                        if (j >= 0 && j < numLogLines)
                        {
                            lstOut.Items.Add(CarRentLog[j]);
                        }
                    }
                }
            }
        }


    }

}
