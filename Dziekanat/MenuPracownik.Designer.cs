namespace Dziekanat
{
    partial class MenuPracownik
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
            this.ImieLabel = new System.Windows.Forms.Label();
            this.WitajLabel = new System.Windows.Forms.Label();
            this.PlanLabel = new System.Windows.Forms.Button();
            this.WylogujLabel = new System.Windows.Forms.Button();
            this.DodajOcLabel = new System.Windows.Forms.Button();
            this.ZmienOcLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.ImieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ImieLabel.Location = new System.Drawing.Point(200, 39);
            this.ImieLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(70, 37);
            this.ImieLabel.TabIndex = 3;
            this.ImieLabel.Text = "Imie";
            // 
            // WitajLabel
            // 
            this.WitajLabel.AutoSize = true;
            this.WitajLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.WitajLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WitajLabel.Location = new System.Drawing.Point(136, 39);
            this.WitajLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WitajLabel.Name = "WitajLabel";
            this.WitajLabel.Size = new System.Drawing.Size(81, 37);
            this.WitajLabel.TabIndex = 2;
            this.WitajLabel.Text = "Witaj";
            // 
            // PlanLabel
            // 
            this.PlanLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PlanLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PlanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PlanLabel.Location = new System.Drawing.Point(145, 240);
            this.PlanLabel.Margin = new System.Windows.Forms.Padding(2);
            this.PlanLabel.Name = "PlanLabel";
            this.PlanLabel.Size = new System.Drawing.Size(112, 50);
            this.PlanLabel.TabIndex = 7;
            this.PlanLabel.Text = "Plan";
            this.PlanLabel.UseVisualStyleBackColor = false;
            this.PlanLabel.Click += new System.EventHandler(this.button1_Click);
            // 
            // WylogujLabel
            // 
            this.WylogujLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WylogujLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WylogujLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WylogujLabel.Location = new System.Drawing.Point(261, 370);
            this.WylogujLabel.Margin = new System.Windows.Forms.Padding(2);
            this.WylogujLabel.Name = "WylogujLabel";
            this.WylogujLabel.Size = new System.Drawing.Size(112, 50);
            this.WylogujLabel.TabIndex = 5;
            this.WylogujLabel.Text = "Wyloguj";
            this.WylogujLabel.UseVisualStyleBackColor = false;
            this.WylogujLabel.Click += new System.EventHandler(this.WylogujLabel_Click);
            // 
            // DodajOcLabel
            // 
            this.DodajOcLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DodajOcLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodajOcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodajOcLabel.Location = new System.Drawing.Point(145, 129);
            this.DodajOcLabel.Margin = new System.Windows.Forms.Padding(2);
            this.DodajOcLabel.Name = "DodajOcLabel";
            this.DodajOcLabel.Size = new System.Drawing.Size(112, 50);
            this.DodajOcLabel.TabIndex = 6;
            this.DodajOcLabel.Text = "Dodaj oceny";
            this.DodajOcLabel.UseVisualStyleBackColor = false;
            this.DodajOcLabel.Click += new System.EventHandler(this.DodajOcLabel_Click);
            // 
            // ZmienOcLabel
            // 
            this.ZmienOcLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZmienOcLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ZmienOcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZmienOcLabel.Location = new System.Drawing.Point(145, 184);
            this.ZmienOcLabel.Margin = new System.Windows.Forms.Padding(2);
            this.ZmienOcLabel.Name = "ZmienOcLabel";
            this.ZmienOcLabel.Size = new System.Drawing.Size(112, 50);
            this.ZmienOcLabel.TabIndex = 8;
            this.ZmienOcLabel.Text = "Zmien oceny";
            this.ZmienOcLabel.UseVisualStyleBackColor = false;
            // 
            // MenuPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.ZmienOcLabel);
            this.Controls.Add(this.PlanLabel);
            this.Controls.Add(this.DodajOcLabel);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.WylogujLabel);
            this.Controls.Add(this.WitajLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPracownik";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label WitajLabel;
        private System.Windows.Forms.Button PlanLabel;
        private System.Windows.Forms.Button WylogujLabel;
        private System.Windows.Forms.Button DodajOcLabel;
        private System.Windows.Forms.Button ZmienOcLabel;
    }
}