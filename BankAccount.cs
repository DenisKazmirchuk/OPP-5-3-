using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount : IAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
    }

    // Реалізація методу Novyi_Rahunok з інтерфейсу IAccount
    public void Novyi_Rahunok()
    {
        Console.WriteLine($"Новий рахунок {AccountNumber} відкрито.");
    }

    // Реалізація методу Vydalyty_Rahunok з інтерфейсу IAccount
    public void Vydalyty_Rahunok()
    {
        Console.WriteLine($"Рахунок {AccountNumber} видалено.");
    }

    // Метод для відображення поточного балансу
    public void ShowBalance()
    {
        Console.WriteLine($"Баланс рахунку {AccountNumber}: {Balance} грн.");
    }
}
