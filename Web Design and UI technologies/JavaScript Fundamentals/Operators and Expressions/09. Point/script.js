/* Task 09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
 and out of the rectangle R(top=1, left=-1, width=6, height=2). */

var circleX = 1;
var circleY = 1;
var radius = 3;

var rectangleTop = 1;
var rectangleLeft = -1;
var width = 6;
var height = 2;

var pointX = 3;
var pointY = 1;

var inCircle = false;

if (Math.pow(circleX - pointX, 2) + Math.pow(circleY - pointY, 2) < Math.pow(radius, 2)){
    inCircle = true;
} else {
    document.write('<p class="outside-circle">' + 'The point isn\'t within the circle, thus the other condition has not been checked.' + '</p>');
}

if (inCircle){
    if ((rectangleLeft < pointX && pointX < (rectangleLeft + width)) &&
        ((rectangleTop - height) < pointY && pointY < rectangleTop)) {
        document.write('<p class="inside-rectangle">' + 'The point is within the circle and INSIDE of the rectangle.' + '</p>');
    } else {
        document.write('<p class="outside-rectangle">' + 'The point is within the circle and OUTSIDE of the rectangle.' + '</p>');
    }
}
