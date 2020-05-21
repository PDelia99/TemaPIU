using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TemaLaboratoare;


namespace Form8
{
    public partial class Lab8Form : Form
    {
        Farmacie Catena = new Farmacie();
        Farmacie Sensiblue = new Farmacie();
        Farmacie Pharmaplus = new Farmacie();
        ArrayList FarmaciiSelectate = new ArrayList();

        public Lab8Form()
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            richtxtbConsola.Clear();
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

                if (radbutParacetamol.Checked)
                {
                    med.Denumire = denumire.Paracetamol.ToString();
                }
                else if (radbutNurofen.Checked)
                {
                    med.Denumire = denumire.Nurofen.ToString();
                }
                else if (radbutTatum.Checked)
                {
                    med.Denumire = denumire.TatumVerde.ToString();
                }
                else
                {
                    richtxtbConsola.Text = "Trebuie selectat un medicament!";
                    return;
                }

                richtxtbConsola.Text = $"Medicament adaugat cu succes in farmacia: ";
                foreach (string numeFarmacieSelectata in FarmaciiSelectate)
                {
                    if (numeFarmacieSelectata == Catena.Nume)
                    {
                        Catena.Medicamente.Add(med);
                        richtxtbConsola.Text += Catena.Nume + " ";
                    }
                    else if (numeFarmacieSelectata == Sensiblue.Nume)
                    {
                        Sensiblue.Medicamente.Add(med);
                        richtxtbConsola.Text += Sensiblue.Nume + " ";
                    }
                    else
                    {
                        Pharmaplus.Medicamente.Add(med);
                        richtxtbConsola.Text += Pharmaplus.Nume + " ";
                    }
                }


            }
        }

        private void checkFarmacie_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string farmacieSelectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                FarmaciiSelectate.Add(farmacieSelectata);
            else
                FarmaciiSelectate.Remove(farmacieSelectata);
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            PrepareForSearch();
            richtxtbConsola.Clear();
            if (Catena.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "In farmacia Catena sunt medicamentele \n";
                foreach (var item in Catena.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                }
            }

            if (Sensiblue.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "\nIn farmacia Sensiblue sunt medicamentele \n";
                foreach (var item in Sensiblue.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                }
            }

            if (Pharmaplus.Medicamente.Count > 0)
            {
                richtxtbConsola.Text += "\nIn farmacia Pharmaplus sunt medicamentele \n";
                foreach (var item in Pharmaplus.Medicamente)
                {
                    richtxtbConsola.Text += $"{item.Denumire} cu pretul {item.Pret} si expira la {item.DataExpirare}\n";
                }
            }

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            PrepareForSearch();
            var medSelectat = string.Empty;
            if (radbutParacetamol.Checked)
            {
                medSelectat = denumire.Paracetamol.ToString();
            }
            else if (radbutNurofen.Checked)
            {
                medSelectat = denumire.Nurofen.ToString();
            }
            else if (radbutTatum.Checked)
            {
                medSelectat = denumire.TatumVerde.ToString();
            }
            else
            {
                richtxtbConsola.Text = "Trebuie selectat un medicament!";
                return;
            }
            richtxtbConsola.Clear();
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
            checkbCatena.Checked = false;
            checkbPharmaplus.Checked = false;
            checkbSensiblue.Checked = false;

            txtbID.Text = string.Empty;
            txtbPret.Text = string.Empty;

            dateTimeExpirare.Value = DateTime.Today;

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var medSelectat = string.Empty;
            if (radbutParacetamol.Checked)
            {
                medSelectat = denumire.Paracetamol.ToString();
            }
            else if (radbutNurofen.Checked)
            {
                medSelectat = denumire.Nurofen.ToString();
            }
            else if (radbutTatum.Checked)
            {
                medSelectat = denumire.TatumVerde.ToString();
            }
            else
            {
                richtxtbConsola.Text = "Trebuie selectat un medicament!";
                return;
            }

            foreach (var item in Catena.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                }
            }
            foreach (var item in Sensiblue.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                }
            }
            foreach (var item in Pharmaplus.Medicamente)
            {
                if (medSelectat == item.Denumire)
                {
                    item.Pret = float.Parse(txtbPret.Text);
                    item.DataExpirare = dateTimeExpirare.Value;
                }
            }

            richtxtbConsola.Text = $"Medicamentul cu denumirea {medSelectat} a fost modificat cu succes!";


        }
    }
}
