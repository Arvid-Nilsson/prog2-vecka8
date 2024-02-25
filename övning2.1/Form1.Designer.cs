namespace övning2._1
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
            this.btnRöd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRöd
            // 
            this.btnRöd.Location = new System.Drawing.Point(186, 172);
            this.btnRöd.Name = "btnRöd";
            this.btnRöd.Size = new System.Drawing.Size(93, 55);
            this.btnRöd.TabIndex = 0;
            this.btnRöd.Text = "Röd";
            this.btnRöd.UseVisualStyleBackColor = true;
            this.btnRöd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Blå";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRöd);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRöd;
        private System.Windows.Forms.Button button2;
    }
}

