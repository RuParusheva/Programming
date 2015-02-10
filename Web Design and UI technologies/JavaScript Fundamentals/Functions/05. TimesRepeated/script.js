/* Task 05. Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly. */


function getNumberCount(array, number) {
    var counter = 0;

    for (var i = 0; i < array.length; i++) {
        if (array[i] === number) {
            counter+= 1;
        }
    }
    return counter;
}


function testCounter(){

    for (var i = 0; i < 4; i++) {
        var result = getNumberCount([1, 10, 4, 2, 2, 0, 19, 8, 2], i);
        document.write('<p>' + 'Number of times number ' + i + ' is present in the array: ' + result + '</p>')
    }

}

testCounter();