using System;

namespace rings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! I am here to help you with rings!");
            Console.WriteLine("Rules are very simple! You will write num\n" +
                "and I will write table of sums and prods in\n" +
                "modular ring of this num.");

            bool number_inputed = false;
            int modular = 0;
            while (!number_inputed)
            { 
                number_inputed = Int32.TryParse(Console.ReadLine(), out modular);
                if (!number_inputed)
                {
                    Console.WriteLine("Try again!");
                }
            }

            Ring my_ring = new Ring(modular);
            my_ring.print_sums();
            my_ring.print_prods();
            if (my_ring.is_field()) 
            {
                Console.WriteLine("Looks like field...");
            }
            else
            {
                Console.WriteLine("Ohhhh, no field there.");
            }
        }
    }
}
