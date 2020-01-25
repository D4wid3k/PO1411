namespace Dziekanat
{
    partial class Wnioski
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
            this.WnioskiLabel = new System.Windows.Forms.Label();
            this.ListaWnioskowListbox = new System.Windows.Forms.ListBox();
            this.ListWnioskowLabel = new System.Windows.Forms.Label();
            this.PowrotButton = new System.Windows.Forms.Button();
            this.WyswietlWniosekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WnioskiLabel
            // 
            this.WnioskiLabel.AutoSize = true;
            this.WnioskiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.WnioskiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WnioskiLabel.Location = new System.Drawing.Point(26, 22);
            this.WnioskiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WnioskiLabel.Name = "WnioskiLabel";
            this.WnioskiLabel.Size = new System.Drawing.Size(115, 37);
            this.WnioskiLabel.TabIndex = 3;
            this.WnioskiLabel.Text = "Wnioski";
            // 
            // ListaWnioskowListbox
            // 
            this.ListaWnioskowListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ListaWnioskowListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaWnioskowListbox.FormattingEnabled = true;
            this.ListaWnioskowListbox.Location = new System.Drawing.Point(32, 114);
            this.ListaWnioskowListbox.Margin = new System.Windows.Forms.Padding(2);
            this.ListaWnioskowListbox.Name = "ListaWnioskowListbox";
            this.ListaWnioskowListbox.Size = new System.Drawing.Size(342, 225);
            this.ListaWnioskowListbox.TabIndex = 4;
            // 
            // ListWnioskowLabel
            // 
            this.ListWnioskowLabel.AutoSize = true;
            this.ListWnioskowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ListWnioskowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListWnioskowLabel.Location = new System.Drawing.Point(29, 93);
            this.ListWnioskowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListWnioskowLabel.Name = "ListWnioskowLabel";
            this.ListWnioskowLabel.Size = new System.Drawing.Size(186, 19);
            this.ListWnioskowLabel.TabIndex = 5;
            this.ListWnioskowLabel.Text = "Lista przeslanych wnioskow:";
            // 
            // PowrotButton
            // 
            this.PowrotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotButton.Location = new System.Drawing.Point(295, 418);
            this.PowrotButton.Margin = new System.Windows.Forms.Padding(2);
            this.PowrotButton.Name = "PowrotButton";
            this.PowrotButton.Size = new System.Drawing.Size(112, 50);
            this.PowrotButton.TabIndex = 14;
            this.PowrotButton.Text = "Powrot";
            this.PowrotButton.UseVisualStyleBackColor = false;
            // 
            // WyswietlWniosekButton
            // 
            this.WyswietlWniosekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WyswietlWniosekButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WyswietlWniosekButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WyswietlWniosekButton.Location = new System.Drawing.Point(262, 343);
            this.WyswietlWniosekButton.Margin = new System.Windows.Forms.Padding(2);
            this.WyswietlWniosekButton.Name = "WyswietlWniosekButton";
            this.WyswietlWniosekButton.Size = new System.Drawing.Size(112, 50);
            this.WyswietlWniosekButton.TabIndex = 13;
            this.WyswietlWniosekButton.Text = "Wyswietl";
            this.WyswietlWniosekButton.UseVisualStyleBackColor = false;
            this.WyswietlWniosekButton.Click += new System.EventHandler(this.UsunWniosekButton_Click);
            // 
            // Wnioski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(416, 479);
            this.Controls.Add(this.PowrotButton);
            this.Controls.Add(this.WyswietlWniosekButton);
            this.Controls.Add(this.ListWnioskowLabel);
            this.Controls.Add(this.ListaWnioskowListbox);
            this.Controls.Add(this.WnioskiLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Wnioski";
            this.Text = "Dziekanat";
            this.Load += new System.EventHandler(this.Wnioski_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WnioskiLabel;
        private System.Windows.Forms.ListBox ListaWnioskowListbox;
        private System.Windows.Forms.Label ListWnioskowLabel;
        private System.Windows.Forms.Button PowrotButton;
        private System.Windows.Forms.Button WyswietlWniosekButton;
    }
}