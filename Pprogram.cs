namespace ATMApp.Services
{
    public class BankingServices
    {
        private decimal balance = 1000.00m;
        private decimal lastTransaction = 0;

        public decimal Balance()
        {
            return balance;
        }

        public bool deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            balance += amount;
            lastTransaction = amount;
            return true;
        }

        public bool withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
                return false;

            balance -= amount;
            lastTransaction = amount;
            return true;
        }

        public decimal GetLastTransaction()
        {
            return lastTransaction;
        }
    }
}
