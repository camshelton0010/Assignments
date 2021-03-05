using System;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            int anothervariable = MyMethod();

            Console.WriteLine(anothervariable);
        }

        public static int MyMethod()
        {
            int var2 = 12345;

            return var2;
        }
    }
}
