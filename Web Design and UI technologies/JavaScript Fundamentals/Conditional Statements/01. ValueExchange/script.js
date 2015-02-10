/* Task 01. Write an if statement that examines two integer variables and exchanges their values if the first one
is greater than the second one. */

var firstValue = 8;
var secondValue = 5;

if (firstValue > secondValue){
    var temp = secondValue;
    secondValue = firstValue;
    firstValue = temp;
}

document.write('<p>' + 'Exchange has been performed: first value = ' + firstValue + ', second value = ' + secondValue + '.' + '</p>');