/*Task 01. Write a JavaScript function that reverses string and returns it.
Example: "sample"  "elpmas". */

function reverseString(str) {
    var result = '';

    for (var i = str.length - 1; i >= 0; i--) {
        var c = str[i];
        result += c;
    }

    return result;
}

var str = 'sample';
console.log(reverseString(str));
