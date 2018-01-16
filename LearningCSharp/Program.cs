using System;
using System.Speech.Synthesis;

namespace LearningCSharp
{ 
    
    class Program
    {    
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();
            book.NameChanged = new NameChangeDelegate(OnNameChanged);

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
            //  SpeechSynthesizer synth = new SpeechSynthesizer();
            // synth.Speak("I am Revi Bennett, the greatest Radical ever in the world. I commnad the world.");

            book.Name = "Revi's GradeBook";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
      
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            Console.ReadKey();

           
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " +result );
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void OnNameChanged (string existingName, string newName)
        {
            Console.Write($"Grade Book changing name from {existingName} to {newName}");
        }
    }
}
