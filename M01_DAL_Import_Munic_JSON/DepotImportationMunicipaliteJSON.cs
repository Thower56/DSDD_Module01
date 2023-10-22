using M01_DAL_Municipalite_MySQL;
using Newtonsoft.Json;
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
            List<MunicipaliteDTO> listMunicipaliteDTO;

            if (File.Exists(m_nomFichier))
            {
                string json = File.ReadAllText(m_nomFichier);
                listMunicipaliteDTO = JsonConvert.DeserializeObject<List<MunicipaliteDTO>>(json);
            }
            else
            {
                listMunicipaliteDTO = new List<MunicipaliteDTO>();
            }

            return listMunicipaliteDTO.Select(m => m.VersEntite()).ToList();
        }
    }
}