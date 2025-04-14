using System.ComponentModel;

class Program
{
    static void Main()
    {
        BankAcount acount = new BankAcount("Fernando", 100);
        acount.Deposito(-50);
        Console.WriteLine("Acount balance: " + acount.Balance);
        BankAcount acount1 = new BankAcount("Tania", 100);
        acount1.Deposito(100);
        Console.WriteLine("Acount1 balance: " + acount1.Balance);

    }
}

class BankAcount
{
    private string name;
    private decimal balance;

    public decimal Balance
    {
        get{return balance;}

    }

    public string Name
    {
        get {return name;}
        
    }
    
    

    public BankAcount(string name, decimal balance)
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
        this.balance = balance;
    }

    public void Deposito(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }
        balance += amount;
    }



}