using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class ProduitPhytosanitaire
    {
        // attributs privés
        private string id;
        private string libelle;
        // constructeur
        public ProduitPhytosanitaire(string unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }
        
    }
}
