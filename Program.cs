using System;
using System.Collections.Generic;
using System.Linq;


namespace console_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Are you an alien?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Far out dude, greetings");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Meh, boring");
            }
            else
            {
                Console.WriteLine("You had to be dificult");
            }

            // Dictionary of questions and answers
            Dictionary<string,string> questions = new Dictionary<string, string>(){
                 {"What is your favourite food?", "yummy"}, {"Where were you born?", "cracking place"}, {"What is you favourite band?", "Crap taste"} 
            };
            // create a Random object
            var rand = new Random();

            // Get a random number between 0 and legnth of dictionary fo question index
            int index = rand.Next(0, questions.Count);
            // KeyAt comes from LINQ
            string currentQuestion = questions.ElementAt(index).Key;
            string currentAnswer = questions.ElementAt(index).Value;
            Console.WriteLine(currentQuestion);
            Console.ReadLine();
            Console.WriteLine(currentAnswer);


        }
    }
}
