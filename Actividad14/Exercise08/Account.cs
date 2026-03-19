namespace Actividad14.Exercise08
{
    public class Account(string holder, decimal initialBalance)
    {
        public string Holder { get; } = holder;
        public decimal Balance { get; private set; } = initialBalance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Titular: {Holder} | Saldo: {Balance:C}");
        }
    }
}