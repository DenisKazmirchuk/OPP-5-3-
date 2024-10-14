using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepositAccount : BankAccount
{
    public DepositAccount(string accountNumber)
        : base(accountNumber)
    {
    }

    // Метод для поповнення рахунку (можливо без можливості зняття)
    public void Popovnyty_Rahunok(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Депозитний рахунок {AccountNumber} поповнено на {amount} грн.");
    }

    // Метод для зняття коштів (як правило, недоступний для депозиту, але можна додати)
    public void Znyaty_z_Rahunku(double amount)
    {
        Console.WriteLine("Зняття коштів з депозитного рахунку недоступне до закінчення строку.");
    }
}

