using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4_Stars_up
{
    class controleur
    {
        private static bdd vmodele;

        public static bdd Vmodele
        {
            get { return controleur.vmodele; }
            set { controleur.vmodele = value; }
        }

        public static void init()
        {
            vmodele = new bdd();
        }
    }
}
