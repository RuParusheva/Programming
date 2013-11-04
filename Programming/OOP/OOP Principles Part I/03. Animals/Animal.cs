using System.Collections.Generic;
using System.Linq;

public abstract class Animal : ISoundProducer
{
    public string Name { set; get; }

    public decimal Age { get; set; }

    public Sex Sex { get; set; }

    protected Animal(string name, decimal age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        return string.Format("Type: {3}, Name: {0}, Age: {1}, Sex: {2}",
            this.Name, this.Age, this.Sex, GetType().Name);
    }

    public static IDictionary<string, decimal> GetAverageAge(Animal[] animals)
    {
        return animals.GroupBy(x => x.GetType()).ToDictionary(
            x => x.Key.Name,
            x => x.Average(y => y.Age)
        );
    }
}