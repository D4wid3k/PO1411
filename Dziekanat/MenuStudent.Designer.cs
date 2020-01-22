namespace Dziekanat
{
    partial class MenuStudent
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
            this.WitajLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            this.WylogujButton = new System.Windows.Forms.Button();
            this.OcenyLabel = new System.Windows.Forms.Button();
            this.PlanLabel = new System.Windows.Forms.Button();
            this.WyslijWniosekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WitajLabel
            // 
            this.WitajLabel.AutoSize = true;
            this.WitajLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.WitajLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WitajLabel.Location = new System.Drawing.Point(161, 42);
            this.WitajLabel.Name = "WitajLabel";
            this.WitajLabel.Size = new System.Drawing.Size(99, 45);
            this.WitajLabel.TabIndex = 0;
            this.WitajLabel.Text = "Witaj";
            this.WitajLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.ImieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ImieLabel.Location = new System.Drawing.Point(246, 42);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(86, 45);
            this.ImieLabel.TabIndex = 1;
            this.ImieLabel.Text = "Imie";
            this.ImieLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // WylogujButton
            // 
            this.WylogujButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WylogujButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WylogujButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WylogujButton.Location = new System.Drawing.Point(325, 446);
            this.WylogujButton.Name = "WylogujButton";
            this.WylogujButton.Size = new System.Drawing.Size(149, 62);
            this.WylogujButton.TabIndex = 2;
            this.WylogujButton.Text = "Wyloguj";
            this.WylogujButton.UseVisualStyleBackColor = false;
            // 
            // OcenyLabel
            // 
            this.OcenyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OcenyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.OcenyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.OcenyLabel.Location = new System.Drawing.Point(169, 167);
            this.OcenyLabel.Name = "OcenyLabel";
            this.OcenyLabel.Size = new System.Drawing.Size(149, 62);
            this.OcenyLabel.TabIndex = 3;
            this.OcenyLabel.Text = "Oceny";
            this.OcenyLabel.UseVisualStyleBackColor = false;
            // 
            // PlanLabel
            // 
            this.PlanLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PlanLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PlanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.PlanLabel.Location = new System.Drawing.Point(169, 235);
            this.PlanLabel.Name = "PlanLabel";
            this.PlanLabel.Size = new System.Drawing.Size(149, 62);
            this.PlanLabel.TabIndex = 4;
            this.PlanLabel.Text = "Plan";
            this.PlanLabel.UseVisualStyleBackColor = false;
            // 
            // WyslijWniosekButton
            // 
            this.WyslijWniosekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.WyslijWniosekButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.WyslijWniosekButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.WyslijWniosekButton.Location = new System.Drawing.Point(169, 303);
            this.WyslijWniosekButton.Name = "WyslijWniosekButton";
            this.WyslijWniosekButton.Size = new System.Drawing.Size(149, 62);
            this.WyslijWniosekButton.TabIndex = 5;
            this.WyslijWniosekButton.Text = "Wyslij Wniosek";
            this.WyslijWniosekButton.UseVisualStyleBackColor = false;
            // 
            // MenuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(486, 520);
            this.Controls.Add(this.WyslijWniosekButton);
            this.Controls.Add(this.PlanLabel);
            this.Controls.Add(this.OcenyLabel);
            this.Controls.Add(this.WylogujButton);
            this.Controls.Add(this.ImieLabel);
            this.Controls.Add(this.WitajLabel);
            this.Name = "MenuStudent";
            this.Text = "Dziekanat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WitajLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Button WylogujButton;
        private System.Windows.Forms.Button OcenyLabel;
        private System.Windows.Forms.Button PlanLabel;
        private System.Windows.Forms.Button WyslijWniosekButton;
    }
}