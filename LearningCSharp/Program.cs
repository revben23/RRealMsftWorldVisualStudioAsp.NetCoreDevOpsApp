using System;


namespace LearningCSharp
{ 
    
    class Program
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("What Is Your Name?");
            string name= Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How Many Hours of Sleep Did You Get Last Night? " + name);
            int hourOfSleep = int.Parse(Console.ReadLine());
            if (hourOfSleep > 7)
            {
                Console.WriteLine("You Are Well Rested");
            }
            else
            {
                Console.WriteLine("You Need More Sleep");
            }
               
            
            Console.ReadKey();
        }
    }
}
