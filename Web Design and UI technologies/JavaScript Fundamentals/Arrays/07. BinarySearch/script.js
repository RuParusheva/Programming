/* Task 07. Write a program that finds the index of given element in a sorted array of integers by using
the binary search algorithm (find it in Wikipedia).*/

var sequence = [9, 17, 234, -5, 0, 21, 916, 14, 0, 3];

sequence.sort(function (a, b) {
    return a - b;
});

document.write('Values of the sorted sequence are: ' + sequence.join(', '));

var end = sequence.length;
var start = 0;
var currentIndex;
var targetNumber = -5;
var numberIndex;
var isFound = false;

while (start + 1 < end){
    currentIndex = Math.round((start + end) / 2);

    if (sequence[currentIndex] > targetNumber){
        end = currentIndex;
    }
    else {
        start = currentIndex;
    }
    if (sequence[start] === targetNumber){
        isFound = true;
        numberIndex = start;
    }
}

if (isFound){
    document.write('<p>' + 'The index of the required number is: ' + numberIndex + '</p>');
}
else {
    document.write('<p>' + 'The number is not present in this collection. Try a different value!' + '</p>')
}
