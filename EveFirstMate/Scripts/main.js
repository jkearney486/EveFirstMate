(function (EVEFIRSTMATE, ko, $) {
    "use strict";

    if (!EVEFIRSTMATE || !ko || !$) {
        return;
    }

    var TypeMenuModel,
        ItemInfoModel,
        MarketModel,
        MarketGroupModel;

    TypeMenuModel = function (data) {
        this.typeID        = ko.observable();
        this.typeName      = ko.observable();
        this.description   = ko.observable();
        this.marketGroupID = ko.observable();

        this.update(data);
    };

    ko.utils.extend(TypeMenuModel.prototype, {
        update: function (data) {
            this.typeID((data && data.typeID) || null);
            this.typeName((data && data.typeName) || null);
            this.description((data && data.description) || null);
            this.marketGroupID((data && data.marketGroupID) || null);
        }
    });

    ItemInfoModel = function () {
        this.selectedItem = ko.observable().subscribeTo("selectedItem", false);
    };

    MarketModel = function (data) {
        this.marketGroups = ko.observableArray(ko.utils.arrayMap(data, function (group) {
            return new MarketGroupModel(group);
        }));
        this.selectedItem = ko.observable(null).publishOn("selectedItem", true);
        this.openLeafNode = ko.observable(null);
    };

    MarketGroupModel = function (data) {
        this.marketGroupID      = ko.observable();
        this.marketGroupName    = ko.observable();
        this.description        = ko.observable();
        this.hasTypes           = ko.observable();
        this.childMarketGroups  = ko.observableArray([]);
        this.invTypes           = ko.observableArray([]);
        this.isOpen             = ko.observable();

        this.update(data);
    };

    ko.utils.extend(MarketGroupModel.prototype, {
        update: function (data) {
            this.marketGroupID((data && data.marketGroupID) || null);
            this.marketGroupName((data && data.marketGroupName) || null);
            this.description((data && data.description) || null);
            this.hasTypes((data && data.hasTypes) || null);
        }
    });

    ko.utils.extend(MarketModel.prototype, {
        toggleGroup: function (marketGroup) {
            if (marketGroup.isOpen()) {
                // if it's open, close it
                marketGroup.isOpen(false);

                // if this was a leaf node, remove it from $root.openLeafNode
                if (marketGroup === this.openLeafNode()) {
                    this.openLeafNode(null);
                }
            } else {
                if (marketGroup.hasTypes()) {
                    // show invTypes
                    if (marketGroup.invTypes() && marketGroup.invTypes().length > 0) {
                        // already has the items, so just show the list

                        // if there's a leaf node that is currently open, close it
                        if (this.openLeafNode()) {
                            this.openLeafNode().isOpen(false);
                        }

                        // save this group in $root, so that it can be closed
                        this.openLeafNode(marketGroup);
                        marketGroup.isOpen(true);
                    } else {
                        // first time this group is being opened
                        // retrieve the invTypes,
                        // then display the list
                        $.ajax({
                            type: "GET",
                            url: EVEFIRSTMATE.BASEURL + "MarketGroup/GetTypes/" + ko.unwrap(marketGroup.marketGroupID),
                            data: "",
                            context: this,
                            dataType: "json",
                            success: function (data) {
                                var invTypes = [],
                                    openLeafNode = this.openLeafNode();
                                if (data && data.length > 0) {
                                    ko.utils.arrayForEach(data, function (type) {
                                        invTypes.push(new TypeMenuModel(type));
                                    });
                                }
                                marketGroup.invTypes(invTypes);

                                // if there's a leaf node that is currently open, close it
                                if (openLeafNode) {
                                    openLeafNode.isOpen(false);
                                }

                                // save this group in $root, so that it can be closed
                                this.openLeafNode(marketGroup);
                                marketGroup.isOpen(true);
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                console.log(jqXHR);
                                console.log(textStatus);
                                console.log(errorThrown);
                            }
                        });
                    }
                } else {
                    // show childMarketGroups
                    if (marketGroup.childMarketGroups() && marketGroup.childMarketGroups().length > 0) {
                        // children already in the array, so just show the list
                        marketGroup.isOpen(true);
                    } else {
                        // first time this group is being opened
                        // retrieve the childMarketGroups,
                        // then display the list
                        $.ajax({
                            type: "GET",
                            url: EVEFIRSTMATE.BASEURL + "MarketGroup/GetChildGroups/" + ko.unwrap(marketGroup.marketGroupID),
                            data: "",
                            context: marketGroup,
                            dataType: "json",
                            success: function (data) {
                                var childMarketGroups = [];
                                if (data && data.length > 0) {
                                    ko.utils.arrayForEach(data, function (group) {
                                        childMarketGroups.push(new MarketGroupModel(group));
                                    });
                                }
                                this.childMarketGroups(childMarketGroups);
                                this.isOpen(true);
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                console.log(jqXHR);
                                console.log(textStatus);
                                console.log(errorThrown);
                            }
                        });
                    }
                }
            }
        },
        selectItem: function (item) {
            this.selectedItem(item);
        }
    });

    $(function () {
        var itemsViewModel,
            itemInfoNode = document.getElementById("itemInfo"),
            marketGroupsViewModel,
            marketGroupsNode = document.getElementById("marketGroups");

        if (marketGroupsNode) {
            $.ajax({
                type: "GET",
                url: EVEFIRSTMATE.BASEURL + "MarketGroup/GetTopGroups/",
                data: "",
                context: this,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    marketGroupsViewModel = new MarketModel(data);
                    ko.applyBindings(marketGroupsViewModel, marketGroupsNode);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    console.log(jqXHR);
                    console.log(textStatus);
                    console.log(errorThrown);
                }
            });
        }
        if (itemInfoNode) {
            itemsViewModel = new ItemInfoModel();
            ko.applyBindings(itemsViewModel, itemInfoNode);
        }
    });

}(window.EVEFIRSTMATE, window.ko, window.jQuery));
