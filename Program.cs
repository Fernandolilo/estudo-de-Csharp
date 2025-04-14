﻿using System.ComponentModel;

class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger("myLog.txt");
        BankAcount acount = new BankAcount("Fernando", 100, logger);
        acount.Deposito(-50);
        Console.WriteLine("Acount balance: " + acount.Balance);
        BankAcount acount1 = new BankAcount("Tania", 100, logger);
        acount1.Deposito(100);
        Console.WriteLine("Acount1 balance: " + acount1.Balance);




        //podemos tambem criar um metodo anonimo veja o ex:

        //lambda 
        var div =  (int x, int y) => x/y;

        Console.WriteLine(div(50,10));

        // lambda
        var test =  (string names) => Console.WriteLine($"Olá {names}");
        test("Fernando Silva");

        //lambda
        Func<decimal> test2 = ()=>  5.7m;
        Console.WriteLine(test2());

        Func<string, bool> chackName= nomes =>  nomes == "Fernando";
        Console.WriteLine(chackName("Tania"));
    }

    static void Run(Func<int, int, int> calc)
    {
        Console.WriteLine(calc(20, 30));
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
    }
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOGGER: {message}");
    }
}

interface ILogger
{
    void Log(string message);
}

class BankAcount
{
    private string name;
    private readonly ILogger logger;
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }

    }

    public string Name
    {
        get { return name; }

    }



    public BankAcount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Nome invalido.", nameof(name));
        }
        if (balance <= 0)
        {
            throw new Exception("Saldo não pode ser negativo.");
        }
        this.name = name;
        this.logger = logger;
        this.balance = balance;
    }

    public void Deposito(decimal amount)
    {
        if (amount <= 0)
        {
            logger.Log($"Não é possível depositar {amount} na conta de {name}");
            return;
        }
        balance += amount;
    }



}