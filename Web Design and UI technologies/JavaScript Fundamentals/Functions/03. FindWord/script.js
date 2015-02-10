/* Task 03. Write a function that finds all the occurrences of word in a text
 * The search can be case sensitive or case insensitive
 * Use function overloading
 */

function isPunctuation(char) {
    var punctuationChars = [' ', '\n', '\r', ',', '.', ';', '?', '!'];

    if (punctuationChars.indexOf(char) !== -1) {
        return true;
    }
    return false;
}

function splitText(text) {
    var wordStartIndex = 0;
    var words = [];

    for (var i = 0; i < text.length; i++) {
        var c = text[i];

        if (isPunctuation(c)) {
            var wordEndIndex = i;
            var word = text.substring(wordStartIndex, wordEndIndex);
            words.push(word);
            wordStartIndex = wordEndIndex + 1;
        }
    }

    return words;
}

function numberOfOccurrences(words, word, isCaseSensitive) {
    var counter = 0;
    if (arguments.length === 2) {
        isCaseSensitive = false;
    }

    for (var i = 0; i < words.length; i++) {
        if (isCaseSensitive) {
            if (words[i] === word) {
                counter++;
            }
        } else {
            if (words[i].toLowerCase() === word.toLowerCase()) {
                counter++;
            }
        }
    }

    return counter;
}

document.write('<p>' + numberOfOccurrences(splitText('JSON is a very baD Bad BAD doge.'), 'bAd')+ '</p>');