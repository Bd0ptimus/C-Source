using System;

namespace TyprConversion
{
    class Base
    {
        public string name { get; set; }
        public Base(string Name)
        {
            name = Name;
        }
    }

    class Derived : Base
    {
        public string company { get; set; }
        public Derived(string Name, string Company) : base(Name)
        {
            company = Company;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived Obj = new Derived("Dung", "Mos");
            //Upcasting:
            Base ObjBase = Obj;


            //Downcasting
            Derived ObjDe = (Derived)ObjBase;


            //Hien thi
            Console.WriteLine("Obj sau khi Upcasting = {0}, {1}", ObjBase.name, Obj.company); 
            Console.WriteLine("Obj sau khi Downcasting = {0}, {1}", ObjDe.company, ObjDe.name);


            //Ep kieu du lieu, Do ObjBase chi co kieu Base nen ko the goi bien company. Co the ep kieu cua ObjBase ve kieu Derived de goi bien commpany ((Derived)ObjBase).company
            Console.WriteLine("ObjBase sau khi ep kieu ve Derived = {0}", ((Derived)ObjBase).company);
        }
    }
}
