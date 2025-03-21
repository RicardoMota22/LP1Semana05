using System;
using Spectre.Console;
using Bogus;
using System.Security.Cryptography;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();
            int random = Randomizer.Number(20);

            BarChart bc = new BarChart();
            //bc.AddItem("Ferrari",14);

            
            
            bc.AddItem(faker,random);
            Console.WriteLine(bc);
            
        }
    }
}
