using System;
using System.Collections.Generic;
using System.IO;

namespace TemaLaboratoare
{
    class Program
    {
        static void Main(string[] args)
        {
            //apeleaza constructorul fara parametrii
            Medicament Aspirina = new Medicament();

            //apeleaza constructorul cu parametrii
            Medicament Paracetamol = new Medicament(1, "Paracetamol", 20, new DateTime(2022, 1, 18));
            Medicament ParasinsusPenta = new Medicament(1, "Parasinus Penta", 15, new DateTime(2025, 4, 1));
            Medicament Nurofen = new Medicament(2, "Nurofen", 30, new DateTime(2025, 6, 3));
            Medicament Nospa = new Medicament(2, "Nospa", 10, new DateTime(2024, 7, 3));

            //creaza o noua farmacie
            Farmacie SensiBllue = new Farmacie();
            SensiBllue.Medicamente = new List<Medicament>();
            SensiBllue.Nume = "SensiBlue";
            SensiBllue.Medicamente.Add(ParasinsusPenta);
            SensiBllue.Medicamente.Add(Paracetamol);
            SensiBllue.Medicamente.Add(Aspirina);

            //afiseaza medicamentele
            SensiBllue.AfiseazaMedicamente();

            //sterge un medicament
            SensiBllue.Medicamente.Remove(Aspirina);

            SensiBllue.AfiseazaMedicamente();

            //creeaza o noua farmacie
            Farmacie Catena = new Farmacie();
            Catena.Medicamente = new List<Medicament>();
            Catena.Medicamente.Add(Nurofen);
            Catena.Medicamente.Add(Nospa);
            Catena.Nume = "Catena";
            Catena.AfiseazaMedicamente();

            //editarea unui medicament
            Nospa = Nospa.EditarePret(Nospa);
            Nospa.DataExpirare = new DateTime(2020, 8, 4);
            Console.WriteLine(Nospa.toString());

            //cauta medicament
            Catena.CautaMedicament("Ibuprofen");
            Catena.CautaMedicament(Nurofen.Denumire);

            Console.WriteLine(); Console.WriteLine();
            Medicament Ibuprofen = new Medicament("6,Ibuprofen,45,02.03.2030");
            Console.WriteLine(Ibuprofen.toString());

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(Catena.ConversieLaSir());
            Console.WriteLine(SensiBllue.ConversieLaSir());

            Console.WriteLine();
            Console.WriteLine(Catena.ComapraFarmcie(SensiBllue));

            //citirea de la tastatura
            //Medicament M = CTastatura();
            //Console.WriteLine("-----" + M.ID + " " + M.Denumire + " " + M.Pret);

            //cauta medicament in farmacie
            Console.WriteLine();
            if (Catena.Medicamente.Contains(Nurofen))
            {
                Console.WriteLine(Catena.Nume + " are in farmacie medicamentul:" + Nurofen.Denumire);
            }
            else
            {
                Console.WriteLine(Catena.Nume + " NU are in farmacie medicamentul:" + Nurofen.Denumire);

            }





            //scriere in fisier 

            //Paracetamol.ScriereInFisier("dateout.txt", Paracetamol);
            //SensiBllue.ScriereInFisier("dateout.txt");

            //citire din fisier
            CitireMedicamenteDinFisier("datein.txt");

            Console.ReadLine();


        }
        public static Medicament CTastatura()
        {
            Console.WriteLine("Introduceti id-ul produsului:");
            double Id = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduceti denumirea medicamentului:");
            string denumire = Console.ReadLine();
            Console.WriteLine("Introduceti pretul:");
            float pret = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti data:");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Medicament M = new Medicament(Id, denumire, pret, data);
            return M;

        }

        public static void CitireMedicamenteDinFisier(string numeFisier)
        {
            //List<Medicament> medicamenteCititeDinFisier = new List<Medicament>();
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    int numarLinie = 0;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] item = line.Split(' ');

                        string denumire = item[0];
                        float pret = float.Parse(item[1]);

                        Console.WriteLine("Am citit medicamentul {0} cu pretul {1}", denumire, pret);

                        //Medicament med = new Medicament(denumire, pret);

                        //medicamenteCititeDinFisier.Add(med);


                    }
                    //nrStudenti = numarLinie;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " +
                eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            //return medicamenteCititeDinFisier;
        }

    }
}
