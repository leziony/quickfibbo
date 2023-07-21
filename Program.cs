using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int lastnumber = 1;
            int secondtolast = 0;
            for (int i = 0; i <= 50; i++) {
                if (i == 0) { continue; }
                else if (i == 1) 
                {
                    number = 1;

                }
                else { 
                    
                    number = lastnumber + secondtolast;
                    secondtolast = lastnumber;
                    lastnumber = number;
                }
                Console.WriteLine(number);
            }

        }
    }
}