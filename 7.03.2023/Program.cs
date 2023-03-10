using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _7._03._2023.Firm;

namespace _7._03._2023
{
    class Firm
    { 
        public string Name { get; private set; }
        public DateTime Founding { get; private set; }
        public enum Profiles
        {
            IT,
            Trade,
            Food,
            Marketing
            //...
        }
        public Profiles Profile { get; private set; }
        public string Ovner { get; private set; }
        public int Workers { get; private set; }
        public Firm(string name, DateTime founding, Profiles profile, string ovner, int workers) 
        {
            Name = name;
            Founding = founding;
            Profile = profile;
            Ovner = ovner;
            Workers = workers;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Firms = new List<Firm>() {
                new Firm("SmileFood", new DateTime(1976, 4, 1), Profiles.Food, "Mark Kuper", 365),
                new Firm("Foody", new DateTime(2001, 6, 23), Profiles.Food, "Kotler Moll", 153),
                new Firm("MotherByte", new DateTime(1984, 3, 12), Profiles.IT, "Kriss White", 496),
                new Firm("YuorSeller", new DateTime(2000, 8, 4), Profiles.Marketing, "Tod White", 201),
                new Firm("ITmaster", new DateTime(2008, 2, 28), Profiles.IT, "Kira Cold", 69),
            };

            foreach (var f in Firms)
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(i => i.Name.Contains("Food")))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(i => i.Profile == Firm.Profiles.Marketing))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(
                i => i.Profile == Firm.Profiles.IT ||
                i.Profile == Firm.Profiles.Marketing
            ))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(i => i.Workers > 100))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(
                i => i.Workers >= 100 &&
                i.Workers <= 300
            ))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(i => i.Ovner.Contains("White")))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();
            foreach (var f in Firms.Where(i => DateTime.Now - i.Founding > new TimeSpan(10000,0,0,0,0)))
            {
                Console.WriteLine($"{f.Name}, {f.Founding.ToShortDateString()}, {f.Profile}, {f.Ovner}, {f.Workers}");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
