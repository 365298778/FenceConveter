using System;

namespace TestFencePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Create By CxzLabel ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please input mode  (encrypt or decrypt)");
            string mode = Console.ReadLine();
            if ("encrypt".Equals(mode))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter the context");
                string info = Console.ReadLine();
                FenceUtils.ENCRYPT(info);
            }
            else if ("decrypt".Equals(mode))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter the context");
                string info = Console.ReadLine();
                FenceUtils.DECRYPT(info);
            }
        }
    }
}
