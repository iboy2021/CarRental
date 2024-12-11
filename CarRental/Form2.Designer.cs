namespace CarRental
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btmSetReturn = new Button();
            txtSUVFee = new TextBox();
            txtMinivanFee = new TextBox();
            txtSedanFee = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(127, 25);
            label1.Name = "label1";
            label1.Size = new Size(190, 33);
            label1.TabIndex = 0;
            label1.Text = "Configuration Settings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            //label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 88);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Sedan Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Minivan Fee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 235);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "SUV Fee";
            // 
            // btmSetReturn
            // 
            btmSetReturn.Location = new Point(180, 302);
            btmSetReturn.Name = "btmSetReturn";
            btmSetReturn.Size = new Size(75, 23);
            btmSetReturn.TabIndex = 5;
            btmSetReturn.Text = "&Set & Return";
            btmSetReturn.UseVisualStyleBackColor = true;
            btmSetReturn.Click += btmSetReturn_Click;
            // 
            // txtSUVFee
            // 
            txtSUVFee.Location = new Point(127, 227);
            txtSUVFee.Name = "txtSUVFee";
            txtSUVFee.Size = new Size(100, 23);
            txtSUVFee.TabIndex = 6;
            // 
            // txtMinivanFee
            // 
            txtMinivanFee.Location = new Point(127, 153);
            txtMinivanFee.Name = "txtMinivanFee";
            txtMinivanFee.Size = new Size(100, 23);
            txtMinivanFee.TabIndex = 7;
            // 
            // txtSedanFee
            // 
            txtSedanFee.Location = new Point(127, 88);
            txtSedanFee.Name = "txtSedanFee";
            txtSedanFee.Size = new Size(100, 23);
            txtSedanFee.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 425);
            Controls.Add(txtSedanFee);
            Controls.Add(txtMinivanFee);
            Controls.Add(txtSUVFee);
            Controls.Add(btmSetReturn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Car Rent Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btmSetReturn;
        public TextBox txtSUVFee;
        public TextBox txtMinivanFee;
        public TextBox txtSedanFee;
    }
}