namespace Uppgift3._3
{
    partial class Form1
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
            this.tbxA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.tbxC = new System.Windows.Forms.TextBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.lblMedel = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(356, 45);
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(100, 26);
            this.tbxA.TabIndex = 0;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(266, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(45, 20);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Tal A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(266, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(45, 20);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Tal B";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(356, 97);
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(100, 26);
            this.tbxB.TabIndex = 2;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(266, 153);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(45, 20);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Tal C";
            // 
            // tbxC
            // 
            this.tbxC.Location = new System.Drawing.Point(356, 150);
            this.tbxC.Name = "tbxC";
            this.tbxC.Size = new System.Drawing.Size(100, 26);
            this.tbxC.TabIndex = 6;
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(352, 215);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(68, 20);
            this.lblSumma.TabIndex = 7;
            this.lblSumma.Text = "Summa:";
            // 
            // lblMedel
            // 
            this.lblMedel.AutoSize = true;
            this.lblMedel.Location = new System.Drawing.Point(352, 252);
            this.lblMedel.Name = "lblMedel";
            this.lblMedel.Size = new System.Drawing.Size(99, 20);
            this.lblMedel.TabIndex = 8;
            this.lblMedel.Text = "Medelvärde: ";
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(317, 309);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(121, 46);
            this.btnKör.TabIndex = 9;
            this.btnKör.Text = "Kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblMedel);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.tbxC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.tbxA);
            this.Name = "Form1";
            this.Text = "Övning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox tbxC;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Label lblMedel;
        private System.Windows.Forms.Button btnKör;
    }
}

