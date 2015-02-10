/* Task 05. Write script that asks for a digit and depending on the input shows the name of that digit
 (in English) using a switch statement. */

var digit = parseInt(prompt('Enter a digit (0-9):'));

if (digit >= 0) {
    switch (digit) {
        case 0:
            document.write('<p>' + 'I am zero and I look like this: ' + '</p>' + '<img src="digits_zero.jpg" alt="zero"/>');
            break;
        case 1:
            document.write('<p>' + 'I am one and I look like this: ' + '</p>' + '<img src="digits_one.jpg" alt="one"/>');
            break;
        case 2:
            document.write('<p>' + 'I am two and I look like this: ' + '</p>' + '<img src="digits_two.jpg" alt="two"/>');
            break;
        case 3:
            document.write('<p>' + 'I am three and I look like this: ' + '</p>' + '<img src="digits_three.jpg" alt="three"/>');
            break;
        case 4:
            document.write('<p>' + 'I am four and I look like this: ' + '</p>' + '<img src="digits_four.jpg" alt="four"/>');
            break;
        case 5:
            document.write('<p>' + 'I am five and I look like this: ' + '</p>' + '<img src="digits_five.jpg" alt="five"/>');
            break;
        case 6:
            document.write('<p>' + 'I am six and I look like this: ' + '</p>' +'<img src="digits_six.jpg" alt="six"/>');
            break;
        case 7:
            document.write('<p>' + 'I am seven and I look like this: ' + '</p>' + '<img src="digits_seven.jpg" alt="seven"/>');
            break;
        case 8:
            document.write('<p>' + 'I am eight and I look like this: ' + '</p>' +'<img src="digits_eight.jpg" alt="eight"/>');
            break;
        case 9:
            document.write('<p>' + 'I am nine and I look like this: ' + '</p>' +'<img src="digits_nine.jpg" alt="nine"/>');
            break;
        default:
            document.write('<p class="out-of-scope">' + 'Value is out of scope for this program. Enter a digit between 0-9!!!' + '</p>');
            break;
    }
}
else {
    document.write('<p class="not-recognized">' + 'Value has not been recognized! Please try again!!!' + '</p>');
}