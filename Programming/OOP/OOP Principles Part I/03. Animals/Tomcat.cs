public class Tomcat : Cat
{
    public Tomcat(string name, int ageInYears)
        : base(name, ageInYears, Sex.Male)
    {
    }

    public override string ProduceSound()
    {
        return "Mauuu";
    }
}