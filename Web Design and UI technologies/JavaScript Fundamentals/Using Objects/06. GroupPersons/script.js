/*Task 06. Write a function that groups an array of persons by age, first or last name. The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups
 Use function overloading (i.e. just one function)*/

var persons = [
    new Person('Pesho', 'Poparkov', 7),
    new Person('Pesho', 'Cholakov', 77),
    new Person('Ganka', 'Gliganka', 20),
    new Person('Ganka', 'Kotanka', 20),
    new Person('Misha', 'Kotkova', 2),
    new Person('Kotka', 'Kotkova', 29)
];

function group(persons, prop) {
    var result = {};

    for (var i = 0; i < persons.length; i++) {
        var person = persons[i];
        var value = person[prop];

        if (!(value in result)) {
            result[value] = [];
        }

        result[value].push(person);
    }

    return result;
}

console.log(group(persons, 'firstName'));
console.log(group(persons, 'age'));
console.log(group(persons, 'lastName'));