/*Task 08. Write a JavaScript function that replaces in a HTML document given as string all the tags
 <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
 <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

function replaceLinkTags(text) {
    var result = text;
    result = result.replace(/<\/a>/g, '[/URL]');

    var tagStartIndex = result.indexOf('<a href="');
    var linkStartIndex;
    var closure;

    while (tagStartIndex != -1) {
        linkStartIndex = tagStartIndex + '<a href="'.length;
        closure = result.indexOf('>', linkStartIndex) + 1;
        var startTagToReplace = result.substring(tagStartIndex, linkStartIndex);
        var closingTagString = result.substring(linkStartIndex, closure);
        var modifiedClosingTagString = closingTagString.replace('">', ']');
        result = result.replace(closingTagString, modifiedClosingTagString);
        result = result.replace(startTagToReplace, '[URL=');
        tagStartIndex = result.indexOf('<a href="', linkStartIndex);
    }

    return result;
}


var siteText = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.' +
    'Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceLinkTags(siteText));