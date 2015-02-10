/* Task 01. Assign all the possible JavaScript literals to different variables.*/

var stringLiteral = 'I am a string!';
function displayString(){
    alert(stringLiteral);
}

var integerLiteral = 123;
function displayInteger() {
 alert(integerLiteral);
}

var floatingPoint = 12.666678;
function displayFloatingPoint() {
    alert(floatingPoint);
}

var stringArray = ['apple', 'cherry', 'watermelon', 'pear', 'orange', 'strawberry'];
 function displayArray(){
        alert(stringArray.join(', ' ));
 }

var booleanLiteral = true;
function displayBoolean() {
    alert(booleanLiteral);
}

var person = { firstName: "Leah", lastName: "McFall", age: 23, profession: "Singer" };
function displayObject() {
    alert('Name: ' + person.firstName + ' ' +  person.lastName + '\nAge: ' + person.age + '\nProfession: ' + person.profession)
}

