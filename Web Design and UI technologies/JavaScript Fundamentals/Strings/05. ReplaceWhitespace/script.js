/*Task 05. Write a function that replaces non breaking white-spaces in a text with &nbsp;*/

function replaceWhiteSpace(text) {
    var result = '';

    for (var i = 0; i < text.length; i++) {
        if (text[i] === ' ' && text[i - 1] === ' ') {
            result += '&nbsp;';
        } else {
            result += text[i];
        }
    }

    return result;
}

console.log(replaceWhiteSpace('a  b23   c'));