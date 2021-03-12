using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] estudantes = new Estudantes[10];

            Console.Write("Digite o numero de estudantes que vão alugar os quartos : ");
            int n = int.Parse(Console.ReadLine());

            while (n > 10 || n < 0)
            {
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Registro de estudantes : ");
            for (int p = 0; p < n; p++)
            {
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Email : ");
                string email = Console.ReadLine();
                Console.Write("Quarto : ");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[p] = new Estudantes(quarto, email, nome);
                

            }

            Console.Write("Deseja imprimir um relatório de ocupações do pensionato? (s/n) ");
            char r = char.Parse(Console.ReadLine());

            int count = 0;
            if (r == 's' || r == 'S')
            {
                for (int p = 0; p < 10; p++)
                {
                   
                    if (estudantes[p].Nome != null)
                    {
                        count++;
                        Console.WriteLine("Registro de aluguel #" + count + ":");
                        Console.WriteLine("Nome : " + estudantes[p].Nome);
                        Console.WriteLine("Email : " + estudantes[p].Email);
                        Console.WriteLine("Quarto : " + estudantes[p].Quarto);
                        Console.WriteLine();
                    }
                }
            }
            else if(r == 'n' || r == 'N')
            {
                Console.WriteLine("Obrigado por usar o programa...");
            }



        }
    }
}
