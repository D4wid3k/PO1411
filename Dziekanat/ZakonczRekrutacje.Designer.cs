namespace Dziekanat
{
    partial class ZakonczRekrutacje
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
            this.RekrutacjaButton = new System.Windows.Forms.Button();
            this.KierunkiCombobox = new System.Windows.Forms.ListBox();
            this.ZakwalifikowaniListBox = new System.Windows.Forms.ListBox();
            this.WybranyKieunekLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RekrutacjaButton
            // 
            this.RekrutacjaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RekrutacjaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.RekrutacjaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.RekrutacjaButton.Location = new System.Drawing.Point(478, 400);
            this.RekrutacjaButton.Margin = new System.Windows.Forms.Padding(2);
            this.RekrutacjaButton.Name = "RekrutacjaButton";
            this.RekrutacjaButton.Size = new System.Drawing.Size(199, 50);
            this.RekrutacjaButton.TabIndex = 14;
            this.RekrutacjaButton.Text = "Zakoncz rekrutacje";
            this.RekrutacjaButton.UseVisualStyleBackColor = false;
            this.RekrutacjaButton.Click += new System.EventHandler(this.RekrutacjaButton_Click);
            // 
            // KierunkiCombobox
            // 
            this.KierunkiCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.KierunkiCombobox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KierunkiCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.KierunkiCombobox.FormattingEnabled = true;
            this.KierunkiCombobox.ItemHeight = 19;
            this.KierunkiCombobox.Location = new System.Drawing.Point(11, 11);
            this.KierunkiCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.KierunkiCombobox.Name = "KierunkiCombobox";
            this.KierunkiCombobox.Size = new System.Drawing.Size(207, 439);
            this.KierunkiCombobox.TabIndex = 15;
            // 
            // ZakwalifikowaniListBox
            // 
            this.ZakwalifikowaniListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZakwalifikowaniListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZakwalifikowaniListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZakwalifikowaniListBox.FormattingEnabled = true;
            this.ZakwalifikowaniListBox.ItemHeight = 19;
            this.ZakwalifikowaniListBox.Location = new System.Drawing.Point(248, 68);
            this.ZakwalifikowaniListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ZakwalifikowaniListBox.Name = "ZakwalifikowaniListBox";
            this.ZakwalifikowaniListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ZakwalifikowaniListBox.Size = new System.Drawing.Size(207, 382);
            this.ZakwalifikowaniListBox.TabIndex = 16;
            // 
            // WybranyKieunekLabel
            // 
            this.WybranyKieunekLabel.AutoSize = true;
            this.WybranyKieunekLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.WybranyKieunekLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WybranyKieunekLabel.Location = new System.Drawing.Point(244, 11);
            this.WybranyKieunekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WybranyKieunekLabel.Name = "WybranyKieunekLabel";
            this.WybranyKieunekLabel.Size = new System.Drawing.Size(242, 37);
            this.WybranyKieunekLabel.TabIndex = 17;
            this.WybranyKieunekLabel.Text = "Wybierz kierunek";
            // 
            // ZakonczRekrutacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(696, 461);
            this.Controls.Add(this.WybranyKieunekLabel);
            this.Controls.Add(this.ZakwalifikowaniListBox);
            this.Controls.Add(this.KierunkiCombobox);
            this.Controls.Add(this.RekrutacjaButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ZakonczRekrutacje";
            this.Text = "Zakoncz Rekrutacje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RekrutacjaButton;
        private System.Windows.Forms.ListBox KierunkiCombobox;
        private System.Windows.Forms.ListBox ZakwalifikowaniListBox;
        private System.Windows.Forms.Label WybranyKieunekLabel;
    }
}