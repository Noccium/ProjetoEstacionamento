using System;

namespace ProjetoEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            DateTime b = DateTime.Now;
            b = b.AddDays(1);
            b = b.AddHours(1);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(Convert.ToInt32( Math.Sqrt( Math.Pow((a - b).TotalHours, 2) ) ));
            Console.WriteLine((a - b).TotalHours);
        }
    }
}
