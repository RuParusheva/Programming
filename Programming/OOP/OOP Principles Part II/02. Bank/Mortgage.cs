using System;

public class Mortgage : Account
{
    public Mortgage(Customer customer, decimal balance, decimal interestRate, uint validityInMonths = 6)
        : base(customer, balance, interestRate, validityInMonths)
    {

    }
    public override decimal CalculateInterest()
    {
        if (ValidityInMonths <= 6 && Customer is Individual)
        {
            return 0;
        }

        if (ValidityInMonths <= 12 && Customer is Company)
        {
            return (InterestRate/2) * ValidityInMonths;
        }

        return base.CalculateInterest();
    }
}
