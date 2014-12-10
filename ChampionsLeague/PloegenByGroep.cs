using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague
{
    public class PloegenByGroep
    {
        private string groep;
        private List<Ploeg> ploegen;

        public string Groep
        {
            get { return groep; }
            set { groep = value; }
        }
        
        public List<Ploeg> Ploegen
        {
            get { return ploegen; }
            set { ploegen = value; }
        }

    }
}
