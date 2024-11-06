using System.Windows.Forms;

namespace CarRental
    //Mukhammadjon Rajabov
{
    public partial class Form1 : Form
    {
        private string CarType;
        const string SEDAN = "Sedan";
        const string MINIVAN = "Minivan";
        const string SUV = "SUV";
        private double dailyRate;
        private double sedDayRate;
        private double minDayRate;
        private double sUVDayRate;


        private string CarRentTrancsactionLog = "CarRentTransLog.txt";
        private string CarRentConfig = "CarRentConfig.txt";
        public double DailyRate {  
        
            get { return dailyRate;  }
            set { dailyRate = value; }
        }

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
            // double CarTypefee = 0;
            StreamWriter sw;



            // Input
            // days = double.Parse(txtCarRentedDays.Text);
            DaysValid = int.TryParse(txtCarRentedDays.Text, out days);
            CarRentCustomerName = txtCustomerName.Text;
            if (DaysValid)
            {

                switch (CarType)
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
                lstOut.Items.Add(" Car Type is " + CarType);
                lstOut.Items.Add(" Daily Rate is " + dailyRate.ToString("C2"));
                lstOut.Items.Add(" Day(s) Rented " + days.ToString("N0"));
                lstOut.Items.Add(" Total Price is " + totalPr.ToString("C2"));
                sw = File.AppendText(CarRentTrancsactionLog);
                sw.WriteLine("************* Beginning of Transaction " +
                    DateTime.Now.ToString("G") + "*************");
                sw.WriteLine(" Customer Name is " + CarRentCustomerName);
                sw.WriteLine(" Car Type is " + CarType);
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
                    dailyRate = tempValue; 
                    
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
                CarType = SEDAN;
            }
        }

        private void rdoMinivan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMinivan.Checked)
            {
                CarType = MINIVAN;
            }
        }

        private void rdoSUV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSUV.Checked)
            {
                CarType = SUV;
            }
        }
    }
}
