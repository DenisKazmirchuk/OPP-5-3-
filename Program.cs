class Program
{
    static void Main(string[] args)
    {
        // Створюємо поточний рахунок
        CurrentAccount currentAccount = new CurrentAccount("12345");
        currentAccount.Novyi_Rahunok();
        currentAccount.Popovnyty_Rahunok(1000);
        currentAccount.ShowBalance();
        currentAccount.Znyaty_z_Rahunku(500);
        currentAccount.ShowBalance();
        currentAccount.Vydalyty_Rahunok();

        Console.WriteLine();

        // Створюємо депозитний рахунок
        DepositAccount depositAccount = new DepositAccount("54321");
        depositAccount.Novyi_Rahunok();
        depositAccount.Popovnyty_Rahunok(5000);
        depositAccount.ShowBalance();
        depositAccount.Znyaty_z_Rahunku(1000);  // Не можна зняти з депозитного рахунку
        depositAccount.ShowBalance();
        depositAccount.Vydalyty_Rahunok();
    }
}

