using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string client1 = ("José");
            string client2 = ("Leonardo");
            
            int idade1 = 18;
            int idade2 = 24;
            int QCafe1 = 25;
            int QCafe2 = 15;
            int QCafetotal = QCafe1 + QCafe2; // Letra Q=Quantidade
            int QCafeFaltante1 = 200 - QCafe1;
            int QCafeFaltante2 = 200 - QCafe2; 


            Boolean c1 = true;    // Letra c=condição
            Boolean c2 = false;




            Console.WriteLine("Aula 03 - Atividade com variáveis");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Olá!");
            Console.WriteLine("Bem-vindo ao sistema de usuários do Conradito");
            Console.WriteLine("Abaixo estão as informações dos usuários cadastrados no nosso sistema:");
            Console.WriteLine("\n \n");
            Console.WriteLine("----- Lista de usuários:");
            Console.WriteLine($"1 - Nome:{client1}, idade:{idade1}.É cliente:{c1}");
            Console.WriteLine($"1 - Nome:{client2}, idade:{idade2}.É cliente:{c2}");
            Console.WriteLine("\n \n");
            Console.WriteLine("----- Quantidade de cafés");
            Console.WriteLine($"O cliente {client1} já tomou {QCafe1} cafés!");
            Console.WriteLine($"O cliente {client2} já tomou {QCafe2} cafés!");
            Console.WriteLine("\n \n");
            Console.WriteLine("----- Soma de cafés tomados");
            Console.WriteLine($"Juntos, os cliente {client1} e {client2} tomaram {QCafetotal} cafés! ");
            Console.WriteLine("\n \n");
            Console.WriteLine("----- Quantos cafés falta para chegar em 200?");
            Console.WriteLine($"Faltam {QCafeFaltante1} para {client1}");
            Console.WriteLine($"Faltam {QCafeFaltante2} para {client2}");
            Console.WriteLine("\n \n \n");
            Console.WriteLine("----- Fim do sistema de consultas" );
            Console.WriteLine("- Obrigado e volte sempre!");




















            Console.ReadKey();
        }
    }
}
