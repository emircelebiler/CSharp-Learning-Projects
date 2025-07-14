using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int balance = 1000;
// We'll ask the user which action they want to perform:
// 1 - View balance
// 2 - Withdraw money
// 3 - Deposit money
// If the user presses 'q', the program will exit

Console.WriteLine("Welcome to the ATM");
Console.WriteLine("Please select the operation you want to perform");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("Your current balance is: " + balance);
    Console.ReadLine();
}
else if (choice == "2")
{
    Console.WriteLine("Enter the amount you want to withdraw:");
    int withdrawAmount = Convert.ToInt32(Console.ReadLine());

    if (withdrawAmount <= balance)
    {
        Console.WriteLine("Remaining balance: " + (balance - withdrawAmount));
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("You cannot withdraw more than your current balance.");
        Console.ReadLine();
    }
}
else if (choice == "3")
{
    Console.WriteLine("Enter the amount you want to deposit:");
    int depositAmount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Your new balance is: " + (balance + depositAmount));
    Console.ReadLine();
}
else if (choice == "q")
{
    Console.WriteLine("Logging out from the ATM...");
    Console.WriteLine("Exited.");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please enter a valid option.");
    Console.ReadLine();
}








        }
    }
}
