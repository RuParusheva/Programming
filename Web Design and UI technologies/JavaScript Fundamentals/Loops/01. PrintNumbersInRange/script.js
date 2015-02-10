/*Task 01. Write a script that prints all the numbers from 1 to N */

function printNumbers() {
    var lastNumber = parseInt(document.forms[0]['last-number'].value, 10);

    for (var i = 1; i <= lastNumber; i++) {
         document.write('<p>' + i + '</p>');
    }

    return false;
}