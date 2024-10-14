using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accountNumber)
        : base(accountNumber)
    {
    }

    // Метод для поповнення рахунку
    public void Popovnyty_Rahunok(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Рахунок {AccountNumber} поповнено на {amount} грн.");
    }

    // Метод для зняття коштів
    public void Znyaty_z_Rahunku(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"З рахунку {AccountNumber} знято {amount} грн.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів на рахунку.");
        }
    }
}

