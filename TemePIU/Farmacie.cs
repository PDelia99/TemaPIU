//Student: Delia Polocoser
//Grupa: 3123b
using System;
using System.Collections.Generic;
using System.IO;

namespace TemaLaboratoare
{
    public class Farmacie
    {
        public List<Medicament> Medicamente; //declar o lista de tipul medicament 
        public string Nume;
       
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

        public void ScriereInFisier(string numeFisier)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriterindica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisier))
                {
                    foreach (var item in Medicamente)
                    {
                        swFisierText.WriteLine(item.Denumire);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " +eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
       
    }
}
