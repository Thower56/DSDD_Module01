using srvm;

namespace M01_DAL_Import_Munic_JSON
{
    public class DepotImportationMunicipaliteJSON : IDepotImportationMunicipalites
    {
        private string m_nomFichier;
        public DepotImportationMunicipaliteJSON(string p_nomFichier)
        {
            m_nomFichier = p_nomFichier;
        }

        public IEnumerable<Municipalite> LireMunicipalites()
        {
            throw new NotImplementedException();
        }
    }
}