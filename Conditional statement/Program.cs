using System;

namespace Conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
     
            try
            {
                String input = Console.ReadLine();
                int age = int.Parse(input);

                if (age < 18)
                {
                    Console.WriteLine("You are a minor!");
                    Console.WriteLine("Please enter your favorite toy: ");
                    String toy = Console.ReadLine();
                    Console.WriteLine("Your favorite toy is: " + toy);

                    if (toy == "ball")
                    {

                        Console.WriteLine("You like to play ball!");
                    }
                    else if (toy == "doll")
                    {
                        Console.WriteLine("You like to play doll!");
                    }
                    else
                    {
                        Console.WriteLine("Please type ball or doll: ");
                    }
                      

                
                }
                else if (age > 18 && age < 64)
                {
                    Console.WriteLine("You are an adult!");
                    Console.WriteLine("Please enter your job: ");
                    String job = Console.ReadLine();
                    Console.WriteLine("Your job is: " + job);
                }
                else 
                {
                    Console.WriteLine("You are an senior!");
                    Console.WriteLine("Please enter what you want to do when retire: ");
                    String thing = Console.ReadLine();
                    Console.WriteLine("Your want to do: " + thing);
                }

                Console.WriteLine("Press any key to exit..");
                Console.ReadKey(true);

            } // End of try
            catch
            {
                Console.WriteLine("You have an error");
            } // End of catch

        } // End of Main
    }
}
