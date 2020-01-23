namespace Dziekanat
{
    partial class WstawOceny
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
            this.DodajOcHeader = new System.Windows.Forms.Label();
            this.ListaStudListbox = new System.Windows.Forms.ListBox();
            this.WypStudListbox = new System.Windows.Forms.ListBox();
            this.ListaStudLabel = new System.Windows.Forms.Label();
            this.WybStudLabel = new System.Windows.Forms.Label();
            this.PowrotButton = new System.Windows.Forms.Button();
            this.DodStudButton = new System.Windows.Forms.Button();
            this.UsunStudButton = new System.Windows.Forms.Button();
            this.PrzedmiotCombobox = new System.Windows.Forms.ComboBox();
            this.OcenaCombobox = new System.Windows.Forms.ComboBox();
            this.PrzedmiotLabel = new System.Windows.Forms.Label();
            this.OcenaLabel = new System.Windows.Forms.Label();
            this.DodOcenButton = new System.Windows.Forms.Button();
            this.WybGruLabel = new System.Windows.Forms.Label();
            this.WybGruCombobox = new System.Windows.Forms.ComboBox();
            this.WybGruZatwButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DodajOcHeader
            // 
            this.DodajOcHeader.AutoSize = true;
            this.DodajOcHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.DodajOcHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodajOcHeader.Location = new System.Drawing.Point(19, 24);
            this.DodajOcHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DodajOcHeader.Name = "DodajOcHeader";
            this.DodajOcHeader.Size = new System.Drawing.Size(169, 37);
            this.DodajOcHeader.TabIndex = 0;
            this.DodajOcHeader.Text = "Dodaj ocene";
            this.DodajOcHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListaStudListbox
            // 
            this.ListaStudListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ListaStudListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaStudListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaStudListbox.FormattingEnabled = true;
            this.ListaStudListbox.Location = new System.Drawing.Point(182, 114);
            this.ListaStudListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaStudListbox.Name = "ListaStudListbox";
            this.ListaStudListbox.Size = new System.Drawing.Size(145, 288);
            this.ListaStudListbox.TabIndex = 4;
            // 
            // WypStudListbox
            // 
            this.WypStudListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WypStudListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WypStudListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WypStudListbox.FormattingEnabled = true;
            this.WypStudListbox.Location = new System.Drawing.Point(342, 114);
            this.WypStudListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WypStudListbox.Name = "WypStudListbox";
            this.WypStudListbox.Size = new System.Drawing.Size(151, 288);
            this.WypStudListbox.TabIndex = 5;
            // 
            // ListaStudLabel
            // 
            this.ListaStudLabel.AutoSize = true;
            this.ListaStudLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.ListaStudLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaStudLabel.Location = new System.Drawing.Point(178, 91);
            this.ListaStudLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaStudLabel.Name = "ListaStudLabel";
            this.ListaStudLabel.Size = new System.Drawing.Size(125, 20);
            this.ListaStudLabel.TabIndex = 6;
            this.ListaStudLabel.Text = "Lista studentow:";
            // 
            // WybStudLabel
            // 
            this.WybStudLabel.AutoSize = true;
            this.WybStudLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.WybStudLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybStudLabel.Location = new System.Drawing.Point(338, 91);
            this.WybStudLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WybStudLabel.Name = "WybStudLabel";
            this.WybStudLabel.Size = new System.Drawing.Size(135, 20);
            this.WybStudLabel.TabIndex = 7;
            this.WybStudLabel.Text = "Wybrani studenci:";
            // 
            // PowrotButton
            // 
            this.PowrotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotButton.Location = new System.Drawing.Point(25, 423);
            this.PowrotButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PowrotButton.Name = "PowrotButton";
            this.PowrotButton.Size = new System.Drawing.Size(125, 50);
            this.PowrotButton.TabIndex = 8;
            this.PowrotButton.Text = "Powrot";
            this.PowrotButton.UseVisualStyleBackColor = false;
            // 
            // DodStudButton
            // 
            this.DodStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DodStudButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodStudButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodStudButton.Location = new System.Drawing.Point(192, 423);
            this.DodStudButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DodStudButton.Name = "DodStudButton";
            this.DodStudButton.Size = new System.Drawing.Size(125, 50);
            this.DodStudButton.TabIndex = 9;
            this.DodStudButton.Text = "Dodaj studenta";
            this.DodStudButton.UseVisualStyleBackColor = false;
            // 
            // UsunStudButton
            // 
            this.UsunStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UsunStudButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.UsunStudButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.UsunStudButton.Location = new System.Drawing.Point(356, 423);
            this.UsunStudButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsunStudButton.Name = "UsunStudButton";
            this.UsunStudButton.Size = new System.Drawing.Size(125, 50);
            this.UsunStudButton.TabIndex = 10;
            this.UsunStudButton.Text = "Usun studenta";
            this.UsunStudButton.UseVisualStyleBackColor = false;
            // 
            // PrzedmiotCombobox
            // 
            this.PrzedmiotCombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.PrzedmiotCombobox.FormattingEnabled = true;
            this.PrzedmiotCombobox.Location = new System.Drawing.Point(529, 159);
            this.PrzedmiotCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrzedmiotCombobox.Name = "PrzedmiotCombobox";
            this.PrzedmiotCombobox.Size = new System.Drawing.Size(126, 27);
            this.PrzedmiotCombobox.TabIndex = 11;
            // 
            // OcenaCombobox
            // 
            this.OcenaCombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.OcenaCombobox.FormattingEnabled = true;
            this.OcenaCombobox.Location = new System.Drawing.Point(529, 214);
            this.OcenaCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OcenaCombobox.Name = "OcenaCombobox";
            this.OcenaCombobox.Size = new System.Drawing.Size(126, 27);
            this.OcenaCombobox.TabIndex = 12;
            // 
            // PrzedmiotLabel
            // 
            this.PrzedmiotLabel.AutoSize = true;
            this.PrzedmiotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PrzedmiotLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PrzedmiotLabel.Location = new System.Drawing.Point(526, 141);
            this.PrzedmiotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PrzedmiotLabel.Name = "PrzedmiotLabel";
            this.PrzedmiotLabel.Size = new System.Drawing.Size(75, 17);
            this.PrzedmiotLabel.TabIndex = 13;
            this.PrzedmiotLabel.Text = "Przedmiot:";
            // 
            // OcenaLabel
            // 
            this.OcenaLabel.AutoSize = true;
            this.OcenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.OcenaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.OcenaLabel.Location = new System.Drawing.Point(526, 196);
            this.OcenaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OcenaLabel.Name = "OcenaLabel";
            this.OcenaLabel.Size = new System.Drawing.Size(54, 17);
            this.OcenaLabel.TabIndex = 14;
            this.OcenaLabel.Text = "Ocena:";
            // 
            // DodOcenButton
            // 
            this.DodOcenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DodOcenButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DodOcenButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.DodOcenButton.Location = new System.Drawing.Point(529, 267);
            this.DodOcenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DodOcenButton.Name = "DodOcenButton";
            this.DodOcenButton.Size = new System.Drawing.Size(125, 50);
            this.DodOcenButton.TabIndex = 15;
            this.DodOcenButton.Text = "Dodaj ocene";
            this.DodOcenButton.UseVisualStyleBackColor = false;
            // 
            // WybGruLabel
            // 
            this.WybGruLabel.AutoSize = true;
            this.WybGruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybGruLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybGruLabel.Location = new System.Drawing.Point(22, 141);
            this.WybGruLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WybGruLabel.Name = "WybGruLabel";
            this.WybGruLabel.Size = new System.Drawing.Size(104, 17);
            this.WybGruLabel.TabIndex = 2;
            this.WybGruLabel.Text = "Wybierz grupe:";
            // 
            // WybGruCombobox
            // 
            this.WybGruCombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybGruCombobox.FormattingEnabled = true;
            this.WybGruCombobox.Location = new System.Drawing.Point(25, 159);
            this.WybGruCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WybGruCombobox.Name = "WybGruCombobox";
            this.WybGruCombobox.Size = new System.Drawing.Size(126, 27);
            this.WybGruCombobox.TabIndex = 1;
            // 
            // WybGruZatwButton
            // 
            this.WybGruZatwButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WybGruZatwButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WybGruZatwButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybGruZatwButton.Location = new System.Drawing.Point(25, 202);
            this.WybGruZatwButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WybGruZatwButton.Name = "WybGruZatwButton";
            this.WybGruZatwButton.Size = new System.Drawing.Size(125, 50);
            this.WybGruZatwButton.TabIndex = 3;
            this.WybGruZatwButton.Text = "Zatwierdz";
            this.WybGruZatwButton.UseVisualStyleBackColor = false;
            // 
            // WstawOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(689, 501);
            this.Controls.Add(this.DodOcenButton);
            this.Controls.Add(this.OcenaLabel);
            this.Controls.Add(this.PrzedmiotLabel);
            this.Controls.Add(this.OcenaCombobox);
            this.Controls.Add(this.PrzedmiotCombobox);
            this.Controls.Add(this.UsunStudButton);
            this.Controls.Add(this.DodStudButton);
            this.Controls.Add(this.PowrotButton);
            this.Controls.Add(this.WybStudLabel);
            this.Controls.Add(this.ListaStudLabel);
            this.Controls.Add(this.WypStudListbox);
            this.Controls.Add(this.ListaStudListbox);
            this.Controls.Add(this.WybGruZatwButton);
            this.Controls.Add(this.WybGruLabel);
            this.Controls.Add(this.WybGruCombobox);
            this.Controls.Add(this.DodajOcHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WstawOceny";
            this.Text = "Dziekanat";
            this.Load += new System.EventHandler(this.WstawOceny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DodajOcHeader;
        private System.Windows.Forms.ListBox ListaStudListbox;
        private System.Windows.Forms.ListBox WypStudListbox;
        private System.Windows.Forms.Label ListaStudLabel;
        private System.Windows.Forms.Label WybStudLabel;
        private System.Windows.Forms.Button PowrotButton;
        private System.Windows.Forms.Button DodStudButton;
        private System.Windows.Forms.Button UsunStudButton;
        private System.Windows.Forms.ComboBox PrzedmiotCombobox;
        private System.Windows.Forms.ComboBox OcenaCombobox;
        private System.Windows.Forms.Label PrzedmiotLabel;
        private System.Windows.Forms.Label OcenaLabel;
        private System.Windows.Forms.Button DodOcenButton;
        private System.Windows.Forms.Label WybGruLabel;
        private System.Windows.Forms.ComboBox WybGruCombobox;
        private System.Windows.Forms.Button WybGruZatwButton;
    }
}