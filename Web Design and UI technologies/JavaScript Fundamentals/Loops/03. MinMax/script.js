/*Task 03. Write a script that finds the max and min number from a sequence of numbers. */

var array = [6, 888, 5453535, 677878, -3.7, 99, 6778787, -9999.5];

var min = Math.min.apply(Math, array); // Math.min(6, 888, ...);
var max = Math.max.apply(Math, array); // Math.max(6, 888, ...);

alert('Min: ' + min + '; Max: ' + max + ';');
