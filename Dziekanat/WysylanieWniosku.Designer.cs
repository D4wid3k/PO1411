namespace Dziekanat
{
    partial class WysylanieWniosku
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
            this.WyslijWniosekLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PoleTekstRichTextbox = new System.Windows.Forms.Label();
            this.PowrotButton = new System.Windows.Forms.Button();
            this.Wyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WyslijWniosekLabel
            // 
            this.WyslijWniosekLabel.AutoSize = true;
            this.WyslijWniosekLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.WyslijWniosekLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WyslijWniosekLabel.Location = new System.Drawing.Point(22, 24);
            this.WyslijWniosekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WyslijWniosekLabel.Name = "WyslijWniosekLabel";
            this.WyslijWniosekLabel.Size = new System.Drawing.Size(196, 37);
            this.WyslijWniosekLabel.TabIndex = 4;
            this.WyslijWniosekLabel.Text = "Wyslij wniosek";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 122);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(372, 244);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // PoleTekstRichTextbox
            // 
            this.PoleTekstRichTextbox.AutoSize = true;
            this.PoleTekstRichTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.PoleTekstRichTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PoleTekstRichTextbox.Location = new System.Drawing.Point(28, 101);
            this.PoleTekstRichTextbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PoleTekstRichTextbox.Name = "PoleTekstRichTextbox";
            this.PoleTekstRichTextbox.Size = new System.Drawing.Size(249, 19);
            this.PoleTekstRichTextbox.TabIndex = 6;
            this.PoleTekstRichTextbox.Text = "Pole tekstowe do utworzenia wniosku:";
            // 
            // PowrotButton
            // 
            this.PowrotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PowrotButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PowrotButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PowrotButton.Location = new System.Drawing.Point(317, 431);
            this.PowrotButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PowrotButton.Name = "PowrotButton";
            this.PowrotButton.Size = new System.Drawing.Size(112, 50);
            this.PowrotButton.TabIndex = 15;
            this.PowrotButton.Text = "Powrot";
            this.PowrotButton.UseVisualStyleBackColor = false;
            this.PowrotButton.Click += new System.EventHandler(this.PowrotButton_Click);
            // 
            // Wyslij
            // 
            this.Wyslij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Wyslij.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Wyslij.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.Wyslij.Location = new System.Drawing.Point(156, 370);
            this.Wyslij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Wyslij.Name = "Wyslij";
            this.Wyslij.Size = new System.Drawing.Size(112, 50);
            this.Wyslij.TabIndex = 16;
            this.Wyslij.Text = "Wyslij";
            this.Wyslij.UseVisualStyleBackColor = false;
            this.Wyslij.Click += new System.EventHandler(this.Wyslij_Click);
            // 
            // WysylanieWniosku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(438, 491);
            this.Controls.Add(this.Wyslij);
            this.Controls.Add(this.PowrotButton);
            this.Controls.Add(this.PoleTekstRichTextbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.WyslijWniosekLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WysylanieWniosku";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WyslijWniosekLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label PoleTekstRichTextbox;
        private System.Windows.Forms.Button PowrotButton;
        private System.Windows.Forms.Button Wyslij;
    }
}