using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public class Municipalite
    {
        public int CodeGeographique { get; set; }
        public string NomMunicipalite { get; set; }
        public string? AdresseCourriel { get; set; }
        public string? AdresseWeb { get; set; }
        public DateTime? DateProchaineElection { get; set; }

        public bool Actif { get; set; }

        public Municipalite()
        {
            ;
        }

        public Municipalite(int codeGeographique, string nomMunicipalite, string? adresseCourriel, string? adresseWeb, DateTime? dateProchaineElection, bool actif)
        {
            CodeGeographique = codeGeographique;
            NomMunicipalite = nomMunicipalite;
            AdresseCourriel = adresseCourriel;
            AdresseWeb = adresseWeb;
            DateProchaineElection = dateProchaineElection;
            Actif = actif;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
