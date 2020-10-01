using System;

namespace VirtualVaOverride
{
    /********************************************************************************************************************************************************************************/
    /*Neu bo virtual o dong public virtual void Display() va override o  public override void Display() thi se chi hien thi Display() o class BASE                                  */
    /********************************************************************************************************************************************************************************/
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
        public override void Display()
        {
            Console.WriteLine("Test Virtual={0}",Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Person p2 = new Employee("Tom","New");
            p2.Display(); // вызов метода Display из класса Person

            Console.ReadKey();
        }
    }
}
