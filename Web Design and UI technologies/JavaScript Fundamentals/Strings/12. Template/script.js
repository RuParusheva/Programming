/*Task 12. Write a function that creates a HTML UL using a template for every HTML LI. The source of the list should be
 an array of elements. Replace all placeholders marked with –{…}–
 with the value of the corresponding property of the object. */

function generateList(people, template) {
    var result = '';

    for (var i = 0; i < people.length; i++) {
        var person = people[i];
        var currentItem = template;

        for (var prop in person) {
            currentItem = currentItem.replace(new RegExp('-\\{' + prop + '\\}-', 'g'), person[prop]);
        }

        result += '<li>' + currentItem + '</li>';
    }

    document.write('<ul>' + result + '</ul>');
}

var people = [
    {name: 'Peter', age: 14},
    {name: 'Emo', age: 24},
    {name: 'Nikifor', age: 34},
    {name: 'Gosho', age: 44}
];
var template = document.getElementById('list-item').innerHTML.trim();
console.log(template);
var peopleList = generateList(people, template);
