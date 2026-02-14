public class BankingService
{
    private decimal lastTransactionAmount = 0;

    public decimal GetBalance(decimal balance)
    {
        return balance;
    }

    public bool Deposit(ref decimal balance, decimal amount)
    {
        if (amount <= 0)
            return false;

        balance += amount;
        lastTransactionAmount = amount;
        return true;
    }

    public void Withdraw(ref decimal balance, decimal amount, out bool success)
    {
        if (amount <= 0 || amount > balance)
        {
            success = false;
            return;
        }

        balance -= amount;
        lastTransactionAmount = amount;
        success = true;
    }

    public decimal GetLastTransaction()
    {
        return lastTransactionAmount;
    }
}

