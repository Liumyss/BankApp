using System;
using BankApp.App.Directing;

namespace BankApp.Program
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("==========================================");
            Console.WriteLine("                 WELCOME");
            Console.WriteLine("==========================================");

            var isWorking = true;

            try
            {
                while (isWorking)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nType x and press Enter to terminate all operation \nType 1 and press Enter to make deposit into your account \nType 2 and press Enter to make a withdrawal from an account \nType 3 and press Enter to check your balance \nType 4 and press Enter to see your transactions \nType 5 and press Enter to create a new Customer");
                    Console.ForegroundColor = ConsoleColor.White;
                    var response = Console.ReadLine();

                    if (response != null)
                    {
                        switch (response)
                        {
                            case "x":
                                isWorking = false;
                                break;

                            case "1":
                                Operations.Deposit();
                                break;

                            case "2":
                                Operations.Withdraw();
                                break;

                            case "3":
                                Operations.Balance();
                                break;
                                // case 4 Transactions / case 5 Create Customer ?
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
