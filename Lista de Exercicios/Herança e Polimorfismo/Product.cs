namespace Lista_de_Exercicios.Herança_e_Polimorfismo
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return "PRICE TAGS:"
                    + "\n"
                    + Name
                    + " $ "
                    + Price;
        }
    }
}
