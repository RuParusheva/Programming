function solve(input) {

    var parsedInput = input.map(Number);
    var amountOfMoney = parsedInput[0];
    parsedInput.splice(0, 1);

    var result = 0;

    for (var i = 0; i < 16; i++)
    {
        var sum = 0;

        for (var j = 0; j < 5; j++)
        {
            sum += ((i >> j) & 1) * parsedInput[j];
        }
        if (sum === amountOfMoney)
        {
            counter++;
        }
   }

    return result;
}

var input = ['110', '13', '15', '17'];
console.log(solve(input))