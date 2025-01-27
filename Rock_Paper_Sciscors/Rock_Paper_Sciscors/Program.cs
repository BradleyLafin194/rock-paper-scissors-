using System;
using System.Linq.Expressions;

namespace in_class_activity
{
    internal class Program
    {

        public static int Run()
        {
            //possible outcomes array 
            string[] choice = new string[3];

            choice[0] = "rock"; //rock
            choice[1] = "paper"; //paper
            choice[2] = "scicors"; // scicosrs
            // computer choice 
            // Random object
            Random rnd = new Random();

            // Get random index
            int index = rnd.Next(choice.Length);

            // Print random choice
            // Console.WriteLine(choice[index]);
            //  Console.WriteLine(index);


            //variables 
            string up;
            int CP;
            string Final;

            //user input 
            Console.WriteLine("1=rock, 2=paper, 3=sciscors");
            up = Console.ReadLine();
            //convert user input to int 32 
            int UP = System.Convert.ToInt32(up);

            //switch for user choice 
            switch (UP)
            {
                case 1:
                    Final = "rock";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you tie");
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you lose");
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you win");
                    }
                    // code block
                    break;
                case 2:
                    Final = "paper";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you win");//rock
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you tie");//paper
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you lose");//sciscors
                    }
                    // code block
                    break;
                case 3:
                    Final = "sciscors";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you lose");//rock
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you win");//paper
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you tie");//sciscors
                    }
                    break;
                default:
                    Console.WriteLine("did not enter possible choice");
                    // code block
                    break;
            }

            return 1;
        }
      /*  public static int Computer()
        {
            //possible outcomes array 
            string[] choice = new string[3];

            choice[0] = "rock"; //rock
            choice[1] = "paper"; //paper
            choice[2] = "scicors"; // scicosrs
            // computer choice 
            // Random object
            Random rnd = new Random();

            // Get random index
            int index = rnd.Next(choice.Length);

            // Print random choice
            // Console.WriteLine(choice[index]);
            //  Console.WriteLine(index);
            Player(index);
            return 1;
            
        }
      */
      /*
        public static int Player(string aString)
        {
            
            //variables 
            string up;
            int CP;
            string Final;

            //user input 
            Console.WriteLine("1=rock, 2=paper, 3=sciscors");
            up = Console.ReadLine();
            //convert user input to int 32 
            int UP = System.Convert.ToInt32(up);

            //switch for user choice 
            switch (UP)
            {
                case 1:
                    Final = "rock";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you tie");
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you lose");
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you win");
                    }
                    // code block
                    break;
                case 2:
                    Final = "paper";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you win");//rock
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you tie");//paper
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you lose");//sciscors
                    }
                    // code block
                    break;
                case 3:
                    Final = "sciscors";
                    Console.WriteLine("your choice " + Final);
                    Console.WriteLine("computer choice " + choice[index]);
                    if (index == 0)
                    {
                        Console.WriteLine("you lose");//rock
                    }
                    if (index == 1)
                    {
                        Console.WriteLine("you win");//paper
                    }
                    if (index == 2)
                    {
                        Console.WriteLine("you tie");//sciscors
                    }
                    break;
                default:
                    Console.WriteLine("did not enter possible choice");
                    // code block
                    break;
            }

            return 1;
        }
      */


        static void Main(string[] args)
        {

            // Computer();
            // Player();
            Run();

        }
    }
}