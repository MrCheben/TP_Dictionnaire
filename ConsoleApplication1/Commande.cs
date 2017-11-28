using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    public class Commande
    {
        private int numero;
        private DateTime date;
        private Dictionary<Article, int> mesArticles;

        public Commande(int unNumero, DateTime uneDate)
        {
            this.numero = unNumero;
            this.date = uneDate;
            this.mesArticles = new Dictionary<Article, int>();
        }

        public string AjouterArticle(Article unArticle, int uneQuantite)
        {
            string msg;
            if (this.mesArticles.ContainsKey(unArticle))
                msg = "Ajout impossible, l'article " + unArticle.GetReference().ToString() + " existe déjà !";
            else
            {
                this.mesArticles.Add(unArticle, uneQuantite);
                msg = "L'article " + unArticle.GetReference().ToString() + " a été ajouté";
            }
            return msg;
        }
        
        public void SupprimerArticle(Article unArticle)
        {
           this.mesArticles.Remove(unArticle);
        }
        
        public string Facture()
        {
            double total = 0;
            string S = "Commande N° " + this.numero;
            S += "\n---------------------------";
            foreach (KeyValuePair<Article, int> ligne in this.mesArticles)
            {
                S += "\n" + ligne.Key.GetLibelle() + " : " + ligne.Value;
                S += "\n--Prix unitaire = " + ligne.Key.GetPrix();
                total += ligne.Value * ligne.Key.GetPrix();
            }
            S += "\n---------------------------";
            S += "\n" + this.mesArticles.Count + " articles commandés";
            S += "\nTotal : " + total;
            return S;
        }

        
    }
}
