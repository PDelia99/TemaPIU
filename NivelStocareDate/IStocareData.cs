using System.Collections.Generic;
using TemaLaboratoare;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(Medicament s);
        Medicament[] GetStudenti(out int nrStudenti);

        Medicament GetStudent(string denumire);
    }
}
