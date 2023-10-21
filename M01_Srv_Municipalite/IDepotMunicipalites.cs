﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srvm
{
    public interface IDepotMunicipalites
    {
        public void AjouterMunicipalite(Municipalite p_municipalite);

        public void ChercherMunicipalite(Municipalite p_municipalite);
        public void DesactiverMunicipalite(Municipalite p_municipalite);
        public IEnumerable<Municipalite> ListerMunicipalites();
        public void MAJMunicipalite(Municipalite p_municipalite);
    }
}