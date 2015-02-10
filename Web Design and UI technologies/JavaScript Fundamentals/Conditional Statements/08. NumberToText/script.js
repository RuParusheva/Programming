/* Task 08. Write a program that converts a number in the range [0...999] to a text corresponding to its
 English pronunciation. Examples:
 0 -> 'Zero'
 273 ->'Two hundred seventy three'
 400 -> 'Four hundred'
 501 -> 'Five hundred and one'
 711 -> 'Seven hundred and eleven' */

var userInput = parseInt(prompt('Enter number:'));

var ones = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];

var exceptions = ['Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];

var tens = ['', '', 'Twenty ', 'Thirty ', 'Forty', 'Fifty ', 'Sixty ', 'Seventy ', 'Eighty ', 'Ninety '];

var text = ' ';

if (userInput >= 0 && userInput < 1000) {
    var modulo = userInput % 10;
    var divisibleByTen = parseInt(userInput / 10) % 10;
    var divisibleByHundred = parseInt(userInput / 100) % 10;

    if (divisibleByHundred != 0) {
        text = text + ones[divisibleByHundred] + ' hundred ';

        if (divisibleByTen != 0 && divisibleByTen != 1 && userInput >= 20) {
            text = text + 'and ' + tens[divisibleByTen];

            if (modulo != 0) {
                text = text + ones[modulo];
            }
        }
        else if (divisibleByTen == 1) {
            text = text + 'and ' + exceptions[modulo];
        }
        else {
            if (modulo != 0) {
                text = text + 'and ' + ones[modulo];
            }
        }
    }
    else {
        if (divisibleByTen != 0 && divisibleByTen != 1 && userInput >= 20) {
            text = text + tens[divisibleByTen] + ones[modulo];
        }
        else if (divisibleByTen == 1) {
            text = text + exceptions[modulo];
        }
        else {
            text = text + ones[modulo];
        }

    }
    document.write('<img src="decoration_upper.jpg" alt="decoration above text"/>' + '<p>'+ text + '</p>' + '<img src="decoration_bottom.jpg" alt="decoration after text"/>');
}
else {
    document.write('<p class="not-recognized">' + 'You have entered a value which is not in scope for this program. Try again!' + '</p>');
}