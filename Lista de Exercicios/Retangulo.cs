using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_de_Exercicios
{
    class Retangulo{
        public double Altura, Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override string ToString()
        {
            return "Area = " + Area().ToString("F2")
             + "\n"
             + "Perimetro = "
             + Perimetro().ToString("F2");               
        }
    }
}
