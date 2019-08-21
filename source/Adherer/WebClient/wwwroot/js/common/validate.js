function checkRequire(txt) {
    var flagValid = false;
    if (txt != null && typeof txt != 'undefined') {
        txt = txt.trim();
        if (txt.length >= 1) {
            flagValid = true; 
        }
    }

    return flagValid;
}