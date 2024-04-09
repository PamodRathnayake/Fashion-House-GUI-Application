namespace guproject1
{
    partial class FrmLoggedInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoggedInterface));
            this.BtnGentlemenWear = new System.Windows.Forms.Button();
            this.BtnLadiesWear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGentlemenWear
            // 
            this.BtnGentlemenWear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnGentlemenWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGentlemenWear.Location = new System.Drawing.Point(863, 142);
            this.BtnGentlemenWear.Name = "BtnGentlemenWear";
            this.BtnGentlemenWear.Size = new System.Drawing.Size(290, 57);
            this.BtnGentlemenWear.TabIndex = 1;
            this.BtnGentlemenWear.Text = "Click here for male costumes";
            this.BtnGentlemenWear.UseVisualStyleBackColor = false;
            this.BtnGentlemenWear.Click += new System.EventHandler(this.BtnGentlemenWear_Click);
            // 
            // BtnLadiesWear
            // 
            this.BtnLadiesWear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnLadiesWear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLadiesWear.Location = new System.Drawing.Point(863, 55);
            this.BtnLadiesWear.Name = "BtnLadiesWear";
            this.BtnLadiesWear.Size = new System.Drawing.Size(290, 51);
            this.BtnLadiesWear.TabIndex = 0;
            this.BtnLadiesWear.Text = "Click here for ladies costumes";
            this.BtnLadiesWear.UseVisualStyleBackColor = false;
            this.BtnLadiesWear.Click += new System.EventHandler(this.BtnLadiesWear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "FashionHouse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmLoggedInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 752);
            this.Controls.Add(this.BtnLadiesWear);
            this.Controls.Add(this.BtnGentlemenWear);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoggedInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoggedInterface";
            this.Load += new System.EventHandler(this.FrmLoggedInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGentlemenWear;
        private System.Windows.Forms.Button BtnLadiesWear;
    }
}