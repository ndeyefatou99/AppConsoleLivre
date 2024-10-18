using AppConsoleLivre;

internal class Program
{
    private static void Main(string[] args)
    {
        // Créer une liste générique de type Livre
        List<Livre> listeLivres = new List<Livre>();

        // Créer des objets de type Roman
        Roman rom1 = new Roman("Batouala", "hbdgygfg", 1200, "Fantasy");
        Roman rom2 = new Roman("1984", "George Orwell", 328, "Dystopie");
        Roman rom3 = new Roman("Les Misérables", "Victor Hugo", 1463, "Drame");

        // Créer des objets de type Revue
        Revue rev1 = new Revue ("Science Magazine", "John Doe", 50, 10, 1999);
        Revue rev2 = new Revue("Nature", "Jane Smith", 40, 11, 2000);
        Revue rev3 = new Revue("National Geographic", "Jim Beam", 60, 12, 2001);

        // Ajouter les objets à la liste
        listeLivres.Add(rom1);
        listeLivres.Add(rom2);
        listeLivres.Add(rom3);
        listeLivres.Add(rev1);
        listeLivres.Add(rev2);
        listeLivres.Add(rev3);

        // Parcourir la liste et afficher les détails de chaque élément
        foreach (Livre livre in listeLivres)
        {
            livre.affichedetails();
            Console.WriteLine(); // Pour une séparation visuelle
        }

        // Sauvegarde du travail
        Console.WriteLine("Appuyez sur une touche pour terminer...");
        Console.ReadKey();

    }
}