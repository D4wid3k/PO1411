namespace Dziekanat
{
    partial class NowyKierunek
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
            this.NowyKierLabel = new System.Windows.Forms.Label();
            this.NazwaKierTextbox = new System.Windows.Forms.TextBox();
            this.NazwaKierLabel = new System.Windows.Forms.Label();
            this.RokRozpLabel = new System.Windows.Forms.Label();
            this.RokRozpTextbox = new System.Windows.Forms.TextBox();
            this.PowrotButton = new System.Windows.Forms.Button();
            this.StworzKierButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NowyKierLabel
            // 
            this.NowyKierLabel.AutoSize = true;
            this.NowyKierLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.NowyKierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.NowyKierLabel.Location = new System.Drawing.Point(37, 49);
            this.NowyKierLabel.Name = "NowyKierLabel";
            this.NowyKierLabel.Size = new System.Drawing.Size(273, 45);
            this.NowyKierLabel.TabIndex = 13;
            this.NowyKierLabel.Text = "Nowy Kierunek...";
            this.NowyKierLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NazwaKierTextbox
            // 
            this.NazwaKierTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NazwaKierTextbox.Location = new System.Drawing.Point(45, 190);
            this.NazwaKierTextbox.Name = "NazwaKierTextbox";
            this.NazwaKierTextbox.Size = new System.Drawing.Size(287, 26);
            this.NazwaKierTextbox.TabIndex = 14;
            // 
            // NazwaKierLabel
            // 
            this.NazwaKierLabel.AutoSize = true;
            this.NazwaKierLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.NazwaKierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.NazwaKierLabel.Location = new System.Drawing.Point(40, 162);
            this.NazwaKierLabel.Name = "NazwaKierLabel";
            this.NazwaKierLabel.Size = new System.Drawing.Size(162, 25);
            this.NazwaKierLabel.TabIndex = 17;
            this.NazwaKierLabel.Text = "Nazwa kierunku:";
            // 
            // RokRozpLabel
            // 
            this.RokRozpLabel.AutoSize = true;
            this.RokRozpLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.RokRozpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.RokRozpLabel.Location = new System.Drawing.Point(40, 241);
            this.RokRozpLabel.Name = "RokRozpLabel";
            this.RokRozpLabel.Size = new System.Drawing.Size(162, 25);
            this.RokRozpLabel.TabIndex = 19;
            this.RokRozpLabel.Text = "Rok rozpoczecia:";
            // 
            // RokRozpTextbox
            // 
            this.RokRozpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RokRozpTextbox.Location = new System.Drawing.Point(45, 269);
            this.RokRozpTextbox.Name = "RokRozpTextbox";
            this.RokRozpTextbox.Size = new System.Drawing.Size(287, 26);
            this.RokRozpTextbox.TabIndex = 18;
            // 
            // PowrotButton
            // 
            this.PowrotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotButton.Location = new System.Drawing.Point(378, 329);
            this.PowrotButton.Name = "PowrotButton";
            this.PowrotButton.Size = new System.Drawing.Size(149, 62);
            this.PowrotButton.TabIndex = 20;
            this.PowrotButton.Text = "Powrot";
            this.PowrotButton.UseVisualStyleBackColor = false;
            // 
            // StworzKierButton
            // 
            this.StworzKierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.StworzKierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.StworzKierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.StworzKierButton.Location = new System.Drawing.Point(45, 329);
            this.StworzKierButton.Name = "StworzKierButton";
            this.StworzKierButton.Size = new System.Drawing.Size(149, 62);
            this.StworzKierButton.TabIndex = 21;
            this.StworzKierButton.Text = "Stworz";
            this.StworzKierButton.UseVisualStyleBackColor = false;
            // 
            // NowyKierunek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(565, 426);
            this.Controls.Add(this.StworzKierButton);
            this.Controls.Add(this.PowrotButton);
            this.Controls.Add(this.RokRozpLabel);
            this.Controls.Add(this.RokRozpTextbox);
            this.Controls.Add(this.NazwaKierLabel);
            this.Controls.Add(this.NazwaKierTextbox);
            this.Controls.Add(this.NowyKierLabel);
            this.Name = "NowyKierunek";
            this.Text = "Dziekanat";
            this.Load += new System.EventHandler(this.NowyKierunek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowyKierLabel;
        private System.Windows.Forms.TextBox NazwaKierTextbox;
        private System.Windows.Forms.Label NazwaKierLabel;
        private System.Windows.Forms.Label RokRozpLabel;
        private System.Windows.Forms.TextBox RokRozpTextbox;
        private System.Windows.Forms.Button PowrotButton;
        private System.Windows.Forms.Button StworzKierButton;
    }
}