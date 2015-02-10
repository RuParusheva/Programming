/*Task 04. Write a function that checks if a given object contains a given property*/

function hasPropertyName(object, propertyName) {
    return object.hasOwnProperty(propertyName);
}

var array = [5, 6, 9, 11, 4];
console.log(hasPropertyName(array, 'length'));