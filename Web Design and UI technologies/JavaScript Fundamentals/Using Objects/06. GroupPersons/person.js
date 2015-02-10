function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

Person.prototype.toString = function() {
    return 'Name: ' + this.firstName + ' ' + this.lastName + '; Age: ' + this.age + ';';
};
