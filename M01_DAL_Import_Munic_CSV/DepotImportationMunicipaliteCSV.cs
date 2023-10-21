using srvm;

namespace M01_DAL_Import_Munic_CSV
{
    public class DepotImportationMunicipaliteCSV : IDepotImportationMunicipalites
    {
        private string m_nomFichier;

        public DepotImportationMunicipaliteCSV(string nomFichier)
        {
            m_nomFichier = nomFichier;
        }

        public IEnumerable<Municipalite> LireMunicipalites()
        {
            throw new NotImplementedException();
        }
    }
}