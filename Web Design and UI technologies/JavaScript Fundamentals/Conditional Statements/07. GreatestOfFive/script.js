/* Task 07. Write a script that finds the greatest of given 5 variables. */

var array = [ 18, 55, 21, 1, 9 ];
array.sort(function (a, b) {
    return a - b;
});

document.write('The greatest number is: ' + array[4]);
