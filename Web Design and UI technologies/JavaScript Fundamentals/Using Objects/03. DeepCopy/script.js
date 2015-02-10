/*Task 03. Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types */

function makeDeepCopy(object) {
    var deepCopy = JSON.parse(JSON.stringify(object));

    return deepCopy;
}

function Person(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;
}

Person.prototype.toString = function() {
    return this.firstName + ' ' + this.lastName;
};

var original = new Person('Ivan', 'Draganov');
var copy = makeDeepCopy(original);
console.log(original.toString());
console.log(copy.toString());

copy.lastName = 'Petkanov';
original.lastName = 'Ivanov';
console.log(original);
console.log(copy);