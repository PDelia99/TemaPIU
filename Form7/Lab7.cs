//Student: Delia Polocoser
//Grupa: 3123b
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemaLaboratoare;

namespace Form7
{
    public partial class Lab7 : Form
    {
        Farmacie lab7Farm = new Farmacie();

        public Lab7()
        {
            InitializeComponent();
            lab7Farm.Nume = "Catena";
            lab7Farm.Medicamente = new List<Medicament>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            CodEroare var = Validare(txtbID.Text, txtbDenumire.Text, txtbPret.Text, dateTimeExpirare.Value);

            if (var != CodEroare.CORECT)
            {
                richtxtbConsola.Text = $"{var}";
            }
            else
            {
                Medicament med = new Medicament();
                med.ID = Convert.ToDouble(txtbID.Text);
                med.Denumire = txtbDenumire.Text;
                med.Pret = float.Parse(txtbPret.Text);
                med.DataExpirare = dateTimeExpirare.Value;

                lab7Farm.Medicamente.Add(med);

                richtxtbConsola.Text = $"Adaugat cu succesin farmacia {lab7Farm.Nume}";

            }
        }

        private CodEroare Validare(string ID, string denumire, string pret, DateTime dataExpirare)
        {
            if (ID == string.Empty)
            {
                return CodEroare.ID_INCORECT;
            }
            if (denumire == string.Empty)
            {
                return CodEroare.Denumire_INCORECTA;
            }
            if (pret == string.Empty)
            {
                return CodEroare.Pret_INCORECT;
            }
            if (dataExpirare <= DateTime.Today || dataExpirare == null)
            {
                return CodEroare.Data_INCORECTA;
            }

            return CodEroare.CORECT;
        }


        private void btnCauta_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            var gasit = 0;
            foreach (var item in lab7Farm.Medicamente)
            {

                if (item.Denumire == txtbDenumire.Text && item.ID == Convert.ToDouble(txtbID.Text) && item.DataExpirare == dateTimeExpirare.Value)
                {
                    richtxtbConsola.Text = $"Medicamentul {item.Denumire} a fost gasit si are idul {item.ID} si pretul {item.Pret}";
                    gasit = 1;
                }
            }
            if (gasit == 0)
            {
                richtxtbConsola.Text = $"Medicamentul {txtbDenumire.Text}  nu a fost gasit in farmacie";
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            foreach (var item in lab7Farm.Medicamente)
            {
                richtxtbConsola.Text += $"{item.Denumire} {item.Pret} {item.DataExpirare}\n";
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            var gasit = 0;
            foreach (var item in lab7Farm.Medicamente)
            {
                if (item.ID == Convert.ToDouble(txtbID.Text))
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    gasit = 1;
                }
            }
            if (gasit == 0)
            {
                richtxtbConsola.Text = "Pretul nu a fost modificat!";
            }
            else
                richtxtbConsola.Text = "Pretul a fost modificat cu succes!";
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            Medicament med = new Medicament();
            med.ZileRamase = (dateTimeExpirare.Value - DateTime.Today).TotalDays;

            richtxtbConsola.Text = $"Zile pana la expirare {med.ZileRamase}";
        }

    }
}
