using System;

namespace ClassAbstract
{
    abstract class Person
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

    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Khi su dung class Abstract thi se khong the tao Object cho no dc
            //Các dong ben duoi se khong gay loi vi chung tao Object cho 2 class DERIVED chu ko phai class Abstract
            Person client = new Client("Tom", 500); 
            Person employee = new Employee("Bob", "Операционист");
            client.Display();
            employee.Display();

            //Se gay loi Neu : Person person = new Person ("Bill");

        }
    }
}
