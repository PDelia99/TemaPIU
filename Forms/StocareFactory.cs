﻿//Student: Delia Polocoser
//Grupa: 3123b
using NivelAccesDate;
using System.Configuration;

namespace InterfataUtilizator
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            //var formatSalvare = "txt";
            //var numeFisier = "dateout";
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareStudenti_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareMedicamenti_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
