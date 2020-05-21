namespace Lab9
{
    partial class EditareMedicament
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
            this.dateTimeExpirare = new System.Windows.Forms.DateTimePicker();
            this.txtbPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDenumireMedicament = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(134, 108);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExpirare.TabIndex = 56;
            // 
            // txtbPret
            // 
            this.txtbPret.Location = new System.Drawing.Point(134, 82);
            this.txtbPret.Name = "txtbPret";
            this.txtbPret.Size = new System.Drawing.Size(100, 20);
            this.txtbPret.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(44, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Data expirarii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(86, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Pret";
            // 
            // lblDenumireMedicament
            // 
            this.lblDenumireMedicament.AutoSize = true;
            this.lblDenumireMedicament.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDenumireMedicament.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDenumireMedicament.Location = new System.Drawing.Point(107, 47);
            this.lblDenumireMedicament.Name = "lblDenumireMedicament";
            this.lblDenumireMedicament.Size = new System.Drawing.Size(0, 13);
            this.lblDenumireMedicament.TabIndex = 58;
            // 
            // EditareMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 277);
            this.Controls.Add(this.lblDenumireMedicament);
            this.Controls.Add(this.dateTimeExpirare);
            this.Controls.Add(this.txtbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "EditareMedicament";
            this.Text = "EditareMedicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeExpirare;
        private System.Windows.Forms.TextBox txtbPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDenumireMedicament;
    }
}