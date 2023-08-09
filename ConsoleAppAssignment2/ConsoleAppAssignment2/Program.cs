using System;
using System.Collections.Generic;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Create a one dimensional Array of strings.
            string[] wordstart =
            {
                "Welcome to The ",
                "I'm Principal, ",
                "Our goal is to provide our students with a "
            };
            string[] wordend =
            {
                " Academy.",
                ",",
                " learning experience."
            };
            List<string> responses = new List<string>();
            //Asks the user to input answers
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of someone famous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective");
            responses.Add(Console.ReadLine());
            //Creates a loop that goes through each string in Array, adding users text to the string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings we used:");
            //Creates a loop that prints each string in the array on seperate line.
            for (int i = 0; i < wordstart.Length; i++)
            {
                //Part 2
                //Created infinite loop.
                //Fixed the loop.
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();

            //Part 3
            Console.WriteLine("Is that a ghost?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            //Creating a loop where the comparison that's used to determine to continue iterating the loop("<" operator).
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");
            //Adds loop where comparison thats used to determine to continue iterating the loop ("<=" operator).
            while (ahh.Length <= 10)
            {
                ahh.Append("h");
            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();

            //Part 4
            //Creating a list of strings where each item is unique.
            List<string> teams = new List<string>()
                { "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
                    "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers"
                };
            Console.WriteLine("NBA Eastern Conference Standings");
            //Asks user to input text to search in the list.
            Console.WriteLine("Enter team nickname:");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //Creates a loop that iterates through the list and displays the index of the array that contains matching text on the console.
            while (!isValid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (String team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //Add code to that above loop that tells user if they input text that isn't in the list.
                if (standing == 0)
                {
                    Console.WriteLine("That is not a valid Eastern Conference team name. Try again:");
                }
                //Add code to that above loop that stops it from continuing once match has been found.
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing);
            Console.ReadLine();

            //Part 5
            //Creates a list of strings that has two identical strings in the lisat.
            List<string> tables = new List<string>()
                {
                    "Reserved", "Vacant", "Taken", "Vacant", "Reserved", "Taken"
                };
            Console.WriteLine("Welcome to Tasty Taco's! \nDUE to COVID-19, we use a computerized check-in.\nIf you have a reservation type " +
                "\"Reserved\".\nIf you are joining a party that is has arrived type \"Taken\".\nOtherwise type \"Vacant\".");
            //Asks the user to select text to search for answer in list.
            Console.WriteLine("Enter selection:");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //Add code that tells user if they put in text that isn't in our list.
                Console.WriteLine("Please enter one of the three choices:");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The tables that match your selection are numbered:");
            //Create a loop that iterates through the loops then displays the indices of the array that contain matching text on the console
            for (int i3 = 0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            //Part 6
            //Creating a list of strings that have two idenntical strings in the list.
            List<string> names = new List<string>()
                {
                    "Nick", "Jack", "Tiffany", "Nick", "Kat", "Sydney", "Sydney"
                };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Class of 2023:");
            //Creating foreach loop that evaluates every item in the list and diplays message showing string and whether or not it has already appeared in list
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \nUse last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }

    }