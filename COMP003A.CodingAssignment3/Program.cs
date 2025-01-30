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

            // Perform operations based on user's choice 
            switch (menuChoice)
            {
                case 1:
                    Console.Write("Enter the Expense name: ");
                    string expenseName1 = Console.ReadLine();
                    Console.Write("Enter the Expense amount: ");
                    double expenseAmount1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Expense added successfully!");
                    
                    // Menu choices again in case user wants to add another expense
                    Console.WriteLine("\nMenu:\n1. Add an Expense\n2. View Expenses and Budget\n3. Remove an Expense\n4. Exit");
                    Console.Write("Enter your choice (1-4): ");
                    int menuChoice = int.Parse(Console.ReadLine());

                    // Perform operations based on user's choice 
                    switch (menuChoice)
                    {
                        case 1:
                            Console.Write("Enter the Expense name: ");
                            string expenseName2 = Console.ReadLine();
                            Console.Write("Enter the Expense amount: ");
                            double expenseAmount2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Expense added successfully!");
                    
                    
                    
                    
                            break; 
                        case 2:

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
                    
                    
                    
                    break; 
                case 2:
                    Console.WriteLine("Expenses: ");
                    Console.WriteLine(expenseName1);
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
}