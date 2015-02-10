/* Task 04. Write a script that finds the maximal increasing sequence in an array.
Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}. */

var sequence = [3, 2, 3, 4, 2, 2, 4];
var maxlength = 0;
var maxIndex = 0;

for (var i = 0; i < sequence.length - 1; i++) {
    var currentIndex = i;
    var currentLength = 1;

    for (var j = i + 1; j < sequence.length; j++) {
        if (sequence[i] > sequence[j] || sequence[i] === sequence[j]){
            break;
        }
        else {
            if (currentLength >= maxlength){
                currentLength +=1;
                maxlength = currentLength;
                maxIndex = currentIndex;
            }
        }
    }
}

var result = [];

for (var i = maxIndex; i < maxIndex + maxlength; i++) {
    result.push(sequence[i]);
}

document.write('The maximal increasing sequence is: ' + result.join(', '));