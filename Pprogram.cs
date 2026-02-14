using System;

class Program
{
    static void Main()
    {
        decimal balance = 1000.00m;
        BankingService service = new BankingService();
        BankingView view = new BankingView();

        view.ShowHeader("Your Name Here");
        view.ShowInitialBalance(balance);

        while (true)
        {
            view.ShowMenu();
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                view.ShowInvalidOption();
                continue;
            }

            switch (choice)
            {
                case 1:
                    view.DisplayBalance(service.GetBalance(balance));
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    decimal depositAmount;
                    if (!decimal.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        view.ShowInvalidAmount("deposit");
                        continue;
                    }

                    if (!service.Deposit(ref balance, depositAmount))
                    {
                        view.ShowInvalidAmount("deposit");
                        continue;
                    }

                    view.ShowDepositSuccess(balance);
                    break;

                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdrawAmount;
                    if (!decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                    {
                        view.ShowInvalidAmount("withdrawal");
                        continue;
                    }

                    bool success;
                    service.Withdraw(ref balance, withdrawAmount, out success);

                    if (!success)
                    {
                        if (withdrawAmount <= 0)
                            view.ShowInvalidAmount("withdrawal");
                        else
                            view.ShowInsufficientBalance();

                        continue;
                    }

                    view.ShowWithdrawSuccess(balance);
                    break;

                case 4:
                    view.ShowMiniStatement(balance, service.GetLastTransaction());
                    break;

                case 5:
                    view.ShowExitMessage();
                    return;

                default:
                    view.ShowInvalidOption();
                    break;
            }
        }
    }
}
