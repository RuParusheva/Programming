/* Task 01. Write an expression that checks if given integer is odd or even. */

var number = 0;
var i;

for(i = 0; i < 20; i++){
    number = Math.floor(i + (Math.random())* 100);
    if(number % 2 === 0){
        document.write('<p class="even">' + 'Number is even:' + ' ' + number + '</p>');
    } else {
        document.write('<p class="odd">' + 'Number is odd:' + ' ' + number + '</p>');
    }
}
