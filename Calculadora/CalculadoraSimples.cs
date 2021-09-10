using System;

namespace Calculadora
{
    public class CalculadoraSimples
    {
        public double Adicionar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            // Para fins de teste, vai dar bug
            return num1 * num2;
        }

        public double Dividir(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
