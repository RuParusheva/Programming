/*Task 06. Write a script that enters the coefficients a, b and c of a quadratic equation
 a*x2 + b*x + c = 0 and calculates and prints its real roots. Note that quadratic equations may have
 0, 1 or 2 real roots. */

var firstValue = parseInt(prompt('Enter first value: '));
var secondValue = parseInt(prompt('Enter second value: '));
var thirdValue = parseInt(prompt('Enter third value: '));

var root1;
var root2;

var discriminant = ((secondValue * secondValue) - (4 * firstValue * thirdValue));

//I am taking into account one special case - if a=0

if (firstValue == 0) {
    root1 = -thirdValue / secondValue;
    root2 = root1;
    document.write('One solution exists and it is: ' + root1);
}
else if (discriminant < 0) {
    //There is no solution
    root1 = NaN;
    root2 = NaN;
    document.write('Real number root is not possible!');
}
else if (discriminant == 0) {
    root1 = -secondValue / (2 * firstValue);
    root2 = root1;
    document.write('One solution exists and it is: ' + root1);
}
else {
    var sqrt = Math.sqrt(discriminant);
    root1 = (-secondValue + sqrt) / (2 * firstValue);
    root2 = (-secondValue - sqrt) / (2 * firstValue);
    document.write('Solutions to the quadratic equation are: ' + root1 + ' and ' + root2);
}