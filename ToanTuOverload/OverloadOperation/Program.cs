using System;

namespace OverloadOperation
{
    class Counter
    {
        public int Value { get; set; }

        public static bool operator true(Counter c1)
        {
            Console.WriteLine("test 1");
            return c1.Value != 0;
        }
        public static bool operator false(Counter c1)
        {
            Console.WriteLine("test 2");
            return c1.Value == 0;
        }

        // остальное содержимое класса
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter() { Value = 0 };
            if (counter)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
