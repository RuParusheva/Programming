using System;

public class Deposit : Account
{
    public Deposit(Customer customer, decimal balance, decimal interestRate, uint validityInMonths = 6)
        : base(customer, balance, interestRate, validityInMonths)
    {
        if (balance < 0)
        {
            throw new ArgumentOutOfRangeException("balance", "Balance for deposit accounts cannot be 0 or less than 0");
        }
    }

    public override decimal CalculateInterest()
    {
        if (Balance < 1000)
        {
            return 0;
        }
        return base.CalculateInterest();
    }

    public decimal WithdrawMoney(decimal amountToWithDraw)
    {
        if (Balance < amountToWithDraw)
        {
            throw new InvalidOperationException(
                "Operation cannot be completed as the amount to withdraw exceeds current account balance.");
        }
        return Balance -= amountToWithDraw;
    }
}
