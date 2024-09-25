namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            double dailyRate = 110;
            double days, totalPrice, totalDR;
            string CarRentCustomerName;


            // Input
            days = double.Parse(txtCarRentedDays.Text); 
            CarRentCustomerName = txtCustomerName.Text;


            // Processing
            totalDR = days * dailyRate; 
            totalPrice = days + totalDR;

            // Output
            lstOut.Items.Add(" Customer Name is " + CarRentCustomerName);
            lstOut.Items.Add(" Daily Rate is " + dailyRate.ToString("C2"));
            lstOut.Items.Add(" Days Rented " + days);
            lstOut.Items.Add(" Total Price is " + totalPrice.ToString("C2"));


            // This change the focus to the clear buttom
            btnClear.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarRentalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            txtCustomerName.BackColor = Color.Bisque;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }
    }
}
