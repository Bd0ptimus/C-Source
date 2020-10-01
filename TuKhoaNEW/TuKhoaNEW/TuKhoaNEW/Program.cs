using System;

namespace VirtualVaOverride
{
    /********************************************************************************************************************************************************************************/
    /*Khi Compile he thong, ta co the thay, trong class Base co ham Display() trong lop Derived cung co Display()-nhung dc de trang thai AN (new) => Ta khong the truy cap vao Display() cua class Derived vi no da bi An di               */            
    /********************************************************************************************************************************************************************************/
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
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
        public void Display()
        {
            Console.WriteLine("Test New={0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Person p2 = new Employee("Tom", "New");
            p2.Display(); // вызов метода Display из класса Person

            Console.ReadKey();
        }
    }
}
