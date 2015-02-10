function solve(input){

    var size = input[0].split(' ');
    var rows = +size[0];
    var cols = +size[1];

    var startRow = rows - 1;
    var startCol = cols - 1;

    function createMatrix(rows, cols) {

        var matrix = [];

        for (var row = 0; row < rows; row++) {
            matrix[row] = [];
            for (var col = 0; col < cols; col++) {
                matrix[row][col] = +input[row + 1][col] ;
            }
        }

        return matrix;
    }


    function generateSecondMatrix(rows, cols) {

        var matrix = [];

        for (var row = 0; row < rows; row++) {
            matrix[row] = [];
            var counter = Math.pow(2, row);
            for (var col = 0; col < cols; col++) {
                matrix[row][col] = counter;
                counter--;
            }
        }

        return matrix;
    }


    var firstMatrix = createMatrix(rows, cols)
    var secondMatrix = generateSecondMatrix(rows, cols);

    function simulateJumps(matrix, secondMatrix, startRow, startCol){

        var sumOfJumps = 0;
        var numberOfJumps = 0;

        var currentRow = startRow;
        var currentCol = startCol;

        var startJumpInstruction = matrix[currentRow][currentCol];
        var startingValue = secondMatrix[currentRow][currentCol];

        function getNextJumpInstruction(startJumpInstruction){

            switch(startJumpInstruction){

                case 1:
                    return matrix[currentRow - 2][currentCol + 1];
                case 2:
                    return matrix[currentRow - 1][currentCol + 2];
                case 3:
                    return matrix[currentRow + 1][currentCol + 2];
                case 4:
                    return matrix[currentRow + 2][currentCol + 1];
                case 5:
                    return matrix[currentRow + 2][currentCol - 1];
                case 6:
                    return matrix[currentRow + 1][currentCol - 2];
                case 7:
                    return matrix[currentRow - 1][currentCol - 2];
                case 8:
                    return matrix[currentRow - 2][currentCol - 1];
                default :
                    return undefined;

            }

        }

        var nextJumpInstruction = getNextJumpInstruction(startJumpInstruction);

        while(nextJumpInstruction != undefined){

            sumOfJumps += getNextJumpInstruction(startingValue);

        }


    }
    //return createMatrix(rows, cols)
   // return simulateJumps(createMatrix(rows, cols), startRow, startCol)
}

var input =[
    '3 5',
    '54561',
    '43328',
    '52188'
]
console.log(solve(input));