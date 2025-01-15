# rock-paper-scissors-
C# rock paper scissors console application
using System.Linq.Expressions;

namespace in_class_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            string up ;
            int CP = 0;
            string ch;
            //possible outcomes array 
            string[] choice=new string[3];

            choice[0] = "rock";
            choice[1] = "paper";
            choice[2] = "sciscor";
            // computer choice 
            // Random object
            Random rnd = new Random();

            // Get random index
            int index = rnd.Next(choice.Length);

            // Print random animal
            Console.WriteLine(choice[index]);

            //user input 
            Console.WriteLine("enter choice");
            up = Console.ReadLine();

            //convert user input to int 32 
            int UP = System.Convert.ToInt32(up);
            //switch for user choice 
            switch (UP)
            {
                case 1:
                    ch = "rock";
                    Console.WriteLine("rock");
                    // code block
                    break;
                case 2:
                    ch = "paper";
                    Console.WriteLine("paper");
                    // code block
                    break;
                case 3:
                    ch = "sciscors";
                    Console.WriteLine("sciscors");
                    break;
                default:
                    // code block
                    break;
            }
            //output 
            Console.WriteLine(CP);
            
        }
    }
}
