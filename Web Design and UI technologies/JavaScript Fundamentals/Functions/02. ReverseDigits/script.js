/* Task 02. Write a function that reverses the digits of given decimal number.
Example: 256  652 */

function reverseNumber(number) {
    var numberAsString = number.toString();
    var reversed = [];

    for (var i = numberAsString.length - 1; i >= 0; i--) {
        var currentDigit = numberAsString[i];
        reversed.push(currentDigit);
    }

    return reversed.join('');
}

var number = 256;
document.write('Number: ' + number + '; Reversed: ' + reverseNumber(number));
