/* Task 07. Write a function that returns the index of the first element in array that is bigger than its neighbors,
or -1, if there’s no such element. Use the function from the previous exercise. */

function getFirstIndexOfBigger(array){
    for (var i = 0; i < array.length; i++) {
        if (i !== 0 && i !== array.length - 1) {
            if (array[i] > array[i - 1] && array[i] > [i + 1]) {
                return i;
            }
        }
    }
    return - 1;
}

document.write('The first index which fulfills the condition is: ' + getFirstIndexOfBigger([2, 1, 8, 5, 3, 1]));


