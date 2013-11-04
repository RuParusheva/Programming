public class Dog : Animal
{
    public Dog(string name, int ageInYears, Sex sex)
        : base(name, ageInYears, sex)
    {
    }

    public override string ProduceSound()
    {
        return "Rof-rof";
    }
}