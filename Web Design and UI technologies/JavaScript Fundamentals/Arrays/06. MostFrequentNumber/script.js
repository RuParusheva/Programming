/*Task 06. Write a program that finds the most frequent number in an array. Example:
 {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times) */

var sequence = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

var maxCount = 1;
var maxRepeated;

for (var i = 0; i < sequence.length - 1; i++) {
    var currentCount = 1;
    for (var j = i + 1; j < sequence.length; j++) {
        if (sequence[i] === sequence[j]){
            currentCount+=1;
        }
        if (currentCount >= maxCount){
            maxCount = currentCount;
            maxRepeated = sequence[i];
        }
    }
}

document.write('The most frequent number in the collection is: ' + maxRepeated +
' and it is repeated ' + maxCount + ' times.' )