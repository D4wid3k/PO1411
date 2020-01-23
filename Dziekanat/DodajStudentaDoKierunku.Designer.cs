namespace Dziekanat
{
    partial class DodajStudentaDoKierunku
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
            this.DodajStudHeader = new System.Windows.Forms.Label();
            this.WpiszIDLabel = new System.Windows.Forms.Label();
            this.WpiszIDTextbox = new System.Windows.Forms.TextBox();
            this.PowrotKierButton = new System.Windows.Forms.Button();
            this.DodajStudButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DodajStudHeader
            // 
            this.DodajStudHeader.AutoSize = true;
            this.DodajStudHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.DodajStudHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodajStudHeader.Location = new System.Drawing.Point(48, 54);
            this.DodajStudHeader.Name = "DodajStudHeader";
            this.DodajStudHeader.Size = new System.Drawing.Size(438, 45);
            this.DodajStudHeader.TabIndex = 9;
            this.DodajStudHeader.Text = "Dodaj studenta do kierunku";
            this.DodajStudHeader.Click += new System.EventHandler(this.KierHeader_Click);
            // 
            // WpiszIDLabel
            // 
            this.WpiszIDLabel.AutoSize = true;
            this.WpiszIDLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.WpiszIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WpiszIDLabel.Location = new System.Drawing.Point(51, 153);
            this.WpiszIDLabel.Name = "WpiszIDLabel";
            this.WpiszIDLabel.Size = new System.Drawing.Size(178, 25);
            this.WpiszIDLabel.TabIndex = 17;
            this.WpiszIDLabel.Text = "Wpisz ID studenta:";
            // 
            // WpiszIDTextbox
            // 
            this.WpiszIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WpiszIDTextbox.Location = new System.Drawing.Point(244, 150);
            this.WpiszIDTextbox.Name = "WpiszIDTextbox";
            this.WpiszIDTextbox.Size = new System.Drawing.Size(124, 30);
            this.WpiszIDTextbox.TabIndex = 18;
            // 
            // PowrotKierButton
            // 
            this.PowrotKierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotKierButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotKierButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotKierButton.Location = new System.Drawing.Point(229, 237);
            this.PowrotKierButton.Name = "PowrotKierButton";
            this.PowrotKierButton.Size = new System.Drawing.Size(149, 62);
            this.PowrotKierButton.TabIndex = 19;
            this.PowrotKierButton.Text = "Powrot";
            this.PowrotKierButton.UseVisualStyleBackColor = false;
            // 
            // DodajStudButton
            // 
            this.DodajStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DodajStudButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodajStudButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodajStudButton.Location = new System.Drawing.Point(391, 151);
            this.DodajStudButton.Name = "DodajStudButton";
            this.DodajStudButton.Size = new System.Drawing.Size(124, 30);
            this.DodajStudButton.TabIndex = 20;
            this.DodajStudButton.Text = "Dodaj";
            this.DodajStudButton.UseVisualStyleBackColor = false;
            this.DodajStudButton.Click += new System.EventHandler(this.DodajStudButton_Click);
            // 
            // DodajStudentaDoKierunku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(594, 333);
            this.Controls.Add(this.DodajStudButton);
            this.Controls.Add(this.PowrotKierButton);
            this.Controls.Add(this.WpiszIDTextbox);
            this.Controls.Add(this.WpiszIDLabel);
            this.Controls.Add(this.DodajStudHeader);
            this.Name = "DodajStudentaDoKierunku";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DodajStudHeader;
        private System.Windows.Forms.Label WpiszIDLabel;
        private System.Windows.Forms.TextBox WpiszIDTextbox;
        private System.Windows.Forms.Button PowrotKierButton;
        private System.Windows.Forms.Button DodajStudButton;
    }
}