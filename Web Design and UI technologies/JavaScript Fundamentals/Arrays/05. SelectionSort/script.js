/* Task 05. Sorting an array means to arrange its elements in increasing order. Write a script to sort an array.
 Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest
 from the rest, move it at the second position, etc.
 Hint: Use a second array */

var sequence = [1, 19, 88, -5, 999, 611, 455, 3, 0, 3];
var removed;

document.write('<p>' + 'Sequence values before sorting: ' + sequence.join(', ') + '</p>')

for (var i = 0; i < sequence.length - 1; i++) {
    var indexOfSmallest = i;

    for (var j = i + 1; j < sequence.length; j++) {
        if (sequence[i] >= sequence[j] && sequence[indexOfSmallest] >= sequence[j]){
            indexOfSmallest = j;
        }
    }
    removed = sequence.splice(indexOfSmallest, 1)[0];
    sequence.splice(i , 0, removed);
}

document.write('<p>' + 'Sequence values after sorting: ' + sequence.join(', ') + '</p>');