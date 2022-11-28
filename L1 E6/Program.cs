using System;

namespace L1_E6
{
    /* E.6 Se citesc trei numere de la tastatura, x,y,z. 
           Scrieti un program care va afisa cele trei valori in ordine descrescatoare.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Intoduceti primul numar");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Intoduceti al doile numar");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Intoduceti al treile numar");
            z = int.Parse(Console.ReadLine());

            
            if (x > y)
            {
                if (x > z)
                { 
                    if (y > z)
                    {
                        Console.WriteLine($"{x},{y},{z}");
                    }
                    else
                    {
                        Console.WriteLine($"{x},{z},{y}");
                    }
                }
            }

            if (y > x)
            {
                if (y > z)
                {
                    if (x > z)
                    {
                        Console.WriteLine($"{y},{x},{z}");
                    }
                    else
                    {
                        Console.WriteLine($"{y},{z},{x}");
                    }
                }
            }

            if (z > x)
            {
                if (z > y)
                {
                    if (y > x)
                    {
                        Console.WriteLine($"{z},{y},{x}");
                    }
                    else
                    {
                        Console.WriteLine($"{z},{x},{y}");
                    }
                }
            }


        }
    }
}
