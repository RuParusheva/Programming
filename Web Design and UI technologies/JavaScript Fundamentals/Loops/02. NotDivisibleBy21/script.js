/*Task 02. Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time*/

function printNumbers() {
    var lastNumber = parseInt(document.forms[0]['last-number'].value, 10);

    for (var i = 1; i <= lastNumber; i++) {
        var isDivisible = false;
        if (i % 21 === 0) {
            isDivisible = true;
        }

        if (!isDivisible) {
            document.write('<p>' + i + '</p>');
        }
    }

    return false;
}