using System;

namespace Lab3_NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            int numAnalyzer = 2;
            bool validNum = false;
            bool again = true;

            int userNum;

            Console.WriteLine("Hello! So we can get to know each other, what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello, " + userName);


            while (again)
            {
                Console.WriteLine("Please enter a whole number between 1 and 100");

                //loop to check user input and verify that it's a whole integer value
                while(!int.TryParse(Console.ReadLine(), out userNum))
                {
                    Console.WriteLine("Please enter a whole number between 1 and 100");
                    Console.WriteLine("int while");
                }


                //loop to make sure the number entered is between 1 and 100
                while (userNum < 0 || userNum > 100)
                {
                    Console.WriteLine("Please enter a whole number between 1 and 100");
                    userNum = int.Parse(Console.ReadLine());
                }

                if (userNum > 0 && userNum <= 100)
                {
                    validNum = true;

                    while (validNum)
                    {
                        if (userNum % numAnalyzer > 0)
                        {
                            Console.WriteLine(userNum + " odd.");
                            validNum = false;
                        }
                        else if (userNum % numAnalyzer == 0 && userNum >= 2 && userNum < 25)
                        {
                            Console.WriteLine("even and less than 25");
                            validNum = false;
                        }
                        else if (userNum % numAnalyzer == 0 && userNum > 25)
                        {
                            Console.WriteLine(userNum + " even.");
                            validNum = false;
                        }
                    }
                }

                Console.WriteLine("Would you like to check another number? (y/n)");
                string checkAgain = Console.ReadLine();
                checkAgain.ToLower();

                if (checkAgain == "y")
                    again = true;
                else if (checkAgain == "n")
                    again = false;
                else
                {
                    Console.WriteLine("Would you like to check another number? (y/n)");
                    checkAgain = Console.ReadLine();
                }

            }
        }
    }
}
