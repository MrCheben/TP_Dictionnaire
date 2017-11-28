using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Article A1 = new Article(1, "Chocolat", 2.50);
            Article A2 = new Article(2, "Biscuit", 3.12);
            Article A3 = new Article(3, "Chips", 1.45);
            Commande C1 = new Commande(1, DateTime.Now);

            string resultat;
            resultat = C1.AjouterArticle(A1, 10);
            resultat = resultat + "\n" +C1.AjouterArticle(A2, 5);
            resultat = resultat + "\n" +C1.AjouterArticle(A1, 5);
            Console.WriteLine("Après ajouts : \n\n" + resultat);
            Console.WriteLine("\n" + C1.Facture());
                       
            C1.SupprimerArticle(A1);
            C1.SupprimerArticle(A3);
            Console.WriteLine("\n\nAprès suppressions : \n\n" + C1.Facture());
            Console.ReadLine();
            
        }
    }
}
