/*Task 03. Write a script that finds the maximal sequence of equal elements in an array.
 Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}. */

var sequence = [2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 2, 2, 1];

var maxLength = 0;
var maxIndex = 0;

for (var i = 0; i < sequence.length; i++) {
    var currentLength = 1;
    var currentIndex = i;

    for (var j = i + 1; j < sequence.length - 1; j++) {
        if (!(sequence[i] === sequence[j])) {
            break;
        }
        else {
            currentLength += 1;

            if (currentLength >= maxLength) {
                maxLength = currentLength;
                maxIndex = currentIndex;
            }
        }
    }
}

var result = [];
for (var i = 0; i < maxLength; i++) {
    result.push(sequence[maxIndex]);
}

document.write('The maximal sequence is: ' + result.join(', ') + '.');