/*Task 02. Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d).
 Example of incorrect expression: )(a+b)).
 */

function checkBrackets(str) {
    var openingCount = 0;
    var closingCount = 0;

    var firstOpeningIndex = str.indexOf('(');
    var firstClosingIndex = str.indexOf(')');

    if (firstClosingIndex < firstOpeningIndex) {
        return false;
    }

    for (var i = 0; i < str.length; i++) {
        var c = str[i];

        if (c === '(') {
            if (closingCount > openingCount) {
                return false;
            }

            openingCount++;
        } else if (c === ')') {
            closingCount++;
        }
    }

    if (openingCount !== closingCount) {
        return false;
    }

    return true;
}

console.log(checkBrackets('((a + b) / 5 - d)'));
console.log(checkBrackets('))(()('));
