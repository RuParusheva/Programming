public class Kitten : Cat
{
    public Kitten(string name, int ageInYears)
        : base(name, ageInYears, Sex.Female)
    {
    }

    public override string ProduceSound()
    {
        return "Mi-mi-mi";
    }
}