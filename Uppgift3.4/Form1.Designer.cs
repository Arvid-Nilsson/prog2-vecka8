namespace Uppgift3._4
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
            this.lblEngelska = new System.Windows.Forms.Label();
            this.lblSvenska = new System.Windows.Forms.Label();
            this.tbxEngelska = new System.Windows.Forms.TextBox();
            this.tbxSvenska = new System.Windows.Forms.TextBox();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEngelska
            // 
            this.lblEngelska.AutoSize = true;
            this.lblEngelska.Location = new System.Drawing.Point(283, 122);
            this.lblEngelska.Name = "lblEngelska";
            this.lblEngelska.Size = new System.Drawing.Size(75, 20);
            this.lblEngelska.TabIndex = 0;
            this.lblEngelska.Text = "Engelska";
            // 
            // lblSvenska
            // 
            this.lblSvenska.AutoSize = true;
            this.lblSvenska.Location = new System.Drawing.Point(283, 175);
            this.lblSvenska.Name = "lblSvenska";
            this.lblSvenska.Size = new System.Drawing.Size(70, 20);
            this.lblSvenska.TabIndex = 1;
            this.lblSvenska.Text = "Svenska";
            // 
            // tbxEngelska
            // 
            this.tbxEngelska.Location = new System.Drawing.Point(391, 122);
            this.tbxEngelska.Name = "tbxEngelska";
            this.tbxEngelska.Size = new System.Drawing.Size(100, 26);
            this.tbxEngelska.TabIndex = 2;
            // 
            // tbxSvenska
            // 
            this.tbxSvenska.Location = new System.Drawing.Point(391, 175);
            this.tbxSvenska.Name = "tbxSvenska";
            this.tbxSvenska.Size = new System.Drawing.Size(100, 26);
            this.tbxSvenska.TabIndex = 3;
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(326, 231);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 20);
            this.lblSvar.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(320, 283);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(126, 60);
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
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.tbxSvenska);
            this.Controls.Add(this.tbxEngelska);
            this.Controls.Add(this.lblSvenska);
            this.Controls.Add(this.lblEngelska);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEngelska;
        private System.Windows.Forms.Label lblSvenska;
        private System.Windows.Forms.TextBox tbxEngelska;
        private System.Windows.Forms.TextBox tbxSvenska;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnKör;
    }
}

