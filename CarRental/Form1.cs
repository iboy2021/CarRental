namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double dailyRate = 110;
            double days, totalPr;
            string CarRentCustomerName;


            // Input
            days = double.Parse(txtCarRentedDays.Text);
            CarRentCustomerName = txtCustomerName.Text;


            // Processing
            totalPr = days * dailyRate;

            // Output
            lstOut.Items.Add(" Customer Name is " + CarRentCustomerName);
            lstOut.Items.Add(" Daily Rate is " + dailyRate.ToString("C2"));
            lstOut.Items.Add(" Day(s) Rented " + days);
            lstOut.Items.Add(" Total Price is " + totalPr.ToString("C2"));


            // This change the focus to the clear buttom
            btnClear.Focus();
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCarRentedDays.Clear();
            lstOut.Items.Clear();
            txtCustomerName.Focus();
        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Azure;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

    }
}
