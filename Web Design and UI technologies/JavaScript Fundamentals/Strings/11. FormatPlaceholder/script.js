/*Task 11. Write a function that formats a string using placeholders:
 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';
 The function should work with up to 30 placeholders and all types
 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */

function stringFormat(format) {
    var result = format;

    for (var i = 0; i < arguments.length - 1; i++) {
        result = result.replace(new RegExp('\\{' + i + '\\}', 'g'), arguments[i + 1]);
    }

    return result;
}

console.log(stringFormat('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));
