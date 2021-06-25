using System;

namespace ConsoleApp1
{
     static  class  Program
     {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            //Program oobj = new Program();

             Console.WriteLine("Hello World!");

             int res= Program .Add(10,20);
             int i = Program.sub(20,10);

             Console.WriteLine(+res);
             Console.WriteLine(i);
        }
    }
}
