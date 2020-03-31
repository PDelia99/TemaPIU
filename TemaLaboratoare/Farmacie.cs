using System;
using System.Collections.Generic;

namespace TemaLaboratoare
{
    public class Farmacie
    {
        public List<Medicament> Medicamente; //declar o lista de tipul medicament 
        public string Nume;
        public enum Name
        {
            Catena = 1,
            Sensiblue = 2,
            PharmPlus = 3,
            Maria = 4
        }
        //public string Name { get; set; }
        public void AfiseazaMedicamente()
        {
            Console.WriteLine("\n" + Nume);
            foreach (var item in Medicamente)
            {
                Console.WriteLine("Medicamentul {0} expira la: {1}", item.Denumire, item.DataExpirare);
            }
        }

        public bool CautaMedicament(string denumire)
        {
            foreach (var item in Medicamente)
            {
                if (item.Denumire == denumire)
                {
                    Console.WriteLine("Medicamentul {0} a fost gasit in farmacia {1}", denumire, Nume);
                    return true;
                }
            }
            Console.WriteLine("Medicament indisponibil!");
            return false;
        }

        public string ConversieLaSir()
        {
            string sMedicamente = string.Empty;
            if (Medicamente != null)
            {
                foreach (var item in Medicamente)
                {
                    sMedicamente += string.Join(",", item.Denumire, " ");
                }
            }
            string s = string.Format("Farmacia {0} are medicamentele:.... {1}", (Nume ?? " NECUNOSCUT "), sMedicamente);
            return s;
        }

        public string ComapraFarmcie(Farmacie farmacieDeComparat)
        {
            string medicamenteNegasite = "Medicamentele din farmatia " + Nume + " care nu au fost gasite in farmacia " + farmacieDeComparat.Nume + "sunt: ";

            foreach (var itemClasaPrincipala in Medicamente)
            {
                foreach (var itemClasaSecundara in farmacieDeComparat.Medicamente)
                {
                    if (!medicamenteNegasite.Contains(itemClasaPrincipala.Denumire))
                    {
                        if (itemClasaPrincipala.Denumire != itemClasaSecundara.Denumire)
                        {
                            medicamenteNegasite += " " + itemClasaPrincipala.Denumire;
                        }
                    }
                }
            }

            //for (int i = 0; i < Medicamente.Count; i++)
            //{
            //    for (int j = 0; j < farmacieDeComparat.Medicamente.Count; j++)
            //    {
            //        //bool v = System.Text.RegularExpressions.Regex.IsMatch(farmacieDeComparat.Medicamente[j], medicamenteNegasite, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            //        //medicamenteNegasite.Contains(farmacieDeComparat.Medicamente[j]);

            //        if (farmacieDeComparat.Medicamente[j] != Medicamente[i] && v )
            //        {
            //            {
            //                medicamenteNegasite += " " + farmacieDeComparat.Medicamente[j].Denumire;

            //            }
            //        }
            //    }
            //}

            return medicamenteNegasite;
        }

    }
}
