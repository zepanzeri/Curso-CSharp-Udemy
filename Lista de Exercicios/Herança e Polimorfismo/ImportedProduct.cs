namespace Lista_de_Exercicios.Herança_e_Polimorfismo
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name
                   + " $ "
                   + Price.ToString("F2")
                   + " (Customs fee: (" + CustomsFee.ToString("F2") + ")";
        }
    }
}
