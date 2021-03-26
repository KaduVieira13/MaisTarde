using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime atual = DateTime.Now;
            TimeSpan seishtrinta = new TimeSpan(6,30,0);
            DateTime horaAdiantada = atual + seishtrinta;

            Console.WriteLine("--- Exibindo intervalo de 6H30m ---");
            Console.WriteLine($"Hora do sistema: {atual}");
            Console.WriteLine($"Mais tarde: {horaAdiantada}");

            string horaDigitada;

            Console.WriteLine("Digite a hora no formato H,M,s");
            horaDigitada = Console.ReadLine();
            TimeSpan.Parse(horaDigitada);
            TimeSpan horadepois =  TimeSpan.Parse (horaDigitada);
            DateTime horaNova = atual + horadepois;

            Console.WriteLine($"Hora do sistema: {atual}");
            Console.WriteLine($"Mais tarde: {horaNova}");

            
           

        }
    }
}
