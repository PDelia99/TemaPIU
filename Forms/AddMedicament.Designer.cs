namespace Forms
{
    partial class AddMedicament
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDenumire = new System.Windows.Forms.TextBox();
            this.txtbPret = new System.Windows.Forms.TextBox();
            this.dateTimeExpirare = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRezAdd = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pret";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(190, 34);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Denumire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data expirarii";
            // 
            // txtbDenumire
            // 
            this.txtbDenumire.Location = new System.Drawing.Point(190, 61);
            this.txtbDenumire.Name = "txtbDenumire";
            this.txtbDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtbDenumire.TabIndex = 5;
            this.txtbDenumire.TextChanged += new System.EventHandler(this.txtbDenumire_TextChanged);
            // 
            // txtbPret
            // 
            this.txtbPret.Location = new System.Drawing.Point(190, 87);
            this.txtbPret.Name = "txtbPret";
            this.txtbPret.Size = new System.Drawing.Size(100, 20);
            this.txtbPret.TabIndex = 6;
            this.txtbPret.TextChanged += new System.EventHandler(this.txtbPret_TextChanged);
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(190, 115);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExpirare.TabIndex = 7;
            this.dateTimeExpirare.ValueChanged += new System.EventHandler(this.dateTimeExpirare_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(190, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRezAdd
            // 
            this.lblRezAdd.AutoSize = true;
            this.lblRezAdd.Location = new System.Drawing.Point(29, 207);
            this.lblRezAdd.Name = "lblRezAdd";
            this.lblRezAdd.Size = new System.Drawing.Size(0, 13);
            this.lblRezAdd.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 202);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // AddMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(463, 247);
            this.Controls.Add(this.lblRezAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimeExpirare);
            this.Controls.Add(this.txtbPret);
            this.Controls.Add(this.txtbDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddMedicament";
            this.Text = "Afiseaza medicament introdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDenumire;
        private System.Windows.Forms.TextBox txtbPret;
        private System.Windows.Forms.DateTimePicker dateTimeExpirare;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRezAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}