function solve(input) {
    var parsedInput = input.map(Number);
    parsedInput.splice(0, 1);
    var bestSum = parsedInput[0];
    var currentSum;

    for (var i = 0; i < parsedInput.length; i++) {
        currentSum = parsedInput[i];
        for (var j = i + 1; j < parsedInput.length; j++) {
            currentSum += parsedInput[j];
            if (currentSum >= bestSum) {
                bestSum = currentSum;
            }
        }
    }
    return bestSum;
}

var input = ['10', '1255569','-851435','1457629','858237','221970','-652780','1379095','-732864','-606100','1566514'];
console.log(solve(input));