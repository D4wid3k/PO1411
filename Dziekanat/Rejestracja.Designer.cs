namespace Dziekanat
{
    partial class Rejestracja
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
            this.RejestrHeader = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.ImieTextbox = new System.Windows.Forms.TextBox();
            this.NazwiskoTextbox = new System.Windows.Forms.TextBox();
            this.PeselTextbox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.PeselLabel = new System.Windows.Forms.Label();
            this.HasloLabel = new System.Windows.Forms.Label();
            this.HasloTextbox = new System.Windows.Forms.TextBox();
            this.PunktyRekrLabel = new System.Windows.Forms.Label();
            this.PunktyRekrTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ZarejestrujButton = new System.Windows.Forms.Button();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RejestrHeader
            // 
            this.RejestrHeader.AutoSize = true;
            this.RejestrHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RejestrHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.RejestrHeader.Location = new System.Drawing.Point(307, 37);
            this.RejestrHeader.Name = "RejestrHeader";
            this.RejestrHeader.Size = new System.Drawing.Size(182, 45);
            this.RejestrHeader.TabIndex = 2;
            this.RejestrHeader.Text = "Rejestracja";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTextbox.Location = new System.Drawing.Point(366, 118);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(287, 30);
            this.EmailTextbox.TabIndex = 3;
            // 
            // ImieTextbox
            // 
            this.ImieTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImieTextbox.Location = new System.Drawing.Point(366, 216);
            this.ImieTextbox.Name = "ImieTextbox";
            this.ImieTextbox.Size = new System.Drawing.Size(287, 30);
            this.ImieTextbox.TabIndex = 4;
            // 
            // NazwiskoTextbox
            // 
            this.NazwiskoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwiskoTextbox.Location = new System.Drawing.Point(366, 268);
            this.NazwiskoTextbox.Name = "NazwiskoTextbox";
            this.NazwiskoTextbox.Size = new System.Drawing.Size(287, 30);
            this.NazwiskoTextbox.TabIndex = 5;
            // 
            // PeselTextbox
            // 
            this.PeselTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PeselTextbox.Location = new System.Drawing.Point(366, 318);
            this.PeselTextbox.Name = "PeselTextbox";
            this.PeselTextbox.Size = new System.Drawing.Size(287, 30);
            this.PeselTextbox.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(110, 128);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(130, 17);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Podaj adres e-mail:";
            this.EmailLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ImieLabel.Location = new System.Drawing.Point(110, 226);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(77, 17);
            this.ImieLabel.TabIndex = 8;
            this.ImieLabel.Text = "Podaj imie:";
            this.ImieLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.NazwiskoLabel.Location = new System.Drawing.Point(110, 278);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(109, 17);
            this.NazwiskoLabel.TabIndex = 9;
            this.NazwiskoLabel.Text = "Podaj nazwisko:";
            // 
            // PeselLabel
            // 
            this.PeselLabel.AutoSize = true;
            this.PeselLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PeselLabel.Location = new System.Drawing.Point(110, 328);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(96, 17);
            this.PeselLabel.TabIndex = 10;
            this.PeselLabel.Text = "Podaj PESEL:";
            // 
            // HasloLabel
            // 
            this.HasloLabel.AutoSize = true;
            this.HasloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.HasloLabel.Location = new System.Drawing.Point(110, 176);
            this.HasloLabel.Name = "HasloLabel";
            this.HasloLabel.Size = new System.Drawing.Size(86, 17);
            this.HasloLabel.TabIndex = 11;
            this.HasloLabel.Text = "Podaj haslo:";
            this.HasloLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // HasloTextbox
            // 
            this.HasloTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HasloTextbox.Location = new System.Drawing.Point(366, 166);
            this.HasloTextbox.Name = "HasloTextbox";
            this.HasloTextbox.Size = new System.Drawing.Size(287, 30);
            this.HasloTextbox.TabIndex = 12;
            // 
            // PunktyRekrLabel
            // 
            this.PunktyRekrLabel.AutoSize = true;
            this.PunktyRekrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PunktyRekrLabel.Location = new System.Drawing.Point(110, 379);
            this.PunktyRekrLabel.Name = "PunktyRekrLabel";
            this.PunktyRekrLabel.Size = new System.Drawing.Size(232, 17);
            this.PunktyRekrLabel.TabIndex = 14;
            this.PunktyRekrLabel.Text = "Podaj ilosc punktow rekrutacyjnych:";
            // 
            // PunktyRekrTextbox
            // 
            this.PunktyRekrTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PunktyRekrTextbox.Location = new System.Drawing.Point(366, 369);
            this.PunktyRekrTextbox.Name = "PunktyRekrTextbox";
            this.PunktyRekrTextbox.Size = new System.Drawing.Size(287, 30);
            this.PunktyRekrTextbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(110, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 15;
            // 
            // ZarejestrujButton
            // 
            this.ZarejestrujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZarejestrujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZarejestrujButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZarejestrujButton.Location = new System.Drawing.Point(315, 435);
            this.ZarejestrujButton.Name = "ZarejestrujButton";
            this.ZarejestrujButton.Size = new System.Drawing.Size(196, 67);
            this.ZarejestrujButton.TabIndex = 16;
            this.ZarejestrujButton.Text = "Zarejestruj";
            this.ZarejestrujButton.UseVisualStyleBackColor = false;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Button.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.Button.Location = new System.Drawing.Point(643, 539);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(145, 59);
            this.Button.TabIndex = 17;
            this.Button.Text = "Powrot";
            this.Button.UseVisualStyleBackColor = false;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ZarejestrujButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PunktyRekrLabel);
            this.Controls.Add(this.PunktyRekrTextbox);
            this.Controls.Add(this.HasloTextbox);
            this.Controls.Add(this.HasloLabel);
            this.Controls.Add(this.PeselLabel);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PeselTextbox);
            this.Controls.Add(this.NazwiskoTextbox);
            this.Controls.Add(this.ImieTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.RejestrHeader);
            this.Name = "Rejestracja";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RejestrHeader;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox ImieTextbox;
        private System.Windows.Forms.TextBox NazwiskoTextbox;
        private System.Windows.Forms.TextBox PeselTextbox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label PeselLabel;
        private System.Windows.Forms.Label HasloLabel;
        private System.Windows.Forms.TextBox HasloTextbox;
        private System.Windows.Forms.Label PunktyRekrLabel;
        private System.Windows.Forms.TextBox PunktyRekrTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ZarejestrujButton;
        private System.Windows.Forms.Button Button;
    }
}