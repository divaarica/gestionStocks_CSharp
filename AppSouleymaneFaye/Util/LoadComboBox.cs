using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSouleymaneFaye.Model;

namespace AppSouleymaneFaye.Util
{

    //classe partagees

    public class LoadComboBox
    {
        BdKireneEntities db = new BdKireneEntities();

        public List<ListeSelectedViewModel> LoadCategorie()
        {
            List<ListeSelectedViewModel> Laliste = new List<ListeSelectedViewModel>();
            Laliste.Add(new ListeSelectedViewModel   //on instancie directement
            {
                Value = "null",
                Text = "Sellectionner ..."

            }
                ) ;

            var liste = db.Categorie.ToList();
            foreach ( var c in liste)
            {
                Laliste.Add(new ListeSelectedViewModel
                {

                    Value = c.Codecategorie,
                    Text = c.LibelleCategorie
                });
            }


            return Laliste;
        }

        public List<ListeSelectedViewModel> LoadProfil()
        {
            List<ListeSelectedViewModel> Laliste = new List<ListeSelectedViewModel>();
            Laliste.Add(new ListeSelectedViewModel   //on instancie directement
            {
                Value = "null",
                Text = "Sellectionner ..."

            }
                );

            var liste = db.Profil.ToList();
            foreach (var c in liste)
            {
                Laliste.Add(new ListeSelectedViewModel
                {

                    Value = c.codeProfil,
                    Text = c.libelleProfil
                });
            }


            return Laliste;
        }




    }
}
