using System;

public class Loan : Account
{
    public Loan(Customer customer, decimal balance, decimal interestRate, uint validityInMonths = 6)
        : base(customer, balance, interestRate, validityInMonths)
    {

    }

    public override decimal CalculateInterest()
    {
        if (ValidityInMonths <= 3 && Customer is Individual)
        {
            return 0;
        }
        if (Customer is Individual && ValidityInMonths > 3)
        {
            return InterestRate * (ValidityInMonths - 3);
        }
        if (ValidityInMonths <= 2 && Customer is Company)
        {
            return 0;
        }
        return InterestRate * (ValidityInMonths - 2);
    }
}
