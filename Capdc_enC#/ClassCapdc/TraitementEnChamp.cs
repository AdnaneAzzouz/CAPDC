using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class TraitementEnChamp : TraitementPhytosanitaire
    {

        private List<Pulverisation> lesPulverisations;
        public TraitementEnChamp(string unId, string unTypeProduit, Parcelle uneParcelleCultive, ProduitPhytosanitaire unProduitPhyto)
            : base(unId, unTypeProduit, uneParcelleCultive, unProduitPhyto)
        {
            this.lesPulverisations = new List<Pulverisation>();
        }

        public void AjouteUnePulverisation(Pulverisation unePulverisation)
        {
            this.lesPulverisations.Add(unePulverisation);
        }
        public override double QuantiteApplique()
        {
            double cumul = 0;
            foreach (Pulverisation p in this.lesPulverisations)
               {
                cumul += p.GetDosage();
               }
            return cumul;
        }
    }
}
