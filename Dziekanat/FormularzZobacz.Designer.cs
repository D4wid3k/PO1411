namespace Dziekanat
{
    partial class FormularzZobacz
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
            this.KierListbox = new System.Windows.Forms.ListBox();
            this.ZaakceptujButton = new System.Windows.Forms.Button();
            this.OdrzucButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KierListbox
            // 
            this.KierListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.KierListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KierListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.KierListbox.FormattingEnabled = true;
            this.KierListbox.ItemHeight = 36;
            this.KierListbox.Location = new System.Drawing.Point(14, 15);
            this.KierListbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.KierListbox.Name = "KierListbox";
            this.KierListbox.Size = new System.Drawing.Size(390, 398);
            this.KierListbox.TabIndex = 8;
            // 
            // ZaakceptujButton
            // 
            this.ZaakceptujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ZaakceptujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.ZaakceptujButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ZaakceptujButton.Location = new System.Drawing.Point(14, 421);
            this.ZaakceptujButton.Margin = new System.Windows.Forms.Padding(2);
            this.ZaakceptujButton.Name = "ZaakceptujButton";
            this.ZaakceptujButton.Size = new System.Drawing.Size(189, 50);
            this.ZaakceptujButton.TabIndex = 15;
            this.ZaakceptujButton.Text = "Zaakceptuj";
            this.ZaakceptujButton.UseVisualStyleBackColor = false;
            this.ZaakceptujButton.Click += new System.EventHandler(this.ZaakceptujButton_Click);
            // 
            // OdrzucButton
            // 
            this.OdrzucButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OdrzucButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.OdrzucButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.OdrzucButton.Location = new System.Drawing.Point(215, 421);
            this.OdrzucButton.Margin = new System.Windows.Forms.Padding(2);
            this.OdrzucButton.Name = "OdrzucButton";
            this.OdrzucButton.Size = new System.Drawing.Size(189, 50);
            this.OdrzucButton.TabIndex = 16;
            this.OdrzucButton.Text = "Odrzuć";
            this.OdrzucButton.UseVisualStyleBackColor = false;
            // 
            // FormularzZobacz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(418, 506);
            this.Controls.Add(this.OdrzucButton);
            this.Controls.Add(this.ZaakceptujButton);
            this.Controls.Add(this.KierListbox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FormularzZobacz";
            this.Text = "Wniosek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox KierListbox;
        private System.Windows.Forms.Button ZaakceptujButton;
        private System.Windows.Forms.Button OdrzucButton;
    }
}