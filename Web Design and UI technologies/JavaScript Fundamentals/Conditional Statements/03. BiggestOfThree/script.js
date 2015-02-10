/* Task 03. Write a script that finds the biggest of three integers using nested if statements. */

var firstValue = parseInt(prompt('Enter first number'));
var secondValue = parseInt(prompt('Enter second number'));
var thirdValue = parseInt(prompt('Enter third number'));

if (firstValue > secondValue && firstValue > thirdValue) {
   document.write('<p>' + 'The biggest number is: ' + firstValue + '</p>');
} else if (secondValue > firstValue && secondValue > thirdValue) {
    document.write('<p>' + 'The biggest number is: ' + secondValue + '</p>');
} else {
    document.write('<p>' + 'The biggest number is: ' + thirdValue + '</p>');
}