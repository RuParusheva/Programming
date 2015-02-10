/* Task 04. Write a function to count the number of divs on the web page */

function getDivCount(){
    var divs = document.getElementsByTagName('div');
    var divsCount = 0;

    for (var i = 0; i < divs.length; i++) {
        divsCount +=1;
    }

    return divsCount;
}

document.write('<p>' + 'Number of divs in the document is: ' + getDivCount() + '.' + '<p>');

