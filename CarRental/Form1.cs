namespace CarRental
{
    public partial class Form1 : Form
    {
        private string CarType;
        const string SEDAN = "Sedan";
        const string MINIVAN = "Minivan";
        const string SUV = "SUV";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double dailyRate = 110;
            int days;
            double totalPr;
            string CarRentCustomerName;
            bool DaysValid;
             // double CarTypefee = 0;



            // Input
            // days = double.Parse(txtCarRentedDays.Text);
            DaysValid = int.TryParse(txtCarRentedDays.Text, out days);
            CarRentCustomerName = txtCustomerName.Text;
            if (DaysValid)
            {

                switch(CarType)
                {
                    case SEDAN:
                        dailyRate = 110; 
                        break;
                    case MINIVAN:
                        dailyRate = 130;
                        break;
                    case SUV:
                        dailyRate = 160;
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


                // This change the focus to the clear buttom
                btnClear.Focus();
            }
            else
            {
                if (!DaysValid)
                {
                    lstOut.Items.Add("Please enter whole number for day(s)");
                }
            }
        }


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
        }

        private void rdSedan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSedan.Checked)
            {
                CarType = SEDAN;
            }
        }

        private void rdMinivan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMinivan.Checked)
            {
                CarType = MINIVAN;
            }
        }

        private void rdSUV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSUV.Checked)
            {
                CarType = SUV;
            }
        }
    }
}
