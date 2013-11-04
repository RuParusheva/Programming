using System;

public abstract class Account
{
    private Customer customer;
    private decimal balance;
    private decimal interestRate;
    private uint validityInMonths;

    public Customer Customer
    {
        get { return this.customer; }
        protected set { this.customer = value; }
    }

    public decimal Balance
    {
        get { return this.balance; }
        protected set { this.balance = value; }
    }

    public decimal InterestRate
    {
        get { return this.interestRate; }
        protected set
        {
            if (value < 0)
            {
                throw  new ArgumentException("Interest rate cannot be negative!");
            }

            this.interestRate = value;
        }
    }

    public uint ValidityInMonths
    {
        get { return this.validityInMonths; }
        protected set { this.validityInMonths = value; }
    }

    protected Account(Customer customer, decimal balance, decimal interestRate, uint validityInMonths = 6)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
        this.ValidityInMonths = validityInMonths;
    }

    public decimal DepositMoney(decimal amountToDeposit)
    {
        return this.Balance += amountToDeposit;
    }

    public virtual decimal CalculateInterest()
    {
        return (this.InterestRate * this.ValidityInMonths);
    }

    public override string ToString()
    {
        return string.Format("Customer details:{0} \nBalance:{1};\nInterest rate:{2};\nCalculated interest based on validity:{3}",
            this.Customer,this.Balance, this.InterestRate, this.CalculateInterest());
    }
}
