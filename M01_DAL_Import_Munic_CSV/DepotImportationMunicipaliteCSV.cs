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
            List<string> informationMunicipalite = new List<string>();
            using (StreamReader reader = File.OpenText(m_nomFichier))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    foreach (string info in line.Split(";"))
                    {
                        informationMunicipalite.Add(info);
                    }
                    
                }
            }
            return ;
        }
    }
}