/* Task 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7.
 E. g. 1732  true. */

var value = Math.floor(Math.random() * 1000000);

if (value < 1000) {
    value += 1000;
}

document.write('<p class="digit">' + 'Digit to check: ' + value + '</p>');

var counter = 1;
var temp = 0;

while (value !== 0) {
    temp = value % 10;
    if (counter === 3 && temp === 7) {
        document.write('<p class="is">' + 'The third digit IS 7!' + '</p>');
        break;
    }
    value = Math.floor(value / 10);
    counter++;
}

if (value <= 0) {
    document.write('<p class="is-not">' + 'The number\'s third digit is NOT 7!' + '</p>');
}
