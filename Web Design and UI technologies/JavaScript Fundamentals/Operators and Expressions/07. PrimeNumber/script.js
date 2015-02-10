/* Task 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime. */

var primesToTen = [];
var primesToHundred = [];

for (var i = 2; i < 11; i++) {
    var current = i;
    var isPrime = true;

    for (var j = 2; j < 11; j++) {
        if (current !== j && current % j === 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        primesToTen.push(current);
        primesToHundred.push(current);
    }
}

for (var i = 11; i < 101; i++) {
    var current = i;
    var isPrime = true;

    for (var j = 0; j < primesToTen.length; j++) {
        if (current % primesToTen[j] === 0) {
            isPrime = false;
            break;
        }
    }
    if (isPrime) {
        primesToHundred.push(current);
    }
}

document.write('<p>' + 'The prime numbers from 1 to 100 are: ' + primesToHundred.join(', ') + '.' + '</p>');