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
        public DepotMunicipalitesSQL()
        {
        }

        public DepotMunicipalitesSQL(MunicipaliteContextSQL p_context)
        {
            
        }

        public void AjouterMunicipalite(srvm.Municipalite p_municipalite)
        {
            throw new NotImplementedException();
        }

        public void ChercherMunicipalite(srvm.Municipalite p_municipalite)
        {
            throw new NotImplementedException();
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
