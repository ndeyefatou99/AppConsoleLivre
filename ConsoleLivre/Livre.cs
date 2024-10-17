using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre
{
    internal class Livre
    {
        public string Auteur { get; set; }
        public string Titre { get; set; }
        public int NombrePage { get; set; }

        public Livre (string auteur, string titre, int nbrpage)
        {
            Auteur = auteur;
            Titre = titre;
            NombrePage = nbrpage;
        }

        public virtual void affichedetails()
        {
            Console.WriteLine ($"le nom de l'auteur est {Auteur}, le titre est {Titre} et a pour nombre de page {NombrePage}");
        }
}
            
    }

