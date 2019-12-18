function cp() {
    var element = document.body;
    var rng = document.createRange();
    rng.selectNodeContents(element);
    window.getSelection().addRange(rng);
    document.execCommand('copy');
    element = null;
    rng = null;
    alert('Copied to the clipboard.');
}