using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios.Herança_e_Polimorfismo
{
    sealed class UsedProduct:Product
    {
        public DateTime ManofacturerDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manofacturerDate)
            : base(name, price)
        {
            ManofacturerDate = manofacturerDate;
        }

        public override string PriceTag()
        {
            return Name
                   + " (Used)"
                   + " $ "
                   + Price
                   + " (Manofacture date: " + ManofacturerDate + ")";
        }
    }
}
