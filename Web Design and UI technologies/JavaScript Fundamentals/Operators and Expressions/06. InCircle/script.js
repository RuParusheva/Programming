/* Task 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5). */

var circleRadius = 5;

var pointX1 = 3;
var pointY1 = 1;

//var pointX1 = 4.8;
//var pointY1 = 4.8;

var distance = Math.pow(pointX1, 2) + Math.pow(pointY1, 2);
var radiusSquared = Math.pow(circleRadius, 2);

if (distance < radiusSquared) {
    document.write('<p class="within-circle">' + 'Point IS within the circle!' + '</p>');
} else if (distance === radiusSquared) {
    document.write('<p class="on-circle">' + 'Point is ON the circle.' + '</p>');
} else {
    document.write('<p class="outside-circle">' + 'Point is NOT within the circle.' + '</p>');
}