namespace Form8
{
    partial class Lab8Form
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
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
            this.radbutParacetamol = new System.Windows.Forms.RadioButton();
            this.radbutNurofen = new System.Windows.Forms.RadioButton();
            this.radbutTatum = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbCatena = new System.Windows.Forms.CheckBox();
            this.checkbSensiblue = new System.Windows.Forms.CheckBox();
            this.checkbPharmaplus = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(232, 198);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(95, 30);
            this.btnModifica.TabIndex = 36;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfisare.Location = new System.Drawing.Point(119, 198);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(95, 30);
            this.btnAfisare.TabIndex = 35;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(232, 140);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(88, 30);
            this.btnCauta.TabIndex = 34;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(119, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 30);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dateTimeExpirare
            // 
            this.dateTimeExpirare.Location = new System.Drawing.Point(107, 114);
            this.dateTimeExpirare.Name = "dateTimeExpirare";
            this.dateTimeExpirare.Size = new System.Drawing.Size(200, 20);
            this.dateTimeExpirare.TabIndex = 32;
            // 
            // txtbPret
            // 
            this.txtbPret.Location = new System.Drawing.Point(107, 86);
            this.txtbPret.Name = "txtbPret";
            this.txtbPret.Size = new System.Drawing.Size(100, 20);
            this.txtbPret.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(17, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data expirarii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Denumire";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(107, 33);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(100, 20);
            this.txtbID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pret";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID";
            // 
            // richtxtbConsola
            // 
            this.richtxtbConsola.Location = new System.Drawing.Point(369, 9);
            this.richtxtbConsola.Name = "richtxtbConsola";
            this.richtxtbConsola.Size = new System.Drawing.Size(350, 271);
            this.richtxtbConsola.TabIndex = 24;
            this.richtxtbConsola.Text = "";
            // 
            // radbutParacetamol
            // 
            this.radbutParacetamol.AutoSize = true;
            this.radbutParacetamol.Location = new System.Drawing.Point(107, 63);
            this.radbutParacetamol.Name = "radbutParacetamol";
            this.radbutParacetamol.Size = new System.Drawing.Size(84, 17);
            this.radbutParacetamol.TabIndex = 38;
            this.radbutParacetamol.TabStop = true;
            this.radbutParacetamol.Text = "Paracetamol";
            this.radbutParacetamol.UseVisualStyleBackColor = true;
            // 
            // radbutNurofen
            // 
            this.radbutNurofen.AutoSize = true;
            this.radbutNurofen.Location = new System.Drawing.Point(193, 63);
            this.radbutNurofen.Name = "radbutNurofen";
            this.radbutNurofen.Size = new System.Drawing.Size(63, 17);
            this.radbutNurofen.TabIndex = 39;
            this.radbutNurofen.TabStop = true;
            this.radbutNurofen.Text = "Nurofen";
            this.radbutNurofen.UseVisualStyleBackColor = true;
            // 
            // radbutTatum
            // 
            this.radbutTatum.AutoSize = true;
            this.radbutTatum.Location = new System.Drawing.Point(262, 63);
            this.radbutTatum.Name = "radbutTatum";
            this.radbutTatum.Size = new System.Drawing.Size(85, 17);
            this.radbutTatum.TabIndex = 40;
            this.radbutTatum.TabStop = true;
            this.radbutTatum.Text = "Tatum verde";
            this.radbutTatum.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Farmacia";
            // 
            // checkbCatena
            // 
            this.checkbCatena.AutoSize = true;
            this.checkbCatena.Location = new System.Drawing.Point(107, 4);
            this.checkbCatena.Name = "checkbCatena";
            this.checkbCatena.Size = new System.Drawing.Size(60, 17);
            this.checkbCatena.TabIndex = 42;
            this.checkbCatena.Text = "Catena";
            this.checkbCatena.UseVisualStyleBackColor = true;
            this.checkbCatena.CheckedChanged += new System.EventHandler(this.checkFarmacie_CheckedChanged);
            // 
            // checkbSensiblue
            // 
            this.checkbSensiblue.AutoSize = true;
            this.checkbSensiblue.Location = new System.Drawing.Point(173, 4);
            this.checkbSensiblue.Name = "checkbSensiblue";
            this.checkbSensiblue.Size = new System.Drawing.Size(72, 17);
            this.checkbSensiblue.TabIndex = 43;
            this.checkbSensiblue.Text = "Sensiblue";
            this.checkbSensiblue.UseVisualStyleBackColor = true;
            this.checkbSensiblue.CheckedChanged += new System.EventHandler(this.checkFarmacie_CheckedChanged);
            // 
            // checkbPharmaplus
            // 
            this.checkbPharmaplus.AutoSize = true;
            this.checkbPharmaplus.Location = new System.Drawing.Point(248, 4);
            this.checkbPharmaplus.Name = "checkbPharmaplus";
            this.checkbPharmaplus.Size = new System.Drawing.Size(81, 17);
            this.checkbPharmaplus.TabIndex = 44;
            this.checkbPharmaplus.Text = "Pharmaplus";
            this.checkbPharmaplus.UseVisualStyleBackColor = true;
            this.checkbPharmaplus.CheckedChanged += new System.EventHandler(this.checkFarmacie_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 176);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 45;
            // 
            // Lab8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 292);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkbPharmaplus);
            this.Controls.Add(this.checkbSensiblue);
            this.Controls.Add(this.checkbCatena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radbutTatum);
            this.Controls.Add(this.radbutNurofen);
            this.Controls.Add(this.radbutParacetamol);
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
            this.Name = "Lab8Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.RadioButton radbutParacetamol;
        private System.Windows.Forms.RadioButton radbutNurofen;
        private System.Windows.Forms.RadioButton radbutTatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkbCatena;
        private System.Windows.Forms.CheckBox checkbSensiblue;
        private System.Windows.Forms.CheckBox checkbPharmaplus;
        private System.Windows.Forms.TreeView treeView1;
    }
}

