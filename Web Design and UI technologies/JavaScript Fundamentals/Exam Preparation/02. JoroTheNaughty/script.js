function solve(input) {

    function createMatrix(rows, cols) {

        var matrix = [];
        var counter = 0;

        for (var row = 0; row < rows; row++) {
            matrix[row] = [];
            for (var col = 0; col < cols; col++) {
                matrix[row][col] = counter + 1;
                counter++;
            }
        }

        return matrix;
    }

    function simulateJumps(matrix, jumps, startRow, startCol) {
        var sumOfNumbers = 0;
        var numberOfJumps = 0;

        var currentRow = startRow;
        var currentCol = startCol;

        var currentJump = 0;

        while (true) {
            if (currentRow < 0 || currentCol < 0 ||
                currentRow >= matrix.length || currentCol >= matrix[0].length) {
                return 'escaped ' + sumOfNumbers;
            }

            if (matrix[currentRow][currentCol] === -1) {
                return 'caught ' + numberOfJumps;
            }

            sumOfNumbers += matrix[currentRow][currentCol];
            numberOfJumps++;
            matrix[currentRow][currentCol] = -1;

            currentRow += jumps[currentJump][0];
            currentCol += jumps[currentJump][1];

            currentJump++;

            if (currentJump === jumps.length) {
                currentJump = 0;
            }
        }
    }

    var coordsAndJumps = input[0].split(' ');
    var rows = +coordsAndJumps[0];
    var cols = +coordsAndJumps[1];
    var jumpsCount = +coordsAndJumps[2];
//    console.log('SIZE + JUMPS:', rows, cols, jumpsCount);

    var startPosition = input[1].split(' ');
    var startRow = +startPosition[0];
    var startCol = +startPosition[1];
//    console.log('START:', startRow, startCol);

    var jumps = [];
    for (var i = 2; i < jumpsCount + 2; i++) {
        var temp = input[i].split(' ');
        temp[0] = +temp[0];
        temp[1] = +temp[1];
        jumps.push(temp);
    }
//    console.log('JUMPS:', jumps);

    var matrix = (createMatrix(rows, cols));
//    console.log(matrix);

    var answer = simulateJumps(matrix, jumps, startRow, startCol);
    return answer;
}

//var input = [
//    '6 7 3',
//    '0 0',
//    '2 2',
//    '-2 2',
//    '3 -1'
//];
//console.log(solve(input));
