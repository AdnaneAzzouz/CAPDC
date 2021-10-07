using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class TraitementSemance : TraitementPhytosanitaire
    {
        private double dosageTraitementSemance;

        public TraitementSemance(string unId, string unTypeProduit, Parcelle uneParcelleCultive, ProduitPhytosanitaire unProduitPhyto, double unDosage) 
            : base(unId, unTypeProduit, uneParcelleCultive, unProduitPhyto)
        {
            this.dosageTraitementSemance = unDosage;
        }

        public override double QuantiteApplique()
        {
            return base.GetLaParcelle().GetSurface() * this.dosageTraitementSemance;
        }
    }
}
