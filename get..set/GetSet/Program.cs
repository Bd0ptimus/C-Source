using System;

namespace GetSet
{
    class Base
    {
        private int a=10;
        public int A
        {
            get
            {
                return a;
            }
        }

        private int b;
        public int B
        {
            set
            {
                b = value;
            }
        }
        public void showA()
        {
            Console.WriteLine("a= {0}", a);
        }

        public void showB()
        {
            Console.WriteLine("b= {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Base();
            obj.B = 20;
            obj.showA();
            obj.showB();
        }
    }
}
