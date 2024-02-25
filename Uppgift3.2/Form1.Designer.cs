namespace Uppgift3._2
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
            this.lblTal1 = new System.Windows.Forms.Label();
            this.lblTal2 = new System.Windows.Forms.Label();
            this.tbxTal1 = new System.Windows.Forms.TextBox();
            this.tbxTal2 = new System.Windows.Forms.TextBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTal1
            // 
            this.lblTal1.AutoSize = true;
            this.lblTal1.Location = new System.Drawing.Point(267, 105);
            this.lblTal1.Name = "lblTal1";
            this.lblTal1.Size = new System.Drawing.Size(39, 20);
            this.lblTal1.TabIndex = 0;
            this.lblTal1.Text = "Tal1";
            // 
            // lblTal2
            // 
            this.lblTal2.AutoSize = true;
            this.lblTal2.Location = new System.Drawing.Point(267, 158);
            this.lblTal2.Name = "lblTal2";
            this.lblTal2.Size = new System.Drawing.Size(39, 20);
            this.lblTal2.TabIndex = 1;
            this.lblTal2.Text = "Tal2";
            // 
            // tbxTal1
            // 
            this.tbxTal1.Location = new System.Drawing.Point(342, 105);
            this.tbxTal1.Name = "tbxTal1";
            this.tbxTal1.Size = new System.Drawing.Size(100, 26);
            this.tbxTal1.TabIndex = 2;
            // 
            // tbxTal2
            // 
            this.tbxTal2.Location = new System.Drawing.Point(342, 158);
            this.tbxTal2.Name = "tbxTal2";
            this.tbxTal2.Size = new System.Drawing.Size(100, 26);
            this.tbxTal2.TabIndex = 3;
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(267, 217);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(0, 20);
            this.lblSumma.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(295, 266);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(112, 60);
            this.btnKör.TabIndex = 5;
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
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.tbxTal2);
            this.Controls.Add(this.tbxTal1);
            this.Controls.Add(this.lblTal2);
            this.Controls.Add(this.lblTal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTal1;
        private System.Windows.Forms.Label lblTal2;
        private System.Windows.Forms.TextBox tbxTal1;
        private System.Windows.Forms.TextBox tbxTal2;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Button btnKör;
    }
}

