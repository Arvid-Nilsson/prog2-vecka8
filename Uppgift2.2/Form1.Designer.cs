namespace Uppgift2._2
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
            this.btnVänster = new System.Windows.Forms.Button();
            this.btnHöger = new System.Windows.Forms.Button();
            this.lblFlytta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVänster
            // 
            this.btnVänster.Location = new System.Drawing.Point(188, 137);
            this.btnVänster.Name = "btnVänster";
            this.btnVänster.Size = new System.Drawing.Size(94, 49);
            this.btnVänster.TabIndex = 0;
            this.btnVänster.Text = "Vänster";
            this.btnVänster.UseVisualStyleBackColor = true;
            this.btnVänster.Click += new System.EventHandler(this.btnVänster_Click);
            // 
            // btnHöger
            // 
            this.btnHöger.Location = new System.Drawing.Point(463, 137);
            this.btnHöger.Name = "btnHöger";
            this.btnHöger.Size = new System.Drawing.Size(94, 49);
            this.btnHöger.TabIndex = 1;
            this.btnHöger.Text = "Höger";
            this.btnHöger.UseVisualStyleBackColor = true;
            this.btnHöger.Click += new System.EventHandler(this.btnHöger_Click);
            // 
            // lblFlytta
            // 
            this.lblFlytta.AutoSize = true;
            this.lblFlytta.Location = new System.Drawing.Point(295, 220);
            this.lblFlytta.Name = "lblFlytta";
            this.lblFlytta.Size = new System.Drawing.Size(146, 20);
            this.lblFlytta.TabIndex = 2;
            this.lblFlytta.Text = "Vänster eller Höger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 306);
            this.Controls.Add(this.lblFlytta);
            this.Controls.Add(this.btnHöger);
            this.Controls.Add(this.btnVänster);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVänster;
        private System.Windows.Forms.Button btnHöger;
        private System.Windows.Forms.Label lblFlytta;
    }
}

