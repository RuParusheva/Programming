/*Task 10. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe". */

var text = 'The most familiar palindromes, in English at least, are character-by-character: The written characters read the same backward as forward. Some examples of common palindromic words: civic, radar, level, rotor, kayak, reviver, racecar, redder, madam, malayalam, and refer. There are also palindromes where the unit of reversal is the word ("So patient a doctor to doctor a patient so") or line (as in the poem "Doppelganger" by J.A. Lindon). These are referred to as "word-unit palindromes" and "line-unit palindromes" respectively. Word-unit palindromes were popularized in the recreational linguistics community by J.A. Lindon in the 1960s, but occasional examples in English are found from at least the 19th century, and several in French and Latin date to the Middle Ages';

function isPunctuation(char) {
    var punctuationChars = [' ', '\n', '\r', ',', '.', ';', '?', '!', '"', '\'', ':', '-', '(', ')'];

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
            if (word !== '') {
                words.push(word);
            }
            wordStartIndex = wordEndIndex + 1;
        }
    }

    return words;
}

function reverseString(str) {
    var result = '';

    for (var i = str.length - 1; i >= 0; i--) {
        var c = str[i];
        result += c;
    }

    return result;
}

function isPalindrome(word) {
    if (word.length < 2) {
        return false;
    }

    if (word !== reverseString(word)) {
        return false;
    }

    return true;
}

var words = splitText(text);
console.log(words.filter(isPalindrome));