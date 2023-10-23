using srvm;
namespace Module01_Introduction_Exercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDepotImportationMunicipalites depotImportationMunicipalites;
            IDepotMunicipalites depotMunicipalites;
            TraitementImporterDonneesMunicipalite traitement = new TraitementImporterDonneesMunicipalite(depotImportationMunicipalites, depotMunicipalites);
        }
    }
}