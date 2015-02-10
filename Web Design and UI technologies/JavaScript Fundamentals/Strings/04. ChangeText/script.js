/*Task 04. You are given a text. Write a function that changes the text in all regions:
 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)

 We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

 Regions can be nested
 */

function mixcase(text) {
    var result = '';

    for (var i = 0; i < text.length; i++) {
        var c = text[i];

        if (Math.random() < 0.5) {
            c = c.toUpperCase();
        } else {
            c = c.toLowerCase();
        }

        result += c;
    }

    return result;
}

function convertText(text, conversionType) {
    switch (conversionType.toLowerCase()) {
        case 'lowcase':
            var result = text.toLowerCase();
            return result;

        case 'upcase':
            var result = text.toUpperCase();
            return result;

        case 'mixcase':
            var result = mixcase(text);
            return result;

        default:
            throw new Error("Unknown conversion: " + conversionType);
    }
}

function processText(text) {
    var index = text.indexOf('<');
    var result = text;

    while (index !== -1) {
        var nextIndex = text.indexOf('</', index);
        var values = text.substring(index + 1, nextIndex);
        var modifiers = values.split('>');
        if (modifiers[0] === 'mixcase'|| modifiers[0] === "upcase" ||
            modifiers[0] === 'lowcase'){
            var modified = convertText(modifiers[1], modifiers[0]);
            result = result.replace(modifiers[1], modified);
        }
        index = text.indexOf('<', index + 2);
    }

    result = result.replace(/(<([^>]+)>)/ig, '');
    return result;
}


var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
console.log(processText(text));