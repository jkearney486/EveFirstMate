(function (ko) {
    // this binding is designed to render a text block that has embedded newline characters as a <br>
    // and inlined html tags such as <i>, <b> as <em>, <strong>
    ko.bindingHandlers.textBlock = {
        init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {

        },
        update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
            var textValue = valueAccessor();
        }
    };
})(window.ko);
