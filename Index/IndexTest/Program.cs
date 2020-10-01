using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace IndexTest
{
    class Person
    {
        
        private string name;
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }

    class People
    {
        Person[] data;
       
        public People() // Neu ket hop ca Properties va Index thi can bat buoc co cai nay
        {
            data = new Person[5];
        }
        public Person this[int input]
        {
            get 
            {

                return data[input];
                
            }

            set
            {
               data[input]=value;
            }
        }

        public Person this[string name]
        {
            get
            {
                Person person = null;
                foreach (var p in data)
                {
                    if (p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person { Name = "Dungg" };
            people[1] = new Person { Number = "12391391" };
            Console.WriteLine(people[0].Name);
            Console.WriteLine(people[1].Number);
        }
    }
}
