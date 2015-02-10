function checkBrowser() {
    var myWindow = window;
    var browserType = myWindow.navigator.appCodeName;

    var statement = browserType === 'Mozilla';
    if (statement) {
        alert('Yes');
    } else {
        alert('No');
    }
}