using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Reqem daxil edin ");
            string n = Console.ReadLine();
            int i=0;
            int count = n.Length;
            int sum = 0;
            while (i < count)
            {
                if (char.IsDigit(n[i]))
                    sum += n[i++] - 48;
            }
            Console.WriteLine(sum);


       
        }
    }
}
