/* Task 02. Write a script that compares two char arrays lexicographically (letter by letter). */

function getStrings() {
    var firstString = document.forms[0]['first-string'].value;
    var secondString = document.forms[0]['second-string'].value;
    compareChars(firstString, secondString);
    return false;
}

function checkLength(firstString, secondString) {
    if (firstString.length > secondString.length ||
        secondString.length > firstString.length) {
        return document.write('The strings do not have equal length. Enter different values!');
    }
    else {
        return firstString.length;
    }
}

function compareChars(firstString, secondString) {
    var count = checkLength(firstString, secondString);
    String.empty();

    for (var i = 0; i < count; i++) {
        var current = '';

        if (firstString.charAt(i) > secondString.charAt(i)) {
            current = firstString.charAt(i);
        }
        else if (firstString.charAt(i) === secondString.charAt(i)) {
            current = 'the values are equal';
        }
        else {
            current = secondString.charAt(i);
        }

        var result = document.write('<p>' + 'The bigger char lexicographically is: '
            + current + '</p>');
    }
}
