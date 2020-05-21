namespace Lab9
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimeExpirare = new System.Windows.Forms.DateTimePicker();
            this.txtbPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtbConsola = new System.Windows.Forms.RichTextBox();
            this.lbFarmacii = new System.Windows.Forms.ListBox();
            this.cbDenumire = new System.Windows.Forms.ComboBox();
            this.btnCautaDupa = new System.Windows.Forms.Button();
            this.dateTimeInterval2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInterval1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridCautare = new System.Windows.Forms.DataGridView();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataActualizare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataExpirare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCautare)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(67, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Farmacia";
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(252, 217);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(95, 30);
            this.btnModifica.TabIndex = 56;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(139, 217);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(95, 30);
            this.btnAfisare.TabIndex = 55;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(251, 172);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(88, 30);
            this.btnCauta.TabIndex = 54;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(139, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(139, 146);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExpirare.TabIndex = 52;
            // 
            // txtbPret
            // 
            this.txtbPret.Location = new System.Drawing.Point(139, 120);
            this.txtbPret.Name = "txtbPret";
            this.txtbPret.Size = new System.Drawing.Size(100, 20);
            this.txtbPret.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(49, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Data expirarii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(65, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Denumire";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(139, 67);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(91, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Pret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(99, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID";
            // 
            // richtxtbConsola
            // 
            this.richtxtbConsola.Location = new System.Drawing.Point(409, 18);
            this.richtxtbConsola.Name = "richtxtbConsola";
            this.richtxtbConsola.Size = new System.Drawing.Size(443, 69);
            this.richtxtbConsola.TabIndex = 45;
            this.richtxtbConsola.Text = "";
            // 
            // lbFarmacii
            // 
            this.lbFarmacii.FormattingEnabled = true;
            this.lbFarmacii.Items.AddRange(new object[] {
            "Catena",
            "Sensiblue",
            "Pharmaplus"});
            this.lbFarmacii.Location = new System.Drawing.Point(139, 18);
            this.lbFarmacii.Name = "lbFarmacii";
            this.lbFarmacii.Size = new System.Drawing.Size(120, 43);
            this.lbFarmacii.TabIndex = 64;
            // 
            // cbDenumire
            // 
            this.cbDenumire.FormattingEnabled = true;
            this.cbDenumire.Items.AddRange(new object[] {
            "Paracetamol",
            "Nurofen",
            "Tatum verde"});
            this.cbDenumire.Location = new System.Drawing.Point(139, 93);
            this.cbDenumire.Name = "cbDenumire";
            this.cbDenumire.Size = new System.Drawing.Size(121, 21);
            this.cbDenumire.TabIndex = 65;
            // 
            // btnCautaDupa
            // 
            this.btnCautaDupa.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaDupa.Location = new System.Drawing.Point(409, 243);
            this.btnCautaDupa.Name = "btnCautaDupa";
            this.btnCautaDupa.Size = new System.Drawing.Size(196, 63);
            this.btnCautaDupa.TabIndex = 66;
            this.btnCautaDupa.Text = "Cauta dupa intervalul selectat";
            this.btnCautaDupa.UseVisualStyleBackColor = true;
            this.btnCautaDupa.Click += new System.EventHandler(this.btnCautaDupa_Click);
            // 
            // dateTimeInterval2
            // 
            this.dateTimeInterval2.Location = new System.Drawing.Point(139, 288);
            this.dateTimeInterval2.Name = "dateTimeInterval2";
            this.dateTimeInterval2.Size = new System.Drawing.Size(200, 20);
            this.dateTimeInterval2.TabIndex = 67;
            // 
            // dateTimeInterval1
            // 
            this.dateTimeInterval1.Location = new System.Drawing.Point(139, 262);
            this.dateTimeInterval1.Name = "dateTimeInterval1";
            this.dateTimeInterval1.Size = new System.Drawing.Size(200, 20);
            this.dateTimeInterval1.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(49, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "La data de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(49, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "De la data de";
            // 
            // dataGridCautare
            // 
            this.dataGridCautare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCautare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denumire,
            this.DataActualizare,
            this.Pret,
            this.DataExpirare});
            this.dataGridCautare.Location = new System.Drawing.Point(409, 97);
            this.dataGridCautare.Name = "dataGridCautare";
            this.dataGridCautare.Size = new System.Drawing.Size(443, 123);
            this.dataGridCautare.TabIndex = 71;
            // 
            // Denumire
            // 
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.Name = "Denumire";
            // 
            // DataActualizare
            // 
            this.DataActualizare.HeaderText = "Data la care a fost introdus";
            this.DataActualizare.Name = "DataActualizare";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // DataExpirare
            // 
            this.DataExpirare.HeaderText = "Data Expirare";
            this.DataExpirare.Name = "DataExpirare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 315);
            this.Controls.Add(this.dataGridCautare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeInterval1);
            this.Controls.Add(this.dateTimeInterval2);
            this.Controls.Add(this.btnCautaDupa);
            this.Controls.Add(this.cbDenumire);
            this.Controls.Add(this.lbFarmacii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimeExpirare);
            this.Controls.Add(this.txtbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtbConsola);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCautare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimeExpirare;
        private System.Windows.Forms.TextBox txtbPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtxtbConsola;
        private System.Windows.Forms.ListBox lbFarmacii;
        private System.Windows.Forms.ComboBox cbDenumire;
        private System.Windows.Forms.Button btnCautaDupa;
        private System.Windows.Forms.DateTimePicker dateTimeInterval2;
        private System.Windows.Forms.DateTimePicker dateTimeInterval1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridCautare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataActualizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataExpirare;
    }
}

