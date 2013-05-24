(function () {
    "use strict";

    $(function () {
        $("#marketGroups").on("click", "li[data-node-state]", function (event) {
            var currentState = this.dataset.nodeState,
                nextState = currentState === "closed" ? "open" : "closed";

            this.dataset.nodeState = nextState;
            // don't propogate the event up previous nodes
            return false;
        });

        $("#marketGroups").on("click", "li[data-leaf-state]", function (event) {
            var currentState = this.dataset.leafState,
                nextState = currentState === "closed" ? "open" : "closed";

            // we want to limit the number of open leaf nodes to one
            if (nextState === "open") {
                // if any leaf nodes are open, close them
                $("#marketGroups li[data-leaf-state=\"open\"]").each(function (index) {
                    this.dataset.leafState = "closed";
                });
            }

            this.dataset.leafState = nextState;
            // don't propogate the event up previous nodes
            return false;
        });

        $("#marketGroups").on("click", "li[data-item-typeid]", function (event) {
            


            return false;
        });
    });
}());
