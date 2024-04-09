namespace guproject1
{
    partial class FrmRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCusUserName = new System.Windows.Forms.TextBox();
            this.TxtCustomerAddress = new System.Windows.Forms.TextBox();
            this.TxtCustomerEmail = new System.Windows.Forms.TextBox();
            this.TxtCustomerContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnRFback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "01. User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "05. Address  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "02. Email Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 36);
            this.label5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCusUserName
            // 
            this.TxtCusUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCusUserName.Location = new System.Drawing.Point(290, 149);
            this.TxtCusUserName.Name = "TxtCusUserName";
            this.TxtCusUserName.Size = new System.Drawing.Size(503, 34);
            this.TxtCusUserName.TabIndex = 8;
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerAddress.Location = new System.Drawing.Point(265, 422);
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(528, 34);
            this.TxtCustomerAddress.TabIndex = 9;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerEmail.Location = new System.Drawing.Point(338, 216);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(455, 34);
            this.TxtCustomerEmail.TabIndex = 10;
            this.TxtCustomerEmail.TextChanged += new System.EventHandler(this.TxtCustomerEmail_TextChanged);
            // 
            // TxtCustomerContactNumber
            // 
            this.TxtCustomerContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerContactNumber.Location = new System.Drawing.Point(361, 352);
            this.TxtCustomerContactNumber.Name = "TxtCustomerContactNumber";
            this.TxtCustomerContactNumber.Size = new System.Drawing.Size(432, 34);
            this.TxtCustomerContactNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(191, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 51);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrstion Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "04. Contact Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "03. Password :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(275, 281);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(518, 34);
            this.TxtPassword.TabIndex = 16;
            // 
            // BtnRFback
            // 
            this.BtnRFback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRFback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRFback.Location = new System.Drawing.Point(691, 578);
            this.BtnRFback.Name = "BtnRFback";
            this.BtnRFback.Size = new System.Drawing.Size(95, 37);
            this.BtnRFback.TabIndex = 17;
            this.BtnRFback.Text = "Back";
            this.BtnRFback.UseVisualStyleBackColor = false;
            this.BtnRFback.Click += new System.EventHandler(this.BtnRFback_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(819, 651);
            this.Controls.Add(this.BtnRFback);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerContactNumber);
            this.Controls.Add(this.TxtCustomerEmail);
            this.Controls.Add(this.TxtCustomerAddress);
            this.Controls.Add(this.TxtCusUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtCusUserName;
        private System.Windows.Forms.TextBox TxtCustomerAddress;
        private System.Windows.Forms.TextBox TxtCustomerEmail;
        private System.Windows.Forms.TextBox TxtCustomerContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnRFback;
    }
}