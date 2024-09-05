using CSharp;

namespace CSharp
{
    class A
    {
        public string Name;
        public int Class;
        public int Roll;

        public void PrintA()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Class :" + Class);
            Console.WriteLine("Roll :" + Roll);
        }
    } 

    class B : A
    {

        public string CollegeName;
        public string location;

        public void PrintB()
        {
            Console.WriteLine("CollegeName : " + CollegeName);
            Console.WriteLine("location : " + location);
        }
       
    }

    class C:A
    {
        public string FName;
        public string MName;

        public  void PrintC()
        {
            Console.WriteLine("FName :" + FName);
            Console.WriteLine("MName :" + MName);
            Console.WriteLine("hello");
        }
        public static void main(string[] args)
        {
            C c = new C();
            c.Name = "Mahi";
            c.Class = 1;
            c.Roll = 2;
            c.PrintA();

            B b = new B();
            b.CollegeName = "GMPS";
            b.location = "Himmatpur Block";

            b.PrintB();

            c.FName = "Y";
            c.MName = "V";

            c.PrintC();

            //Console.WriteLine("");
        }
    }
}


