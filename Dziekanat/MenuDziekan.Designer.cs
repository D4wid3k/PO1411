namespace Dziekanat
{
    partial class MenuDziekan
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
            this.DziekanetLabel = new System.Windows.Forms.Label();
            this.WnioskiButton = new System.Windows.Forms.Button();
            this.KierunkiButton = new System.Windows.Forms.Button();
            this.WylogujButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DziekanetLabel
            // 
            this.DziekanetLabel.AutoSize = true;
            this.DziekanetLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.DziekanetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DziekanetLabel.Location = new System.Drawing.Point(151, 53);
            this.DziekanetLabel.Name = "DziekanetLabel";
            this.DziekanetLabel.Size = new System.Drawing.Size(224, 45);
            this.DziekanetLabel.TabIndex = 4;
            this.DziekanetLabel.Text = "DZIEKAN.NET";
            this.DziekanetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // WnioskiButton
            // 
            this.WnioskiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WnioskiButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WnioskiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WnioskiButton.Location = new System.Drawing.Point(196, 225);
            this.WnioskiButton.Name = "WnioskiButton";
            this.WnioskiButton.Size = new System.Drawing.Size(149, 62);
            this.WnioskiButton.TabIndex = 10;
            this.WnioskiButton.Text = "Wnioski";
            this.WnioskiButton.UseVisualStyleBackColor = false;
            // 
            // KierunkiButton
            // 
            this.KierunkiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.KierunkiButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.KierunkiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.KierunkiButton.Location = new System.Drawing.Point(196, 157);
            this.KierunkiButton.Name = "KierunkiButton";
            this.KierunkiButton.Size = new System.Drawing.Size(149, 62);
            this.KierunkiButton.TabIndex = 11;
            this.KierunkiButton.Text = "Kierunki";
            this.KierunkiButton.UseVisualStyleBackColor = false;
            // 
            // WylogujButton
            // 
            this.WylogujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WylogujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WylogujButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WylogujButton.Location = new System.Drawing.Point(372, 365);
            this.WylogujButton.Name = "WylogujButton";
            this.WylogujButton.Size = new System.Drawing.Size(149, 62);
            this.WylogujButton.TabIndex = 12;
            this.WylogujButton.Text = "Wyloguj";
            this.WylogujButton.UseVisualStyleBackColor = false;
            // 
            // MenuDziekan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(533, 439);
            this.Controls.Add(this.WylogujButton);
            this.Controls.Add(this.KierunkiButton);
            this.Controls.Add(this.WnioskiButton);
            this.Controls.Add(this.DziekanetLabel);
            this.Name = "MenuDziekan";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DziekanetLabel;
        private System.Windows.Forms.Button WnioskiButton;
        private System.Windows.Forms.Button KierunkiButton;
        private System.Windows.Forms.Button WylogujButton;
    }
}