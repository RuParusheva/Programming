/*Task 03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
Kittens and tomcats are cats. All animals are described by age, name and sex. 
Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/

using System;

internal class Test
{
    private static void Main()
    {
        var animals1 = new Animal[]
        {
            new Frog("Ali Baba", 3, Sex.Male),
            new Dog("Roro", 8, Sex.Male)
        };

        var animals2 = new Animal[]
        {
            new Dog("Neru", 5, Sex.Male),
            new Dog("Sharo", 10, Sex.Male),
            new Dog("Tigrica", 8, Sex.Female),
            new Dog("Topcho", 12, Sex.Male), 
            new Frog("Kikirica", 7, Sex.Female),
            new Tomcat("Prydlio", 7),
            new Kitten("Snezhka", 1)
        };

        var animals3 = new Animal[]
        {
            new Kitten("Mishi", 1),
            new Frog("Alisa", 4, Sex.Female),
            new Dog("Max", 10, Sex.Male)
        };

        foreach (var animals in new[] { animals1, animals2, animals3 })
        {
            var ages = Animal.GetAverageAge(animals);

            foreach (var age in ages)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine();
        }

        foreach (ISoundProducer soundProducer in animals2)
        {
            Console.WriteLine("{0} said {1}.", soundProducer, soundProducer.ProduceSound());
        }
    }
}