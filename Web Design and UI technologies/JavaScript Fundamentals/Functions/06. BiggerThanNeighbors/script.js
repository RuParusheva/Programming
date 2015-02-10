/* Task 06. Write a function that checks if the element at given position in given array of integers
 is bigger than its two neighbors (when such exist). */

function isBigger(array, position) {

    for (var i = 0; i < array.length; i++) {
        if (i !== 0 && i !== array.length - 1) {
            if (array[position] > array[position - 1] && array[position] > [position + 1]) {
                return true;
            }
        }
    }

    return false;
}

var testValue = isBigger([19, 8, 564, 1, 3, 18, 2], 5);

if (testValue) {
    document.write('The number at the required position is bigger than its neighbors.');
} else {
    document.write('The number at this position is either not comparable with two neighbors or is not bigger than them.');
}