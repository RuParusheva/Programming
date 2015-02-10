/*Task 04. Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects */

function sortPropertiesOfObject(obj) {
    var propertyNames = [];

    for (var propertyName in obj) {
        propertyNames.push(propertyName);
    }

    propertyNames.sort();

    var smallestProperty = propertyNames[0];
    var biggestProperty = propertyNames[propertyName.length - 1];

    console.log('Smallest property for ' + obj + ': ' + smallestProperty);
    console.log('Biggest property for ' + obj + ': ' + biggestProperty);
}

sortPropertiesOfObject(document);
sortPropertiesOfObject(window);
sortPropertiesOfObject(navigator);
