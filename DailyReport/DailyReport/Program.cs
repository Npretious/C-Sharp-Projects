//C# program
using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College"); //title of program
            Console.WriteLine("Student Daily Report"); //continuation of title
            Console.WriteLine("What is your name?"); //program asks your name
            string name = Console.ReadLine(); //keeps program open
            Console.WriteLine("What course are you currently on?"); //program asks what course your on
            string course = Console.ReadLine(); //keeps program open
            Console.WriteLine("What page number?"); //program asks what page number your on
            int pageNum = Convert.ToInt32(Console.ReadLine()); //converts inter and keeps program open
            Console.WriteLine("Do you need help with anything else? Answer \"true\" or \"false\"."); // beginning of boolean statement
            string needHelp = Console.ReadLine();//keeps program open
            bool needHelpBool = bool.Parse(needHelp); //continuation of boolean
            Console.WriteLine("Were there any positive experiences you'd like to share?"); //program asking about experiences
            string positiveExperiences = Console.ReadLine(); //keeps program open
            Console.WriteLine("Is there any other feedback you'd like to provide?"); //program asking about feedback
            string feedback = Console.ReadLine(); //keeps program open
            Console.WriteLine("How many hours did you study today?"); //program asking about study time
            string studyHours = Console.ReadLine(); //keeps program open
            int studyHoursNum = Convert.ToInt32(studyHours); //converts integer
            Console.WriteLine("Thank you for the answers. An instructor will reply shorty. Have an amazing day!"); //final statement
            Console.ReadLine();//keeps program open
        }
    }
}
