//Student: Delia Polocoser
//Grupa: 3123b
using System;
using NivelStocareDate;
using System.Windows.Forms;
using TemaLaboratoare;
using NivelAccesDate;
using InterfataUtilizator;

namespace Forms
{
    public partial class AddMedicament : Form
    {
        IStocareData adminStudenti;

        public AddMedicament()
        {
            InitializeComponent();
            adminStudenti = StocareFactory.GetAdministratorStocare();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Medicament med = new Medicament();
            med.ID = Convert.ToDouble(txtbID.Text);
            med.Denumire = txtbDenumire.Text;
            med.Pret = float.Parse(txtbPret.Text);
            med.DataExpirare = dateTimeExpirare.Value;

            lblRezAdd.Text = med.ConversieLaSir();

            adminStudenti.AddStudent(med);
        }

        private void txtbDenumire_TextChanged(object sender, EventArgs e)
        {
            if (txtbDenumire.TextLength >= 20)
            {
                btnAdd.Enabled = false;
                lblRezAdd.Text = "eroare denumire";
            }
            else
            {
                btnAdd.Enabled = true;
                lblRezAdd.Text = "";
            }
        }

        private void txtbPret_TextChanged(object sender, EventArgs e)
        {
            float value = float.Parse(txtbPret.Text);
            if (value < 0 || value >= 1000)
            {
                btnAdd.Enabled = false;
                lblRezAdd.Text = "eroare pret";
            }
            else
            {
                btnAdd.Enabled = true;
                lblRezAdd.Text = "";
            }
        }

        private void dateTimeExpirare_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeExpirare.Value < DateTime.Today)
            {
                btnAdd.Enabled = false;
                lblRezAdd.Text = "eroare data expirare";
            }
            else
            {
                btnAdd.Enabled = true;
                lblRezAdd.Text = "";
            }
        }
    }
}
