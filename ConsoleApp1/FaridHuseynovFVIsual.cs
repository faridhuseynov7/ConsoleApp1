//1
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Yasinizi daxil edin");
            string agetext = Console.ReadLine();
            int.TryParse(agetext, out int age);
            Console.WriteLine("Boyunuzu daxil edin");
            string heightext = Console.ReadLine();
            float.TryParse(heightext, out float height);
            Console.WriteLine("-----------------");
            Console.WriteLine(name + " " + age + " " + height);
        }
    }
}

//2

using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            Console.WriteLine("Eded daxil edin");
            string ededtext = Console.ReadLine();
            double.TryParse(ededtext, out double eded);
            double sahe = eded * eded * pi;
            Console.WriteLine(sahe);
        }
    }
}

//3

using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double usd = 1.7;
            const double eur = 1.82;
            Console.WriteLine("Pul daxil edin");
            string manattext = Console.ReadLine();
            double.TryParse(manattext, out double manat);
            double dollar = manat / usd;
            double euro = manat / eur;

            Console.WriteLine("-----------------");
            Console.WriteLine(dollar + " dollar");
            Console.WriteLine(euro + " euro");
        }
    }
}

//4

using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci fenn: ");
            float.TryParse(Console.ReadLine(), out float p1);
            Console.WriteLine("2ci fenn: ");
            float.TryParse(Console.ReadLine(), out float p2);
            Console.WriteLine("3cu fenn: ");
            float.TryParse(Console.ReadLine(), out float p3);
            Console.WriteLine("4cu fenn: ");
            float.TryParse(Console.ReadLine(), out float p4);
            Console.WriteLine("5ci fenn: ");
            float.TryParse(Console.ReadLine(), out float p5);

            float ortalama = (p1 + p2 + p3 + p4 + p5) / 4;

            if (ortalama < 51)
            {
                Console.WriteLine("Kesildiniz..");
            }
            else if (ortalama > 51 && ortalama <= 90)
            {
                Console.WriteLine("Orta Netice");
            }
            else
            {
                Console.WriteLine("Ela Netice");
            }
        }
    }
}

//5
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double faiz = 0.12;
            Console.WriteLine("Eded daxil edin");
            string ededtext = Console.ReadLine();
            double.TryParse(ededtext, out double mebleg);
            Console.WriteLine("Nece il saxlayacagsan");
            string iltext = Console.ReadLine();
            double.TryParse(iltext, out double il);
            double gelecekmebleg = mebleg * (1 + faiz * il);
            Console.WriteLine(gelecekmebleg);
        }
    }
}

//6
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mesafe daxil edin");
            string ededtext = Console.ReadLine();
            double.TryParse(ededtext, out double mesafe);
            Console.WriteLine("Serf olunan yanacag");
            string yanacagtext = Console.ReadLine();
            double.TryParse(yanacagtext, out double yanacag);
            if (mesafe < 0 || yanacag < 0)
            {
                Console.WriteLine("Daxil edilen melumat yanlisdir");
            }
            else
            {
                double serfiyyat = (yanacag / mesafe) * 100;
                Console.WriteLine(serfiyyat);
            }
        }
    }
}
