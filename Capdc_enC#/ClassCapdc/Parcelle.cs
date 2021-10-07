using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class Parcelle
    {
        // attributs privés
        private string id;
        private string nomExploitant;
        private string especeCultivee;
        private DateTime dateSemis;
        private DateTime dateRecoltePrevue;
        private double surface;
        private double qteRecoltee;
        private List<TraitementPhytosanitaire> lesTraitementsPhyto;

        // constructeur
        public Parcelle(string unId, string unExploitant, string uneEspece, DateTime uneDateSemis, DateTime uneDateRecolte, double uneqteRecoltee, double uneSurface)
        {
            this.id = unId;
            this.nomExploitant = unExploitant;
            this.especeCultivee = uneEspece;
            this.dateSemis = uneDateSemis;
            this.dateRecoltePrevue = uneDateRecolte;
            this.surface = uneSurface;
            this.qteRecoltee = uneqteRecoltee;
            this.lesTraitementsPhyto = new List<TraitementPhytosanitaire>();
        }
        // méthodes
        public double GetSurface()
        {
            return this.surface;
        }
        public List<TraitementPhytosanitaire> GetLesTraitementsPhytosanitaires()
        {
            return this.lesTraitementsPhyto;
        }
        public void AjouteUnTraitement(TraitementPhytosanitaire unTraitement)
        {
            this.lesTraitementsPhyto.Add(unTraitement);
        }

        public double GetTauxTraitementSemance()
        {
            int ts = 0;
            foreach(TraitementPhytosanitaire T in this.lesTraitementsPhyto)
            {
                if (T is TraitementSemance)
                    ts += 1;
            }
            return ts / this.lesTraitementsPhyto.Count;
        }
        public double Rendement()
        {
            return this.surface / this.qteRecoltee;
        }

        public Dictionary<string, double> FrequenceTraitement()
        {
            Dictionary<string, double> frequence = new Dictionary<string, double>();

            foreach(TraitementPhytosanitaire T in this.lesTraitementsPhyto)
            {
                frequence.Add(T.GetTypeProduit(), T.QuantiteApplique());
            }
            return frequence;
        }
    }
}
