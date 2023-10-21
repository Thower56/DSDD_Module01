using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public class TraitementImporterDonneesMunicipalite
    {
        private IDepotMunicipalites m_depotMunicipalites;
        private IDepotImportationMunicipalites m_importationMunicipalites;
        public TraitementImporterDonneesMunicipalite(IDepotImportationMunicipalites p_depotImportationMunicipalites, IDepotMunicipalites p_depotMunicipalites)
        {
            m_depotMunicipalites = p_depotMunicipalites;
            m_importationMunicipalites = p_depotImportationMunicipalites;
        }

        public StatistiquesImportationDonnees Executer()
        {

        }
    }
}
