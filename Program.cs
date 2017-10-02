using System;

namespace wizard_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            wizard merlin = new wizard("merlin");
            samurai kenshin = new samurai("kenshin");
            ninja sasuke = new ninja("sasuke");
            Console.WriteLine("Hello World!");
             Console.WriteLine(merlin);
              Console.WriteLine(kenshin);
               Console.WriteLine(sasuke);
            
        }
    }
}
