using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class Pulverisation
    {
        private string id;
        private double dosagePulverisation;
        private DateTime datePulverisation;

        public Pulverisation(string unId, double unDosage, DateTime uneDate)
        {
            this.id = unId;
            this.dosagePulverisation = unDosage;
            this.datePulverisation = uneDate;
        }

        public double GetDosage()
        {
            return this.dosagePulverisation;
        }
    }
}
