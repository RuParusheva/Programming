/*Task 06. Write a function that extracts the content of a html page given as text.*/

function getText(node) {
    var children = node.children;

    for (var i = 0; i < children.length; i++) {
        var tag = children[i];

        console.log(tag.innerText.trim());
    }
}

getText(document.documentElement);
