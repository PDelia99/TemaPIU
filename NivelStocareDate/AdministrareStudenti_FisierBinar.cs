using System;
using System.Collections.Generic;
using TemaLaboratoare;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddStudent(Medicament s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public Medicament[] GetStudenti(out int nrStudenti)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public Medicament GetStudent(string denumire)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }
    }
}
