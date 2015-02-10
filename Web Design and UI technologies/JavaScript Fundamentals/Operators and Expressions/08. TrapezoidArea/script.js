/* Task 08. Write an expression that calculates trapezoid's area by given sides a and b and height h. */

var baseA = Math.random() * 100 + 1;
var baseB = Math.random() * 100 + 1;
var height = Math.random() * 100 + 1;

var area = (baseA + baseB) / 2 * height;
document.write('<p>' + 'Area of a trapezoid with base A = ' + baseA + ', base B = ' + baseB + ' and height = ' + height +
    ' = ' + area + '.' + '</p>');
