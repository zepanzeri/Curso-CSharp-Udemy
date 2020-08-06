using System;
using System.Collections.Generic;

namespace Lista_de_Exercicios
{
    class Program
    {        
        static void Main(string[] args)
        {
            /* Exercicio 1
            int a, b;
            Console.WriteLine("Digite o valor de a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado = {0}",a+b);
            */

            /* Exercicio 2
            double pi = 3.14159, raio, resultado;
            Console.WriteLine("Informe o raio");
            raio = double.Parse(Console.ReadLine());
            resultado = pi * Math.Pow(raio,2);
            resultado = Math.Round(resultado,4);
            Console.WriteLine("Resultado = " + resultado);
            */

            /* Exercicio 3
            int a, b, c, d;
            Console.WriteLine("Digite o valor de a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de d");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Diferença = {0}",a*b-c*d);
            */

            /* Exercicio 1 Lista 3
           int senha = int.Parse(Console.ReadLine());

           while (senha != 2002)
           {
               Console.WriteLine("Senha Errada");
               senha = int.Parse(Console.ReadLine());
           }
           Console.WriteLine("Senha Correta");
            */

            /* Lista 4 Exericio 1
            int x = int.Parse(Console.ReadLine());
            for(int i=1;i<=x;i++)
                if(i%2 == 1)
                    Console.WriteLine(i);
            */

            /* Exercicio Classe
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            double p, areaX, areaY;

            Console.WriteLine("Valores de X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Valores de Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());          

            p = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            areaX = Math.Round(areaX, 4);
            areaY = Math.Round(areaY, 4);

            if (areaX > areaY)
                Console.WriteLine("Area X maior " + areaX);
            else
                Console.WriteLine("Area Y maior " + areaY);
            */

            /* Exercicio 1 lista classes
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Informe seu nome");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu nome");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
                Console.WriteLine("Pessoa mais velha "+a.Nome);
            else
                Console.WriteLine("Pessoa mais velha "+b.Nome);
            */

            /* Exercicio 1 classes/atributos
            Retangulo r;
            r = new Retangulo();
            Console.WriteLine("Digite o valor da altura");            
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura");
            r.Largura = double.Parse(Console.ReadLine());
            r.Area();
            r.Perimetro();
            Console.WriteLine(r);
            */

            /* Exericio Static
            Console.WriteLine("Quantos dolares deseja comprar?");
            double qtdeDolar = double.Parse(Console.ReadLine());
            qtdeDolar = ConversorDeMoeda.Converter(qtdeDolar);
            qtdeDolar = Math.Round(qtdeDolar, 2);
            Console.WriteLine("Total a pagar = "+qtdeDolar);
            */

            /*
            ContaBancaria conta;
            Console.WriteLine("Entre com o Numero da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Titular da conta:");
            string titular = Console.ReadLine();
            Console.WriteLine("Havera deposito inicial? s/n");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Informe o Saldo inicial:");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
                conta = new ContaBancaria(numero, titular);

            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com valor para Deposito");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine("Entre com valor para Saque: ");
            double saque = double.Parse(Console.ReadLine());
            if(saque > conta.Saldo)
                Console.WriteLine("Saldo Insuficiente. Saque cancelado");
            else
                conta.Saque(saque);

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);
            */

            /* Exercicio Listas
            List < Empregado > listaDeEmpregados = new List<Empregado>();

            Console.WriteLine("Quantos Funcionarios serão registrados?");
            int nFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < nFuncionarios; i++)
            {
                Console.WriteLine("Informe o Id do funcionario:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o Nome do funcionario:");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario:");
                double salario = double.Parse(Console.ReadLine());
                listaDeEmpregados.Add(new Empregado(id, nome, salario));
            }

            Console.WriteLine("Informe o Id do empregado que vai receber aumento");
            int buscaId = int.Parse(Console.ReadLine());
            Empregado empregadoFiltrado = listaDeEmpregados.Find(x => x.Id == buscaId);
            if(empregadoFiltrado != null)
            {
                Console.WriteLine("Informe a porcentagem de aumento");
                double porcentagem = double.Parse(Console.ReadLine());
                empregadoFiltrado.AumentarSalario(porcentagem);
            }
            else
                Console.WriteLine("Funcionario não encontrado");
            Console.WriteLine();
            Console.WriteLine("Dados dos Funcionarios");
            foreach(Empregado e in listaDeEmpregados)
                Console.WriteLine(e);
            */

        }

    }
}
