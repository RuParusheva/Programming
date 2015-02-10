/* Task 02. Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it.
 Use a sequence of if statements. */

var counter = 0;
var value = 0;
var isZero = false;

for (var index = 0; index < 3; index++) {
    value = parseFloat(prompt('Enter real number: '));

    if (value === 0) {
        isZero = true;
    } else if (value < 0) {
        counter++;
    }
}

if (isZero) {
    document.write('<p class="zero">' + 'This is: ' + '</p>' +
    '<img src="zero7_lores.jpg" alt="zero"/>');
} else if (counter % 2 == 0) {
    document.write('<p class="positive">' + 'Sign is: ' + '</p>' +
        '<img src="Signs_positive.jpg" alt="positive sign"/>');
} else {
    document.write('<p class="negative">' + 'Sign is: ' + '</p>' +
        '<img src="Signs_negative.jpg" alt="negative sign"/>');
}