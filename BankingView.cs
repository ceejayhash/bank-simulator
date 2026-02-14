using System;

public class BankingView
{
    public void ShowHeader(string name)
    {
        Console.WriteLine("=== Simple ATM System ===");
        Console.WriteLine(name);
    }

    public void ShowInitialBalance(decimal balance)
    {
        Console.WriteLine($"Initial Balance: ₱{balance:F2}");
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nATM Menu:");
        Console.WriteLine("1: Check Balance");
        Console.WriteLine("2: Deposit Money");
        Console.WriteLine("3: Withdraw Money");
        Console.WriteLine("4: Print Mini Statement");
        Console.WriteLine("5: Exit");
        Console.Write("Select option: ");
    }

    public void DisplayBalance(decimal balance)
    {
        Console.WriteLine($"Current Balance: ₱{balance:F2}");
    }

    public void ShowDepositSuccess(decimal balance)
    {
        Console.WriteLine("Deposit successful.");
        Console.WriteLine($"Updated Balance: ₱{balance:F2}");
    }

    public void ShowWithdrawSuccess(decimal balance)
    {
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine($"Updated Balance: ₱{balance:F2}");
    }

    public void ShowInsufficientBalance()
    {
        Console.WriteLine("Withdrawal failed. Insufficient balance.");
    }

    public void ShowInvalidAmount(string type)
    {
        Console.WriteLine($"Invalid {type} amount. Please enter a positive value.");
    }

    public void ShowInvalidOption()
    {
        Console.WriteLine("Invalid option selected. Please try again.");
    }

    public void ShowMiniStatement(decimal balance, decimal lastTransaction)
    {
        Console.WriteLine("--- Mini Statement ---");
        Console.WriteLine($"Current Balance: ₱{balance:F2}");
        Console.WriteLine($"Last Transaction Amount: ₱{lastTransaction:F2}");
    }

    public void ShowExitMessage()
    {
        Console.WriteLine("Thank you for using the ATM. Goodbye!");
    }
}
