using System;
/* KHI BASE class khong co Constructor
namespace ConstructorInDerivedClass
{
    class BASE
    {
    }
    class DERIVED : BASE
    {
        public string Name;
        public DERIVED(string name)
        {
            Name = name;
        }

        public void show()
        {
            Console.WriteLine("Name : {0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DERIVED Obj = new DERIVED("Dung");
            Obj.show();
        }
    }
}
*/

//KHI BASE class co Constructor
namespace ConstructorInDerivedClass
{
    class BASE
    {
        public int Age;
        public BASE(int age)
        {
            Age = age;
        }
        public void showA()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }
    class DERIVED : BASE
    {
        public string Name;
        public DERIVED(string name, int age):base(age)
        {
            Name = name;
        }

        public void show()
        {
            Console.WriteLine("Name : {0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DERIVED Obj = new DERIVED("Dung",20);
            Obj.show();
            Obj.showA();
        }
    }
}