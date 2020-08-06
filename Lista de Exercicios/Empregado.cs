using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class Empregado{
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return "Id: "
                    + Id + " , "
                    + "Nome: "
                    + Nome + " , "
                    + "Salario: "
                    + Salario;
        }
    }
}
