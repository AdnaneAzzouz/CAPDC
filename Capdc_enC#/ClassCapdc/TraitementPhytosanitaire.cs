using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public abstract class TraitementPhytosanitaire
    {
        private string id;
        private string typeProduit;
        private Parcelle laParcelleCultive;
        private ProduitPhytosanitaire leProduitPhyto;

        public TraitementPhytosanitaire(string unId, string unTypeProduit, Parcelle uneParcelleCultive, ProduitPhytosanitaire unProduitPhyto)
        {
            this.id = unId;
            this.typeProduit = unTypeProduit;
            this.laParcelleCultive = uneParcelleCultive;
            this.leProduitPhyto = unProduitPhyto;
        }

        public string GetTypeProduit()
        {
            return this.typeProduit;
        }
        public Parcelle GetLaParcelle()
        {
            return this.laParcelleCultive;
        }

        public abstract double QuantiteApplique();
    }
}
