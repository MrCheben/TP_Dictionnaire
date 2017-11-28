using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Article
    {
        private double prixUnitaireHT;
        private int reference;
        private string libelle;

        public Article(int uneReference, string unLibelle, double unPrix)
        {
            this.prixUnitaireHT = unPrix;
            this.reference = uneReference;
            this.libelle = unLibelle;
        }
        public int GetReference()
        {
            return this.reference;
        }
        public string GetLibelle()
        {
            return this.libelle;
        }
        public double GetPrix()
        {
            return this.prixUnitaireHT;
        }
    }


}
