using System;

public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }

        Balance -= amount;
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, initialBalance);

        Console.Write("Enter deposit amount: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        account.Deposit(depositAmount);

        Console.Write("Enter withdrawal amount: ");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        account.Withdraw(withdrawalAmount);

        account.Display();
    }
}