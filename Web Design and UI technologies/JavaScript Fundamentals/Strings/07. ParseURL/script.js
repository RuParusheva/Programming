/*Task 07. Write a script that parses an URL address given in the format:
 [protocol]://[server]/[resource]
 and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.
 For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
 {protocol: 'http', server: 'www.devbg.org',
 resource: '/forum/index.php'}
*/

function parseURL(url) {
    var result = {};

    result.protocol = url.substring(0, url.indexOf(':'));

    var firstSlashIndex = url.indexOf('/');
    var lastSlashIndex = url.indexOf('/', firstSlashIndex + 2);
    result.server = url.substring(firstSlashIndex + 2, lastSlashIndex);

    result.resource = url.substring(lastSlashIndex + 1);

    return result;
}

console.log(parseURL('http://www.devbg.org/forum/index.php'));