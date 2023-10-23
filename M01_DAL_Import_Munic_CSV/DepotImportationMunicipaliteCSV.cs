using M01_DAL_Municipalite_MySQL;
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
            List<Municipalite> listeMunicipalite = new List<Municipalite>();
            using (StreamReader reader = File.OpenText(m_nomFichier))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    string[] lineMunicipalite = line.Split(';');
                    listeMunicipalite = lineMunicipalite.Select(m =>
                    {
                        return new Municipalite
                        (
                            int.Parse(lineMunicipalite[0]), lineMunicipalite[1], lineMunicipalite[7], lineMunicipalite[8], DateTime.Parse(lineMunicipalite[21])
                        );
                    }).ToList();
                }
            }
            return listeMunicipalite;
        }
    }
}