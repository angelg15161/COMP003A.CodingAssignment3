/*
    Author: Angel Gomez
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: Budget management application demonstrating control flow.
*/
namespace COMP003A.CodingAssignment3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Budget Management Tool! \n");

        string expenseName1 = "";
        double expenseAmount1 = 0;
        
        
        // Prompt the user for their monthly income 
        Console.Write("Enter your monthly income: ");
        double monthlyIncome = double.Parse(Console.ReadLine());
        
        bool exit = false;
        while (!(exit))
        {
            // Menu choices 
            Console.WriteLine("\nMenu:\n1. Add an Expense\n2. View Expenses and Budget\n3. Remove an Expense\n4. Exit");
            Console.Write("Enter your choice (1-4): ");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 4)
            {
                exit = true;
            }
            else if (menuChoice == 1)
            {
                Console.Write("Enter the Expense name: ");
                string expenseName1 = Console.ReadLine();
                Console.Write("Enter the Expense amount: ");
                double expenseAmount1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Expense added successfully!");
            }
            
        }
            
            
            // Perform operations based on user's choice 





            /*
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid" + e);
                throw;
            }
            */




            /*
            try
            {
                switch (menuChoice)
                {
                    case 1:
                        Console.Write("Enter the Expense name: ");
                        string expenseName1 = Console.ReadLine();
                        Console.Write("Enter the Expense amount: ");
                        double expenseAmount1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Expense added successfully!");


                        break;
                    case 2:
                        Console.WriteLine("Expenses: ");
                        Console.WriteLine($"{expenseName1});
                        break;
                    case 3:

                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice, please select a number 1-4.");
                        break;
                }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            */



            /*
            if (menuChoice == 1)
            {
                Console.Write("Enter the Expense name: ");
                string expenseName1 = Console.ReadLine();
                Console.Write("Enter the Expense amount: ");
                double expenseAmount1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Expense added successfully!");
            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("Expenses: ");
                Console.WriteLine($"{expenseName1}");
            }
            else if (menuChoice == 3)
            {

            }
            else if (menuChoice == 4)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("\nInvalid choice, please select a number 1-4.");
            }
            */



            /*
            switch (menuChoice)
            {
                case 1:
                    Console.Write("Enter the Expense name: ");
                    string expenseName1 = Console.ReadLine();
                    Console.Write("Enter the Expense amount: ");
                    double expenseAmount1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Expense added successfully!");


                    break;
                case 2:
                    Console.WriteLine("Expenses: ");
                    Console.WriteLine($"{expenseName1});
                    break;
                case 3:

                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice, please select a number 1-4.");
                    break;
            }
            */

            //Console.Write("Enter the Expense name: ");
            //string[] expenseNames = new string[5];
            //expenseNames[1] = Console.ReadLine();

            //string expenseName = Console.ReadLine();

            //Console.Write("Enter the expense amount:");
            //double expenseAmount = double.Parse(Console.ReadLine());
            //Console.WriteLine("Expense added successfully!");

            // string expense1 = "0";
            // string expense2 = "0";
            // string expense3 = "0";
            // string expense4 = "0";
            // string expense5 = "0";

            // string[] expenseNames = new string[5];
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write($"Enter value for element {i + 1}: ");
            //     expenseNames[i] = Console.ReadLine();
            // }
        
        
        
    }
}