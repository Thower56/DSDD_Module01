using srvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01_DAL_Municipalite_MySQL
{
    public class DepotMunicipalitesSQL : IDepotMunicipalites
    {
        private readonly MunicipaliteContextSQL m_dbContext;
        public DepotMunicipalitesSQL()
        {
        }

        public DepotMunicipalitesSQL(MunicipaliteContextSQL p_context)
        {
            m_dbContext = p_context;
        }

        public void AjouterMunicipalite(srvm.Municipalite p_municipalite)
        {
            m_dbContext.Add(new MunicipaliteDTO(p_municipalite));
            m_dbContext.SaveChanges();
        }

        public void ChercherMunicipaliteParCodeGeographique(int p_codeGeograhpique)
        {
            m_dbContext.Where
        }

        public void DesactiverMunicipalite(srvm.Municipalite p_municipalite)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<srvm.Municipalite> ListerMunicipalites()
        {
            throw new NotImplementedException();
        }

        public void MAJMunicipalite(srvm.Municipalite p_municipalite)
        {
            throw new NotImplementedException();
        }
    }
}
