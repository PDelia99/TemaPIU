using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemaLaboratoare;

namespace Lab9
{
    public partial class Form1 : Form
    {
        Farmacie Catena = new Farmacie();
        Farmacie Sensiblue = new Farmacie();
        Farmacie Pharmaplus = new Farmacie();
        public Form1()
        {
            InitializeComponent();

            Catena.Nume = "Catena";
            Catena.Medicamente = new List<Medicament>();

            Sensiblue.Nume = "Sensiblue";
            Sensiblue.Medicamente = new List<Medicament>();

            Pharmaplus.Nume = "Pharmaplus";
            Pharmaplus.Medicamente = new List<Medicament>();
        }

        private CodEroare Validare(string ID, string pret, DateTime dataExpirare)
        {
            if (ID == string.Empty)
            {
                return CodEroare.ID_INCORECT;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CodEroare var = Validare(txtbID.Text, txtbPret.Text, dateTimeExpirare.Value);

            if (var != CodEroare.CORECT)
            {
                richtxtbConsola.Text = $"{var}";
            }
            else
            {
                Medicament med = new Medicament();
                med.ID = Convert.ToDouble(txtbID.Text);
                med.Pret = float.Parse(txtbPret.Text);
                med.DataExpirare = dateTimeExpirare.Value;
                med.Denumire = cbDenumire.GetItemText(cbDenumire.SelectedItem);
                med.DataActualizare = DateTime.Today.AddDays(-77);

                var farmacieAleasa = lbFarmacii.GetItemText(lbFarmacii.SelectedItem);

                if (farmacieAleasa == Catena.Nume)
                {
                    Catena.Medicamente.Add(med);
                }
                else if (farmacieAleasa == Sensiblue.Nume)
                {
                    Sensiblue.Medicamente.Add(med);
                }
                else if (farmacieAleasa == Pharmaplus.Nume)
                {
                    Pharmaplus.Medicamente.Add(med);
                }
                else
                {
                    richtxtbConsola.Text = "Trebuie selectata o farmacie!";
                    return;
                }
                richtxtbConsola.Text = "Medicamentul a fost adaugat cu succes!";

            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            if (Catena.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "In farmacia Catena sunt medicamentele \n";
                foreach (var item in Catena.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret}, a fost adaugat la data {item.DataActualizare} si expira la {item.DataExpirare}\n";
                }
            }

            if (Sensiblue.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "\nIn farmacia Sensiblue sunt medicamentele \n";
                foreach (var item in Sensiblue.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret}, a fost adaugat la data {item.DataActualizare} si expira la {item.DataExpirare}\n";
                }
            }

            if (Pharmaplus.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "\nIn farmacia Pharmaplus sunt medicamentele \n";
                foreach (var item in Pharmaplus.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret}, a fost adaugat la data {item.DataActualizare} si expira la {item.DataExpirare}\n";
                }
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            PrepareForSearch();
            richtxtbConsola.Clear();
            var medSelectat = cbDenumire.GetItemText(cbDenumire.SelectedItem);

            if (medSelectat == null)
            {
                richtxtbConsola.Text = "Trebuie selectat un medicament";
                return;
            }

            richtxtbConsola.Text += $"Medicamentul {medSelectat} a fost gasit in \n";
            foreach (var item in Catena.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    richtxtbConsola.Text += $"{Catena.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";

                }
            }

            foreach (var item in Sensiblue.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    richtxtbConsola.Text += $"{Sensiblue.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";

                }
            }
            foreach (var item in Pharmaplus.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    richtxtbConsola.Text += $"{Pharmaplus.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";

                }
            }
        }
        private void PrepareForSearch()
        {

            lbFarmacii.ClearSelected();

            txtbID.Text = string.Empty;
            txtbPret.Text = string.Empty;

            dateTimeExpirare.Value = DateTime.Today;

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            var medSelectat = cbDenumire.GetItemText(cbDenumire.SelectedItem);

            if (medSelectat == null)
            {
                richtxtbConsola.Text = "Trebuie selectat un medicament";
                return;
            }

            EditareMedicament formaEditare = new EditareMedicament(medSelectat, txtbPret.Text, dateTimeExpirare.Value);
            formaEditare.Show();

            foreach (var item in Catena.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                    item.DataActualizare = DateTime.Now;
                }
            }
            foreach (var item in Sensiblue.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                    item.DataActualizare = DateTime.Now;
                }
            }
            foreach (var item in Pharmaplus.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                    item.DataActualizare = DateTime.Now;
                }
            }

            richtxtbConsola.Text = $"Medicamentul cu denumirea {medSelectat} a fost modificat cu succes!";
        }

        private void btnCautaDupa_Click(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
            foreach (var item in Catena.Medicamente)
            {
                if (item.DataActualizare.Date >= dateTimeInterval1.Value.Date && item.DataActualizare.Date <= dateTimeInterval2.Value.Date)
                {
                    richtxtbConsola.Text += $"{Catena.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                    dataGridCautare.Rows.Add(item.Denumire, item.DataActualizare, item.Pret, item.DataExpirare);
                }
            }

            foreach (var item in Sensiblue.Medicamente)
            {
                if (item.DataActualizare.Date >= dateTimeInterval1.Value.Date && item.DataActualizare.Date <= dateTimeInterval2.Value.Date)
                {
                    richtxtbConsola.Text += $"{Sensiblue.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                    dataGridCautare.Rows.Add(item.Denumire, item.DataActualizare, item.Pret, item.DataExpirare);
                }
            }
            foreach (var item in Pharmaplus.Medicamente)
            {
                if (item.DataActualizare.Date >= dateTimeInterval1.Value.Date && item.DataActualizare.Date <= dateTimeInterval2.Value.Date)
                {
                    richtxtbConsola.Text += $"{Pharmaplus.Nume}: cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                    dataGridCautare.Rows.Add(item.Denumire, item.DataActualizare, item.Pret, item.DataExpirare);
                }
            }
        }
    }
}
