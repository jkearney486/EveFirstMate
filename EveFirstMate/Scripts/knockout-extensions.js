(function (ko) {
    // this binding is meant to handle text blocks that are formatted to allow limited styling
    // the binding expects to see [b][/b], [i][/i], and [br] tags
    // and turns these into <strong></strong>, <em></em>, and <br> respectively
    ko.bindingHandlers.textBlock = {
        update: function (element, valueAccessor) {
            var textValue = valueAccessor(),
                html = "";

            html = textValue();
            html = html.replace(/\[b\]/gi, "<strong>")
                       .replace(/\[\/b\]/gi, "</strong>")
                       .replace(/\[i\]/gi, "<em>")
                       .replace(/\[\/i\]/gi, "</em>")
                       .replace(/\[br\]/gi, "<br>");

            element.innerHTML = html;
        }
    };
})(window.ko);
