namespace Dziekanat
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZalogujButton = new System.Windows.Forms.Button();
            this.LogHeader = new System.Windows.Forms.Label();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.HasloTextbox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.HasloLabel = new System.Windows.Forms.Label();
            this.RejestracjaButton = new System.Windows.Forms.Button();
            this.CzyKandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZalogujButton
            // 
            this.ZalogujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZalogujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZalogujButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZalogujButton.Location = new System.Drawing.Point(207, 201);
            this.ZalogujButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZalogujButton.Name = "ZalogujButton";
            this.ZalogujButton.Size = new System.Drawing.Size(116, 54);
            this.ZalogujButton.TabIndex = 0;
            this.ZalogujButton.Text = "Zaloguj";
            this.ZalogujButton.UseVisualStyleBackColor = false;
            this.ZalogujButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogHeader
            // 
            this.LogHeader.AutoSize = true;
            this.LogHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.LogHeader.Location = new System.Drawing.Point(194, 23);
            this.LogHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogHeader.Name = "LogHeader";
            this.LogHeader.Size = new System.Drawing.Size(149, 37);
            this.LogHeader.TabIndex = 1;
            this.LogHeader.Text = "Logowanie";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginTextbox.Location = new System.Drawing.Point(166, 113);
            this.LoginTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(198, 26);
            this.LoginTextbox.TabIndex = 2;
            // 
            // HasloTextbox
            // 
            this.HasloTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HasloTextbox.Location = new System.Drawing.Point(166, 160);
            this.HasloTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.HasloTextbox.Name = "HasloTextbox";
            this.HasloTextbox.Size = new System.Drawing.Size(198, 26);
            this.HasloTextbox.TabIndex = 3;
            this.HasloTextbox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.LoginLabel.Location = new System.Drawing.Point(164, 97);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(36, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login:";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.HasloLabel.Location = new System.Drawing.Point(164, 144);
            this.HasloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(37, 13);
            this.HasloLabel.TabIndex = 5;
            this.HasloLabel.Text = "Haslo:";
            // 
            // RejestracjaButton
            // 
            this.RejestracjaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RejestracjaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RejestracjaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.RejestracjaButton.Location = new System.Drawing.Point(207, 329);
            this.RejestracjaButton.Margin = new System.Windows.Forms.Padding(2);
            this.RejestracjaButton.Name = "RejestracjaButton";
            this.RejestracjaButton.Size = new System.Drawing.Size(116, 28);
            this.RejestracjaButton.TabIndex = 6;
            this.RejestracjaButton.Text = "Rejestracja";
            this.RejestracjaButton.UseVisualStyleBackColor = false;
            this.RejestracjaButton.Click += new System.EventHandler(this.RejestracjaButton_Click);
            // 
            // CzyKandLabel
            // 
            this.CzyKandLabel.AutoSize = true;
            this.CzyKandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.CzyKandLabel.Location = new System.Drawing.Point(212, 313);
            this.CzyKandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CzyKandLabel.Name = "CzyKandLabel";
            this.CzyKandLabel.Size = new System.Drawing.Size(104, 13);
            this.CzyKandLabel.TabIndex = 7;
            this.CzyKandLabel.Text = "Jesteś kandydatem?";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(524, 394);
            this.Controls.Add(this.CzyKandLabel);
            this.Controls.Add(this.RejestracjaButton);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.HasloTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.LogHeader);
            this.Controls.Add(this.ZalogujButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Logowanie";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZalogujButton;
        private System.Windows.Forms.Label LogHeader;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.TextBox HasloTextbox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.Button RejestracjaButton;
        private System.Windows.Forms.Label CzyKandLabel;
    }
}

