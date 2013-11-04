public class Frog : Animal
{
    public Frog(string name, int ageInYears, Sex sex)
        : base(name, ageInYears, sex)
    {
    }

    public override string ProduceSound()
    {
        return "Quak";
    }
}