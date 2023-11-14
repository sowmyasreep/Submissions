using System;

class Accounts

{

     int Account_No;

     string Customer_Name;

     string Account_Type;

     char Transaction_Type;

     double Amount;

     double Balance;



    public Accounts(int acc_no, string customerName, string acc_type, char TT, double amount)

    {

        Account_No = acc_no;

        Customer_Name = customerName;

        Account_Type = acc_type;

        Transaction_Type = TT;

        Amount = amount;

        Balance = 25000; // Initialize the balance to some value

    }



    public void Credit(double amount)

    {

        Balance += amount;

    }



    public void Debit(double amount)

    {

        if (Balance >= amount)

        {

            Balance -= amount;

        }

        else

        {

            Console.WriteLine("We are sorry, Insufficient balance for withdrawal.");

        }

    }



    public void ShowData()

    {

        Console.WriteLine("Account Number: " + Account_No);

        Console.WriteLine("Customer Name: " + Customer_Name);

        Console.WriteLine("Account Type: " + Account_Type);

        Console.WriteLine("Transaction Type: " + Transaction_Type);

        Console.WriteLine("Amount: " + Amount);

        Console.WriteLine("Balance: " + Balance);

    }



    public static void Main(string[] args)

    {

        Console.Write("PLease enter Account Number: ");

        int accountNo = int.Parse(Console.ReadLine());



        Console.Write(" Please  enter the  Customer Name: ");

        string customerName = Console.ReadLine();



        Console.Write("Please enter the  Account Type: ");

        string accountType = Console.ReadLine();



        Console.Write("Enter Transaction Type (D for Deposit, W for Withdrawal): ");

        char transactionType = char.ToUpper(Console.ReadKey().KeyChar);



        Console.WriteLine(); 



        Console.Write("Enter Amount: ");

        double amount = double.Parse(Console.ReadLine());



        Accounts acc = new Accounts(accountNo, customerName, accountType, transactionType, amount);

        if (acc.Transaction_Type == 'D')

        {

            acc.Credit(acc.Amount);

        }

        else if (acc.Transaction_Type == 'W')

        {

            acc.Debit(acc.Amount);

        }

        // Display account information

        acc.ShowData();

    }

}