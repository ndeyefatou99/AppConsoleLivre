using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre
{
    internal class Revue: Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string titre,string auteur,int nbrpage, int numero, int annee) : base(titre, auteur, nbrpage)
        {
            Numero = numero;
            Annee = annee;
        }
        public override void affichedetails()
        {
            Console.WriteLine($"{ }");
            base.affichedetails();
            
        }
    }
}
