using System;

namespace rings
{
    public class Ring
    {
        private int RingBase { get; set; }
        private int[,] SumsTable { get; set; }
        private int[,] ProdsTable { get; set; }

        public Ring(int ring_base)
        {
            RingBase = ring_base;
            SumsTable = new int[RingBase, RingBase];
            ProdsTable = new int[RingBase, RingBase];

            for (int i = 0; i < RingBase; i++)
            {
                for (int j = 0; j < RingBase; j++)
                {
                    SumsTable[i, j] = (i + j) % RingBase;
                    ProdsTable[i, j] = (i * j) % RingBase;
                }
            }
        }

        public void print_sums()
        {
            Console.Write("\t");
            for (int i = 0; i < RingBase; i++)
            {
                Console.Write(i.ToString() + "\t");
            }
            Console.Write("\n");

            for (int i = 0; i < RingBase; i++)
            {
                Console.Write(i.ToString());
                for (int j = 0; j < RingBase; j++)
                {
                    Console.Write("\t" + SumsTable[i, j].ToString());
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void print_prods()
        {
            Console.Write("\t");
            for (int i = 0; i < RingBase; i++)
            {
                Console.Write(i.ToString() + "\t");
            }
            Console.Write("\n");

            for (int i = 0; i < RingBase; i++)
            {
                Console.Write(i.ToString());
                for (int j = 0; j < RingBase; j++)
                {
                    Console.Write("\t" + ProdsTable[i, j].ToString());
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public bool is_field()
        {
            bool is_field = true;

            for (int i = 1; i < RingBase; i++)
            {
                for (int j = 1; j < RingBase; j++)
                {
                    if (ProdsTable[i, j] == 0)
                    {
                        is_field = false;
                    }
                }
            }

            return is_field;
        }
    }
}
