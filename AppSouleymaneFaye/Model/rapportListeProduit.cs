using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSouleymaneFaye.Model
{
    public class rapportListeProduit
    {
        //lest attributs nulles ne peuvent pas etre au niveau du rapport

        public string CodeProduit { get; set; }
        public string DesignationProduit { get; set; }
        public double PU { get; set; }
        public int QteMin { get; set; }
        public int QteCri { get; set; }
        public string Categorie { get; set; }

        //dans un rapport, le code de la categorie n'a pas de sens
    }
}
