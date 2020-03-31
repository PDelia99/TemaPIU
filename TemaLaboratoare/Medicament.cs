
using System;

namespace TemaLaboratoare
{
    public class Medicament
    {
        public double ID;
        public string Denumire;
        public float Pret;
        public DateTime DataExpirare;

        public static double IDMedicament { get; set; } = 0;
        public string DEnumire { get; set; }
        public float PRet { get; set; }
        public DateTime DAtaExpirare { get; set; }

        public enum denumire
        {
            Paracetamol=1,
            Aspirina=2,
            Nurofen=3,
            TatumVerde=4,
            VitaMax=5
        }

        public Medicament()
        {
            Random randomNumber = new Random();
            ID = randomNumber.NextDouble();
            Denumire = "Medicament fara nume";
            Pret = 0;
            DataExpirare = DateTime.Today;
        }

        public Medicament(string data)
        {
            string[] item = data.Split(',');
            ID = double.Parse(item[0]);
            Denumire = item[1];
            Pret = float.Parse(item[2]);
            DataExpirare = DateTime.Parse(item[3]);
        }

        public Medicament(double _ID, string _denumire, float _pret, DateTime _dataExpirare)
        {
            ID = _ID;
            Denumire = _denumire;
            Pret = _pret;
            DataExpirare = _dataExpirare;
        }

        public string toString()
        {
            return string.Format("Medicamentul cu ID-ul {0} are numele {1}, pretul {2} si expira la data de: {3}", ID, Denumire, Pret, DataExpirare);
        }

        public Medicament EditarePret(Medicament item)
        {
            item.Pret += 15;
            return item;
        }
    }
}
