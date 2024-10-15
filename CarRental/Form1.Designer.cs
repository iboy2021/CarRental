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
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
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
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(231, 72);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(246, 23);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // txtCarRentedDays
            // 
            txtCarRentedDays.Location = new Point(231, 122);
            txtCarRentedDays.Name = "txtCarRentedDays";
            txtCarRentedDays.Size = new Size(246, 23);
            txtCarRentedDays.TabIndex = 4;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(542, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 85);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Type";
            
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sedan";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(115, 35);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Minivan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(232, 35);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "SUV";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 509);
            Controls.Add(groupBox1);
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
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
