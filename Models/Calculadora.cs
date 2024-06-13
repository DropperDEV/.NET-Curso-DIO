using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiroProjetoConsole.Models
{
    public class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x * y}");
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Dividir(double x)
        {
            Console.WriteLine($"Raíz quadrada de {x} = {Math.Sqrt(x)}");
        }
        public void Potencia(double x, double y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public void Seno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(Math.Sin(rad),2)}");
        }
        public void Cosseno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(Math.Cos(rad),2)}");
        }
         public void Tangente(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(Math.Tan(rad),2)}");
        }
    }
}