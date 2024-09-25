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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCustomerName = new TextBox();
            txtCarRentedDays = new TextBox();
            lstOut = new ListBox();
            btnCalcPrice = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(386, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "Car Rental";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 72);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(91, 122);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Car Rented Days";
            label3.Click += label3_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(231, 72);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(246, 23);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // txtCarRentedDays
            // 
            txtCarRentedDays.Location = new Point(231, 122);
            txtCarRentedDays.Name = "txtCarRentedDays";
            txtCarRentedDays.Size = new Size(246, 23);
            txtCarRentedDays.TabIndex = 4;
            txtCarRentedDays.TextChanged += txtCarRentalPrice_TextChanged;
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
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
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
            ClientSize = new Size(901, 477);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcPrice);
            Controls.Add(lstOut);
            Controls.Add(txtCarRentedDays);
            Controls.Add(txtCustomerName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mukhammadjon Rajabov";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerName;
        private TextBox txtCarRentedDays;
        private ListBox lstOut;
        private Button btnCalcPrice;
        private Button btnClear;
        private Button btnQuit;
    }
}
