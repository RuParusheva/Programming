function solve(stringArray) {
    var numArray = stringArray.map(Number);
    var count = 1;

    for (var i = 2; i < numArray.length; i++) {

        if (numArray[i - 1] > numArray[i]) {
            count++;
        }
    }

    return count;
}

var input = ['6', '1', '3', '-5', '8', '7', '-6'];
console.log(solve(input));
