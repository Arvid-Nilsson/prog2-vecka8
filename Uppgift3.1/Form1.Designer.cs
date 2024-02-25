namespace Uppgift3._1
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
            this.tbxTal = new System.Windows.Forms.TextBox();
            this.lblTal = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTal
            // 
            this.tbxTal.Location = new System.Drawing.Point(356, 105);
            this.tbxTal.Name = "tbxTal";
            this.tbxTal.Size = new System.Drawing.Size(100, 26);
            this.tbxTal.TabIndex = 0;
            // 
            // lblTal
            // 
            this.lblTal.AutoSize = true;
            this.lblTal.Location = new System.Drawing.Point(279, 108);
            this.lblTal.Name = "lblTal";
            this.lblTal.Size = new System.Drawing.Size(30, 20);
            this.lblTal.TabIndex = 1;
            this.lblTal.Text = "Tal";
            this.lblTal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(264, 187);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(213, 34);
            this.btnKör.TabIndex = 2;
            this.btnKör.Text = "Beräkna kvadraten";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblTal);
            this.Controls.Add(this.tbxTal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTal;
        private System.Windows.Forms.Label lblTal;
        private System.Windows.Forms.Button btnKör;
    }
}

