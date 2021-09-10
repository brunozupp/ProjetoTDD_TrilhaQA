using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAsserts.Igualdade
{
    public class Calculadora
    {
        public int SomarNumerosInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SomarNumerosDecimais(double num1, double num2)
        {
            return num1 + num2;
        }

        public int Dividir(int num, int por)
        {
            if(num > 100)
            {
                throw new ArgumentOutOfRangeException("por"); // Propósito de teste
            }

            return num / por;
        }
    }
}
