/* Task 04. Sort 3 real values in descending order using nested if statements. */

var firstValue = parseFloat(prompt('Enter first value: '));
var secondValue = parseFloat(prompt('Enter second value: '));
var thirdValue = parseFloat(prompt('Enter third value: '));

if (firstValue >= secondValue) {
    if (firstValue >= thirdValue) {
        if (secondValue >= thirdValue) {
            document.write('Numbers in descending order are: ' + firstValue + '; ' + secondValue + '; ' + thirdValue);
        } else {
            document.write('Numbers in descending order are: ' + firstValue + '; ' + thirdValue + '; ' + secondValue);
        }
    } else {
        document.write('Numbers in descending order are: ' + thirdValue + '; ' + firstValue + '; ' + secondValue);
    }
} else if (secondValue >= firstValue) {
    if (secondValue >= thirdValue) {
        if (firstValue >= thirdValue) {
            document.write('Numbers in descending order are: ' + secondValue + '; ' + firstValue + '; ' + thirdValue);
        } else {
            document.write('Numbers in descending order are: ' + secondValue + '; ' + thirdValue + '; ' + firstValue);
        }
    } else {
        document.write('Numbers in descending order are: ' + thirdValue + '; ' + secondValue + '; ' + firstValue);
    }
} else {
    if (secondValue >= firstValue) {
        document.write('Numbers in descending order are: ' + thirdValue + '; ' + secondValue + '; ' + firstValue);
    } else {
        document.write('Numbers in descending order are: ' + thirdValue + '; ' + firstValue + '; ' + secondValue);
    }
}