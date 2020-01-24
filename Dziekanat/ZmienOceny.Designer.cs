namespace Dziekanat
{
    partial class ZmienOceny
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
            this.ZmienOceneHeader = new System.Windows.Forms.Label();
            this.WybranaOcenaListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZmienOceneButton = new System.Windows.Forms.Button();
            this.OcenaLabel = new System.Windows.Forms.Label();
            this.OcenaCombobox = new System.Windows.Forms.ComboBox();
            this.ZobaczOcenyButton = new System.Windows.Forms.Button();
            this.PowrotButton = new System.Windows.Forms.Button();
            this.WybStudLabel = new System.Windows.Forms.Label();
            this.ListaStudLabel = new System.Windows.Forms.Label();
            this.OcenyListbox = new System.Windows.Forms.ListBox();
            this.ListaStudListbox = new System.Windows.Forms.ListBox();
            this.WybGruZatwButton = new System.Windows.Forms.Button();
            this.WybGruLabel = new System.Windows.Forms.Label();
            this.WybGruCombobox = new System.Windows.Forms.ComboBox();
            this.Wybierz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZmienOceneHeader
            // 
            this.ZmienOceneHeader.AutoSize = true;
            this.ZmienOceneHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.ZmienOceneHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZmienOceneHeader.Location = new System.Drawing.Point(24, 26);
            this.ZmienOceneHeader.Name = "ZmienOceneHeader";
            this.ZmienOceneHeader.Size = new System.Drawing.Size(178, 37);
            this.ZmienOceneHeader.TabIndex = 1;
            this.ZmienOceneHeader.Text = "Zmien Ocene";
            // 
            // WybranaOcenaListBox
            // 
            this.WybranaOcenaListBox.BackColor = System.Drawing.Color.White;
            this.WybranaOcenaListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WybranaOcenaListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.WybranaOcenaListBox.ForeColor = System.Drawing.Color.Black;
            this.WybranaOcenaListBox.FormattingEnabled = true;
            this.WybranaOcenaListBox.ItemHeight = 19;
            this.WybranaOcenaListBox.Location = new System.Drawing.Point(533, 152);
            this.WybranaOcenaListBox.Margin = new System.Windows.Forms.Padding(2);
            this.WybranaOcenaListBox.Name = "WybranaOcenaListBox";
            this.WybranaOcenaListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.WybranaOcenaListBox.Size = new System.Drawing.Size(126, 21);
            this.WybranaOcenaListBox.TabIndex = 21;
            this.WybranaOcenaListBox.SelectedIndexChanged += new System.EventHandler(this.WybranaOcenaListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(530, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Wybrana ocena:";
            // 
            // ZmienOceneButton
            // 
            this.ZmienOceneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZmienOceneButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ZmienOceneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZmienOceneButton.Location = new System.Drawing.Point(533, 261);
            this.ZmienOceneButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZmienOceneButton.Name = "ZmienOceneButton";
            this.ZmienOceneButton.Size = new System.Drawing.Size(125, 50);
            this.ZmienOceneButton.TabIndex = 38;
            this.ZmienOceneButton.Text = "Zmien ocene";
            this.ZmienOceneButton.UseVisualStyleBackColor = false;
            this.ZmienOceneButton.Click += new System.EventHandler(this.ZmienOceneButton_Click);
            // 
            // OcenaLabel
            // 
            this.OcenaLabel.AutoSize = true;
            this.OcenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.OcenaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.OcenaLabel.Location = new System.Drawing.Point(530, 190);
            this.OcenaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OcenaLabel.Name = "OcenaLabel";
            this.OcenaLabel.Size = new System.Drawing.Size(30, 17);
            this.OcenaLabel.TabIndex = 37;
            this.OcenaLabel.Text = "Na:";
            this.OcenaLabel.Click += new System.EventHandler(this.OcenaLabel_Click);
            // 
            // OcenaCombobox
            // 
            this.OcenaCombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.OcenaCombobox.FormattingEnabled = true;
            this.OcenaCombobox.Location = new System.Drawing.Point(533, 208);
            this.OcenaCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.OcenaCombobox.Name = "OcenaCombobox";
            this.OcenaCombobox.Size = new System.Drawing.Size(126, 27);
            this.OcenaCombobox.TabIndex = 35;
            // 
            // ZobaczOcenyButton
            // 
            this.ZobaczOcenyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZobaczOcenyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ZobaczOcenyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZobaczOcenyButton.Location = new System.Drawing.Point(196, 417);
            this.ZobaczOcenyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZobaczOcenyButton.Name = "ZobaczOcenyButton";
            this.ZobaczOcenyButton.Size = new System.Drawing.Size(125, 50);
            this.ZobaczOcenyButton.TabIndex = 32;
            this.ZobaczOcenyButton.Text = "Zobacz Oceny";
            this.ZobaczOcenyButton.UseVisualStyleBackColor = false;
            this.ZobaczOcenyButton.Click += new System.EventHandler(this.ZobaczOcenyButton_Click);
            // 
            // PowrotButton
            // 
            this.PowrotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotButton.Location = new System.Drawing.Point(29, 417);
            this.PowrotButton.Margin = new System.Windows.Forms.Padding(2);
            this.PowrotButton.Name = "PowrotButton";
            this.PowrotButton.Size = new System.Drawing.Size(125, 50);
            this.PowrotButton.TabIndex = 31;
            this.PowrotButton.Text = "Powrot";
            this.PowrotButton.UseVisualStyleBackColor = false;
            this.PowrotButton.Click += new System.EventHandler(this.PowrotButton_Click);
            // 
            // WybStudLabel
            // 
            this.WybStudLabel.AutoSize = true;
            this.WybStudLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.WybStudLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybStudLabel.Location = new System.Drawing.Point(342, 85);
            this.WybStudLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WybStudLabel.Name = "WybStudLabel";
            this.WybStudLabel.Size = new System.Drawing.Size(85, 20);
            this.WybStudLabel.TabIndex = 30;
            this.WybStudLabel.Text = "Lista Ocen:";
            this.WybStudLabel.Click += new System.EventHandler(this.WybStudLabel_Click);
            // 
            // ListaStudLabel
            // 
            this.ListaStudLabel.AutoSize = true;
            this.ListaStudLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.ListaStudLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaStudLabel.Location = new System.Drawing.Point(182, 85);
            this.ListaStudLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListaStudLabel.Name = "ListaStudLabel";
            this.ListaStudLabel.Size = new System.Drawing.Size(125, 20);
            this.ListaStudLabel.TabIndex = 29;
            this.ListaStudLabel.Text = "Lista studentow:";
            this.ListaStudLabel.Click += new System.EventHandler(this.ListaStudLabel_Click);
            // 
            // OcenyListbox
            // 
            this.OcenyListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OcenyListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OcenyListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.OcenyListbox.FormattingEnabled = true;
            this.OcenyListbox.Location = new System.Drawing.Point(346, 108);
            this.OcenyListbox.Margin = new System.Windows.Forms.Padding(2);
            this.OcenyListbox.Name = "OcenyListbox";
            this.OcenyListbox.Size = new System.Drawing.Size(151, 288);
            this.OcenyListbox.TabIndex = 28;
            this.OcenyListbox.SelectedIndexChanged += new System.EventHandler(this.WypStudListbox_SelectedIndexChanged);
            // 
            // ListaStudListbox
            // 
            this.ListaStudListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ListaStudListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaStudListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ListaStudListbox.FormattingEnabled = true;
            this.ListaStudListbox.Location = new System.Drawing.Point(186, 108);
            this.ListaStudListbox.Margin = new System.Windows.Forms.Padding(2);
            this.ListaStudListbox.Name = "ListaStudListbox";
            this.ListaStudListbox.Size = new System.Drawing.Size(145, 288);
            this.ListaStudListbox.TabIndex = 27;
            // 
            // WybGruZatwButton
            // 
            this.WybGruZatwButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WybGruZatwButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WybGruZatwButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybGruZatwButton.Location = new System.Drawing.Point(29, 196);
            this.WybGruZatwButton.Margin = new System.Windows.Forms.Padding(2);
            this.WybGruZatwButton.Name = "WybGruZatwButton";
            this.WybGruZatwButton.Size = new System.Drawing.Size(125, 50);
            this.WybGruZatwButton.TabIndex = 26;
            this.WybGruZatwButton.Text = "Zatwierdz";
            this.WybGruZatwButton.UseVisualStyleBackColor = false;
            this.WybGruZatwButton.Click += new System.EventHandler(this.WybGruZatwButton_Click);
            // 
            // WybGruLabel
            // 
            this.WybGruLabel.AutoSize = true;
            this.WybGruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybGruLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybGruLabel.Location = new System.Drawing.Point(26, 135);
            this.WybGruLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WybGruLabel.Name = "WybGruLabel";
            this.WybGruLabel.Size = new System.Drawing.Size(104, 17);
            this.WybGruLabel.TabIndex = 25;
            this.WybGruLabel.Text = "Wybierz grupe:";
            // 
            // WybGruCombobox
            // 
            this.WybGruCombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybGruCombobox.FormattingEnabled = true;
            this.WybGruCombobox.Location = new System.Drawing.Point(29, 153);
            this.WybGruCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.WybGruCombobox.Name = "WybGruCombobox";
            this.WybGruCombobox.Size = new System.Drawing.Size(126, 27);
            this.WybGruCombobox.TabIndex = 24;
            // 
            // Wybierz
            // 
            this.Wybierz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Wybierz.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Wybierz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.Wybierz.Location = new System.Drawing.Point(360, 417);
            this.Wybierz.Margin = new System.Windows.Forms.Padding(2);
            this.Wybierz.Name = "Wybierz";
            this.Wybierz.Size = new System.Drawing.Size(125, 50);
            this.Wybierz.TabIndex = 39;
            this.Wybierz.Text = "Wybierz Ocene";
            this.Wybierz.UseVisualStyleBackColor = false;
            this.Wybierz.Click += new System.EventHandler(this.Wybierz_Click);
            // 
            // ZmienOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.Wybierz);
            this.Controls.Add(this.ZmienOceneButton);
            this.Controls.Add(this.OcenaLabel);
            this.Controls.Add(this.OcenaCombobox);
            this.Controls.Add(this.ZobaczOcenyButton);
            this.Controls.Add(this.PowrotButton);
            this.Controls.Add(this.WybStudLabel);
            this.Controls.Add(this.ListaStudLabel);
            this.Controls.Add(this.OcenyListbox);
            this.Controls.Add(this.ListaStudListbox);
            this.Controls.Add(this.WybGruZatwButton);
            this.Controls.Add(this.WybGruLabel);
            this.Controls.Add(this.WybGruCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WybranaOcenaListBox);
            this.Controls.Add(this.ZmienOceneHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ZmienOceny";
            this.Text = "Dziekanat";
            this.Load += new System.EventHandler(this.ZmienOceny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZmienOceneHeader;
        private System.Windows.Forms.ListBox WybranaOcenaListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZmienOceneButton;
        private System.Windows.Forms.Label OcenaLabel;
        private System.Windows.Forms.ComboBox OcenaCombobox;
        private System.Windows.Forms.Button ZobaczOcenyButton;
        private System.Windows.Forms.Button PowrotButton;
        private System.Windows.Forms.Label WybStudLabel;
        private System.Windows.Forms.Label ListaStudLabel;
        private System.Windows.Forms.ListBox OcenyListbox;
        private System.Windows.Forms.ListBox ListaStudListbox;
        private System.Windows.Forms.Button WybGruZatwButton;
        private System.Windows.Forms.Label WybGruLabel;
        private System.Windows.Forms.ComboBox WybGruCombobox;
        private System.Windows.Forms.Button Wybierz;
    }
}