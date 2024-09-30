namespace CarRental
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCarRental = new Label();
            labelCutomerName = new Label();
            labelCarRentedDays = new Label();
            txtCustomerName = new TextBox();
            txtCarRentedDays = new TextBox();
            lstOut = new ListBox();
            btnCalcPrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // labelCarRental
            // 
            labelCarRental.AutoSize = true;
            labelCarRental.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarRental.ForeColor = Color.FromArgb(64, 64, 64);
            labelCarRental.Location = new Point(386, 20);
            labelCarRental.Name = "labelCarRental";
            labelCarRental.Size = new Size(131, 32);
            labelCarRental.TabIndex = 0;
            labelCarRental.Text = "Car Rental";
            //labelCarRental.Click += labelCarRental_Click;
            // 
            // labelCutomerName
            // 
            labelCutomerName.AutoSize = true;
            labelCutomerName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCutomerName.Location = new Point(91, 72);
            labelCutomerName.Name = "labelCutomerName";
            labelCutomerName.Size = new Size(116, 20);
            labelCutomerName.TabIndex = 1;
            labelCutomerName.Text = "Customer Name";
            //labelCutomerName.Click += labelCutomerName_Click;
            // 
            // labelCarRentedDays
            // 
            labelCarRentedDays.AutoSize = true;
            labelCarRentedDays.Font = new Font("Segoe UI", 11.25F);
            labelCarRentedDays.Location = new Point(91, 122);
            labelCarRentedDays.Name = "labelCarRentedDays";
            labelCarRentedDays.Size = new Size(128, 20);
            labelCarRentedDays.TabIndex = 3;
            labelCarRentedDays.Text = "Car Rented Day(s)";
            //labelCarRentedDays.Click += labelCarRentedDays_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(231, 72);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(246, 23);
            txtCustomerName.TabIndex = 2;
            //txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // txtCarRentedDays
            // 
            txtCarRentedDays.Location = new Point(231, 122);
            txtCarRentedDays.Name = "txtCarRentedDays";
            txtCarRentedDays.Size = new Size(246, 23);
            txtCarRentedDays.TabIndex = 4;
            //txtCarRentedDays.TextChanged += txtCarRentedDays_TextChanged;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(91, 172);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(713, 169);
            lstOut.TabIndex = 5;
            lstOut.TabStop = false;
            //lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Location = new Point(100, 364);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(85, 73);
            btnCalcPrice.TabIndex = 6;
            btnCalcPrice.Text = "Calculate Total Rental &Price";
            btnCalcPrice.UseVisualStyleBackColor = true;
            btnCalcPrice.Click += btnCalcPrice_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(386, 364);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 73);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(691, 364);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(79, 73);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 537);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcPrice);
            Controls.Add(lstOut);
            Controls.Add(txtCarRentedDays);
            Controls.Add(txtCustomerName);
            Controls.Add(labelCarRentedDays);
            Controls.Add(labelCutomerName);
            Controls.Add(labelCarRental);
            Name = "Form1";
            Text = "Mukhammadjon Rajabov";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarRental;
        private Label labelCutomerName;
        private Label labelCarRentedDays;
        private TextBox txtCustomerName;
        private TextBox txtCarRentedDays;
        private ListBox lstOut;
        private Button btnCalcPrice;
        private Button btnClear;
        private Button btnQuit;
    }
}
