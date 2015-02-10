/* Task 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7
 and 5 in the same time. */

var number = Math.floor(Math.random() * 1000);
//var number = 35;
var i;

for (i = 1; i <= 10; i++) {
    number += i * i;
    if (number % 35 === 0) {
        document.write('<p class="divisible">' + 'Number is divisible by 5 and 7 at the same time:' + ' ' + number +
            '</p>');
    } else {
        document.write('<p class="not-divisible">' + 'Number is NOT divisible by 5 and 7 at the same time:' + ' ' +
            number + '</p>');
    }
}