using System;

namespace UsandoIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comparação entre ifelse e SwitchCase 

            // Descrição de números de dia por mês

            string nome;
            string mes; 

            Console.WriteLine("Olá qual sue nome? ");
            Console.WriteLine("Me informe:")
            nome = Console.ReadLine();

            Console.WriteLine($" Olá ,{nome}, poderia escrever o nome do mês que você quer saber quantos dia possui?");
            mes = Console.ReadLine();

            if (mes == "Janeiro")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Março")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Abril")
            {
            Console.WriteLine("Este mês possui 30 dias");
            }

            if (mes == "Maio")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Junho")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Julho")
            {
            Console.WriteLine("Este mês possui 30 dias");
            }

            if(mes == "Agosto")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Setembro")
            {
            Console.WriteLine("Este mês possui 30 dias");
            }

            if (mes == "Outubro")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            if (mes == "Novembro")
            {
            Console.WriteLine("Este mês possui 30 dias");
            }

            if (mes == "Dezembro")
            {
            Console.WriteLine("Este mês possui 31 dias");
            }

            else if (mes == "Fevereiro") 
            {
            Console.WriteLine("Este mês possui 28 ou 29 dias");
            }
                       
        }
    }
}
