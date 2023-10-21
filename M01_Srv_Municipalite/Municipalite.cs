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

        public Municipalite()
        {
            ;
        }

        public Municipalite(int p_CodeGeographique, string p_nomMunicipalite, string? p_adresseCourriel, string? p_adresseWeb, DateTime? p_dateProchaineElection)
        {
            CodeGeographique = p_CodeGeographique;
            NomMunicipalite = p_nomMunicipalite;
            AdresseCourriel = p_adresseCourriel;
            AdresseWeb = p_adresseWeb;
            DateProchaineElection = p_dateProchaineElection;
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
