using System;

namespace Exercício_2_Dia_19__10__2020
{
    class Program
    { static void Main(string[] args); }

    namespace Course
    {
        //Criando a variável de entrada
        int n = int.Parse(Console.ReadLine());
        //Criando vetor com o número da variável de entrada
        Produto[] vect = new Produto[n];
                //Utilização do comando for para percorrer o vetor
                for (inti = 0; i<n; i++)
                {
                    string name = Console.ReadLine();
        double price = double.Parse(Console.ReadLine(), CultureInfo, InvariantCulture);

        //Entrada dos elementos no vetor pelo usuário
        vect[i] = new Produto(Name = name, Price = price)
        {
            Console.WriteLine("digite o nome do produto: ");
            string name = Console.ReadLine();
            Console.WriteLine("digite o preço: ");
            double price = double.Parse(Console.ReadLine());
        }
        //Variável soma       
        double sum = 0.0;
         //Utilização do for para percorrer o vetor
         for (int i = 0; i<n; i++)
         {
          //Somatoriados elementos inseridos
          sum += vect[i].Price;
         }
    }       
}        