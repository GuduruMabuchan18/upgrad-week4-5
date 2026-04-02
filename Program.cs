using System;

class BankAccount
{
    // Private field (hidden)
    private double balance;

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
    }

    // Get balance method
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();

        acc.Deposit(1000);
        acc.Withdraw(300);

        Console.WriteLine("Current Balance = " + acc.GetBalance());
    }
}