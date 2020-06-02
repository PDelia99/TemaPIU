//Student: Delia Polocoser
//Grupa: 3123b
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class EditareMedicament : Form
    {
        public EditareMedicament(string medicament, string pret, DateTime data)
        {
            InitializeComponent();

            lblDenumireMedicament.Text = medicament;
            txtbPret.Text = pret;
            dateTimeExpirare.Value = data;
        }
    }
}
