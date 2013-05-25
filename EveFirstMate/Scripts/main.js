﻿(function () {
    "use strict";

    var TypeModel, ItemInfoModel;

    function transformTypeId(typeId) {
        var cachedItems = this.cachedItems(),
            itemType;

        // Checks the cache to see if the item has already been accessed
        if (cachedItems && cachedItems.length > 0) {
            itemType = ko.utils.arrayFirst(cachedItems, function (item) {
                return item.typeID() === typeId;
            });
        }

        // if the item was found in the cache, make it the selected item
        // otherwise, make a call to the api to find it
        if (itemType) {
            this.selectedItem(itemType);
        } else {
            $.ajax({
                type: "GET",
                url: "api/types/" + typeId,
                data: "",
                context: this,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    // if an item was returned, create a new TypeModel object of it
                    // then add it to the cache and select it
                    if (data) {
                        itemType = new TypeModel(data);
                        this.cachedItems.push(itemType);
                        this.selectedItem(itemType);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR);
                    console.log(textStatus);
                    console.log(errorThrown);
                }
            });
        }

        return typeId;
    }

    TypeModel = function (data) {
        ko.mapping.fromJS(data, {}, this);
    };

    ItemInfoModel = function () {
        this.selectedItem = ko.observable();
        this.cachedItems = ko.observableArray([]);
        this.selectedTypeId = ko.observable().subscribeTo("selectedTypeId", false, transformTypeId.bind(this));

    };

    $(function () {
        var itemsViewModel;

        // Change the state of the tree node that was clicked on
        // This changes the class of the sibling <li> tag based on the new state
        // which shows or hides the node
        $("#marketGroups").on("click", "li[data-node-state]", function (event) {
            var currentState, nextState;

            if (Modernizr.dataset) {
                currentState = this.dataset.nodeState;
                nextState = currentState === "closed" ? "open" : "closed";

                this.dataset.nodeState = nextState;
            } else {
                currentState = $(this).attr("data-node-state");
                nextState = currentState === "closed" ? "open" : "closed";

                $(this).attr("data-node-state", nextState);
            }

            $(this).next("li").removeClass(currentState).addClass(nextState);

            // don't propogate the event up to parent nodes
            return false;
        });

        // Change the state of the leaf node that was clicked on
        // This requires two extra steps
        // 1. close any other open leaf nodes
        // 2. unselect any selected item from another category
        $("#marketGroups").on("click", "li[data-leaf-state]", function (event) {
            var currentState, nextState;

            // get the current state, then swap it
            // close any currently open leaf nodes
            // set the new state on the leaf that was clicked
            if (Modernizr.dataset) {
                currentState = this.dataset.leafState;
                nextState = currentState === "closed" ? "open" : "closed";

                if (nextState === "open") {
                    $("#marketGroups li[data-leaf-state=\"open\"]").each(function (index) {
                        this.dataset.leafState = "closed";
                        $(this).next("li").removeClass("open").addClass("closed");
                    });
                }

                this.dataset.leafState = nextState;
            } else {
                currentState = $(this).attr("data-leaf-state");
                nextState = currentState === "closed" ? "open" : "closed";

                if (nextState === "open") {
                    $("#marketGroups li[data-leaf-state=\"open\"]").each(function (index) {
                        $(this).attr("data-leaf-state", "closed");
                        $(this).next("li").removeClass("open").addClass("closed");
                    });
                }

                $(this).attr("data-leaf-state", nextState);
            }

            // unselect any selected items
            $("#marketGroups li[data-item-typeid].selected").removeClass("selected");

            // remove the old state from the node and set the new state
            $(this).next("li").removeClass(currentState).addClass(nextState);

            // don't propogate the event up to parent nodes
            return false;
        });

        // When an item is selected, it's published to the knockout-postbox
        // This also unselects any other item that may have been selected
        $("#marketGroups").on("click", "li[data-item-typeid]", function (event) {
            var itemTypeId;

            // Get the item's typeID
            if (Modernizr.dataset) {
                itemTypeId = this.dataset.itemTypeid;
            } else {
                itemTypeId = $(this).attr("data-item-typeid");
            }

            // unselect any selected items
            $("#marketGroups li[data-item-typeid].selected").removeClass("selected");

            // select this item
            $(this).addClass("selected");

            // publish the typeID to the selectedTypeId topic
            if (itemTypeId) {
                ko.postbox.publish("selectedTypeId", itemTypeId);
            }

            // don't propogate the event up to parent nodes
            return false;
        });

        itemsViewModel = new ItemInfoModel();
        ko.applyBindings(itemsViewModel, document.getElementById("itemInfo"));
    });
}());
