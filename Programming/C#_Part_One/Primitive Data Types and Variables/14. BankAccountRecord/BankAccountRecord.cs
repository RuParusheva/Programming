/*Task 14. A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep 
the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountRecord
{
    static void Main()
    {
        string firstName = "Firstname";
        string middleName = "Middlename";
        string lastName = "Lastname";
        decimal accountBalance = 235.00m;
        string bankName = "Unicredit Bulbank";
        object iBAN = "BG80BNBG96611020345678";
        string bIC = "BGUNCRSF";
        ulong firstCreditCard = 3088000000000009;
        ulong secondCreditCard = 601100055500000004;
        ulong thirdCreditCard = 5500000000000004;
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Account balance: {0}", accountBalance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("BIC code: {0}", bIC);
        Console.WriteLine("First Credit card: {0}", firstCreditCard);
        Console.WriteLine("Second Credit card: {0}", secondCreditCard);
        Console.WriteLine("Third Credit card: {0}", thirdCreditCard);
    }
}

