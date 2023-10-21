using srvm;

namespace M01_DAL_Municipalite_MySQL
{
    public class Municipalite
    {
        public int MunicipaliteID { get; set; }
        public string NomMunicipalite { get; set; }
        public string? AdresseCourriel { get; set; }
        public string? AdresseWeb { get; set; }
        public DateTime? DateProchaineElection { get; set; }
        public bool Actif { get; set; }
        public Municipalite()
        {
            
        }
        public Municipalite(srvm.Municipalite p_municipalite)
        {
            MunicipaliteID = p_municipalite.CodeGeographique;
            NomMunicipalite = p_municipalite.NomMunicipalite;
            AdresseCourriel = p_municipalite.AdresseCourriel;
            AdresseWeb = p_municipalite.AdresseWeb;
            DateProchaineElection = p_municipalite.DateProchaineElection;
        }

        public srvm.Municipalite VersEntite()
        {
            return new srvm.Municipalite(MunicipaliteID, NomMunicipalite, AdresseCourriel, AdresseWeb, DateProchaineElection);
        }
    }
}