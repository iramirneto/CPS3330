using Average;

namespace TestRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, ave, user;
            do
            {
                Console.WriteLine("Average Calculation:");
                Console.Write("How many number do you want to enter " +
                    "(2 or 3):");
                user = Convert.ToDouble(Console.ReadLine());

                if (user == 2)
                {
                    do
                    {
                        Console.Write("Enter first number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (a < 0 || b < 0)
                            Console.WriteLine("Please enter a positive number!");
                    } while (a < 0 || b < 0);

                    ave = Average.NumAve.MyAve(a, b);
                }
                else if (user == 3)
                {
                    do
                    {
                        Console.Write("Enter first number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the third number: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        if (a < 0 || b < 0 || c < 0)
                            Console.WriteLine("Please enter a positive number!");
                    } while (a < 0 || b < 0 || c < 0);

                    ave = Average.NumAve.MyAve(a, b, c);
                }
                else
                {
                    Console.Write("Only calculates the average of 2 or 3 numbers.");
                }

                // Ask the user if they want to calculate again
                Console.Write("Do you want to calculate again? (yes/no): ");
                string response = Console.ReadLine().ToLower();

                if (response != "yes")
                    break;

            } while (true);
        }
    }
}