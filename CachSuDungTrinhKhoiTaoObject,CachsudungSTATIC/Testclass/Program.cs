//Khi Ham Tao Khong Co Tham So Truyen Vao Thi Moi Dc Su Dung Trinhf Khoi Tao Object BASE Test = new BASE {a=10, b=11};
/*
using System;

namespace Testclass
{
    class BASE
    {
        public int a;
        public int b;
        public BASE()
        {
        }
        public void show()
        {
            Console.WriteLine("a={0}; b={1}", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BASE Test = new BASE {a=10, b=11};
            Test.show();
        }
    }
}*/




//KHi trong ham tao co tham so thi su dung trinh tao object binh thuong ntn 
using System;
using ClassLibrary1;

namespace Testclass
{
    class BASE
    {
        public static int a;
        public int b;
        public BASE(int c, int d)
        {
            a = c;
            b = d;
        }

        public void show()
        {
            Console.WriteLine("a={0}; b={1}", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BASE Test = new BASE ( 10, 11 );
            Test.show();
            Class1 hello = new Class1();
            hello.showInDll();
            Console.WriteLine("a={0}", BASE.a); // KHi a co static thi moi co the goi len bang cach BASE.a con khi a KHONG co thi phai goi len bang cach Object.a

        }
    }
}