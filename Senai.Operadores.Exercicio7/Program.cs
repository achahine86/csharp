using System;

namespace Senai.Operadores.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Informe o valor em US$");
                decimal valorDolar = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor em real");
                decimal valorReal = decimal.Parse(Console.ReadLine());

                decimal ConversaoDolarReal = valorDolar * valorReal;

                // o cifrão $ significa interpolação
                Console.WriteLine($"US$ {valorDolar} * R$ {valorReal} = {ConversaoDolarReal}");
        }
    }
}
