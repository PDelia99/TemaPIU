namespace Form7
{
    partial class Lab7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab7));
            this.richtxtbConsola = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimeExpirare = new System.Windows.Forms.DateTimePicker();
            this.txtbPret = new System.Windows.Forms.TextBox();
            this.txtbDenumire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // richtxtbConsola
            // 
            this.richtxtbConsola.Location = new System.Drawing.Point(455, 24);
            this.richtxtbConsola.Name = "richtxtbConsola";
            this.richtxtbConsola.Size = new System.Drawing.Size(327, 230);
            this.richtxtbConsola.TabIndex = 2;
            this.richtxtbConsola.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(182, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(170, 109);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExpirare.TabIndex = 18;
            // 
            // txtbPret
            // 
            this.txtbPret.Location = new System.Drawing.Point(170, 81);
            this.txtbPret.Name = "txtbPret";
            this.txtbPret.Size = new System.Drawing.Size(100, 20);
            this.txtbPret.TabIndex = 17;
            // 
            // txtbDenumire
            // 
            this.txtbDenumire.Location = new System.Drawing.Point(170, 55);
            this.txtbDenumire.Name = "txtbDenumire";
            this.txtbDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtbDenumire.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(80, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data expirarii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(96, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Denumire";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(170, 28);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(122, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(295, 135);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(88, 30);
            this.btnCauta.TabIndex = 20;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(182, 193);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(95, 30);
            this.btnAfisare.TabIndex = 21;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(295, 193);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(95, 30);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeaza.Location = new System.Drawing.Point(219, 229);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(121, 30);
            this.btnCalculeaza.TabIndex = 23;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.DarkRed;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 256);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 281);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimeExpirare);
            this.Controls.Add(this.txtbPret);
            this.Controls.Add(this.txtbDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtbConsola);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Lab7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richtxtbConsola;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimeExpirare;
        private System.Windows.Forms.TextBox txtbPret;
        private System.Windows.Forms.TextBox txtbDenumire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

