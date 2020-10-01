using System;

namespace FirstStruct
{
    struct FirstStruct
    {
        public int a;
        public int b;
        //KHONG dc truyen trc 1 gia tri cho 1 thuoc tinh (bien) ben trong struct- dieu nay se gay loi
        //VD:  public int b=10; => LOI [X]
        public void show()
        {
            Console.WriteLine("a={0}; b={1}", a, b);
        }
    }


    //Phuong phap Goi Struct nhung khong truyen tham so thi tat ca cac thuoc tinh ben trong struct thi se mang gia tri 0
    class Program
    {
        static void Main(string[] args)
        {
            FirstStruct hello = new FirstStruct();
            hello.show();
        }
    }

    //Phuong phap goi Struct thong thuong
    /*
    class Program
    {
        static void Main(string[] args)
        {
            FirstStruct hello;
            hello.a = 10;
            hello.b = 20;
            hello.show();
        }
    }
    */
}
