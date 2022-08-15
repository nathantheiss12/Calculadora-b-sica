using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           double a , b , resultado ;
           string x;

           Console.WriteLine(" Digite um numero"); //Peço para o usuário o primeiro número
           x = Console.ReadLine(); // A variável x recebe o valor informado
           a= int.Parse(x); // e aqui a variável a recebe o valor convertido de x

           Console.WriteLine("Digite mais um numero: "); // Processo 1 repetido
           x=Console.ReadLine();
           b = int.Parse(x);

             //realiza a soma e imprime no console
            resultado = a + b;
            Console.WriteLine("Soma: " + resultado);

            //realiza a subtração e imprime no console
            resultado = a - b;
            Console.WriteLine("Subtracão: " + resultado);

            //realiza a multiplicação e imprime no console
            resultado = a * b;
            Console.WriteLine("Multiplicação: " + resultado);
            

            //realiza a divisão e imprime no console
            resultado = a / b;
            Console.WriteLine("Divisão: " + resultado);
        }
    }
}
