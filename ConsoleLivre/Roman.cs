using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivre
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }
        public Roman(string titre, string auteur, int nbrpage, string genre) : base(titre, auteur, nbrpage)
        {
            Genre = genre;
        }
        public override void affichedetails()
        {
            Console.WriteLine($" Genre {Genre}");
            base.affichedetails();
        }
    }
}
