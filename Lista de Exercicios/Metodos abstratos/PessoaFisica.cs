namespace Lista_de_Exercicios.Metodos_abstratos
{
    class PessoaFisica : Pessoa
    {
        public double GastoComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual,double gastoComSaude)
            :base(nome,rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double Imposto()
        {
            double imposto = 0;
            if (RendaAnual < 20000)
                imposto = RendaAnual * 0.15;
            else
                imposto = RendaAnual * 0.25;
            return imposto - GastoComSaude * 0.5;         
        }
    }
}
