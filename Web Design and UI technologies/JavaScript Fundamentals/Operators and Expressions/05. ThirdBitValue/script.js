/* Task.05 Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0. */

var number = Math.floor(Math.random() * 100000);
var position = 2;
document.write('<p class="number">'+ 'Number is: ' + number + '</p>');

var binaryNum = number.toString(2);
document.write('<p class="binary">' + 'Its binary representation is: ' + binaryNum + '</p>');

if (binaryNum.charAt(position) === '1'){
    document.write('<p>' + 'The third bit value equals: ' + '</p>' + '<img class="one" src="One.jpg" alt="image of digit one"/>');
}
else {
    document.write('<p>' + 'The third bit value equals: ' + '</p>' + '<img class="zero" src="Zero.jpg" alt="image of digit zero"/>');
}