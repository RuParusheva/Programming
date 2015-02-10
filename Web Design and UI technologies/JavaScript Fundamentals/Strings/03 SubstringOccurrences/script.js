/*Task 03. Write a JavaScript function that finds how many times a substring is contained in a given text
(perform case insensitive search).
 Example: The target substring is "in". The text is as follows:
 We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight.
 So we are drinking all the day. We will move out of it in 5 days.
 The result is: 9.
 */

function numberOfOccurrences(str, keyword) {
    str = str.toLowerCase();
    keyword = keyword.toLowerCase();

    var count = 0;
    var index = str.indexOf(keyword);

    while (index !== -1) {
        count++;
        index = str.indexOf(keyword, index + keyword.length);
    }

    return count;
}

console.log(numberOfOccurrences('We are living in an yellow submarine. We don\'t have anything else. Inside the submarine is very tight. ' +
    'So we are drinking all the day. We will move out of it in 5 days.', 'in'));
