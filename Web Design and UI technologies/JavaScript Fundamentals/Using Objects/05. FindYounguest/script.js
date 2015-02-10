/*Task 05. Write a function that finds the youngest person in a given array of persons and prints his/hers full name
 Each person have properties firstname, lastname and age, as shown:
 var persons = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */

var persons = [
    new Person('Pesho', 'Prostakov', 7),
    new Person('Ganka', 'Gliganka', 20),
    new Person('Misha', 'Kotkova', 2)
];

var youngestPerson = persons[0];

for (var i = 0; i < persons.length; i++) {
    var currentPerson = persons[i];

    if (currentPerson.age < youngestPerson.age) {
        youngestPerson = currentPerson;
    }
}

console.log('Youngest person: ' + youngestPerson);
