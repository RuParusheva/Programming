/*Task 01. Write functions for working with shapes in  standard Planar coordinate system
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending
 L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points
 Check if three segment lines can form a triangle*/

function Point(pointX, pointY) {
    this.pointX = pointX;
    this.pointY = pointY;
}

function Line(startPoint, endPoint) {
    this.startPoint = startPoint;
    this.endPoint = endPoint;
}

// Pythagorean Theorem
Line.prototype.length = function () {
    var horizontalDistance = this.endPoint.pointX - this.startPoint.pointX;
    var verticalDistance = this.endPoint.pointY - this.startPoint.pointY;
    var distance = Math.sqrt((Math.pow(horizontalDistance, 2))
        + (Math.pow(verticalDistance, 2)));

    return distance;
}

// if the sum of any two sides is greater than the third -> triangle exists
function formTriangle(firstLine, secondLine, thirdLine) {
    if ((arguments[0].length() + arguments[1].length()) > arguments[2].length() &&
        (arguments[1].length() + arguments[2].length()) > arguments[0].length() &&
        (arguments[0].length() + arguments[2].length()) > arguments[1].length()) {
        return true;
    }

    return false;
}

var firstPoint = new Point(-2, -3);
var secondPoint = new Point(-4, 4);
var firstLine = new Line(firstPoint, secondPoint);
var secondLine = new Line(new Point(2, 1), new Point(3, 8));
var thirdLine = new Line(new Point(4, 2), new Point(1, 7));


console.log(firstLine);
console.log('Length of all lines: first line - ' + firstLine.length()
    + ', second line - ' + secondLine.length() + ', third line -  ' + thirdLine.length());
console.log(formTriangle(firstLine, secondLine, thirdLine));
