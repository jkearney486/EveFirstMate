(function (EVEFIRSTMATE) {
    "use strict";

    var TypeModel,
        ItemInfoModel,
        MarketModel,
        MarketGroupModel;

    function transformTypeId(newValue) {
        var cachedItems = this.cachedItems(),
            itemType, typeId = newValue;

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
            if (newValue) {
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
        }

        return typeId;
    }

    TypeModel = function (data) {
        ko.mapping.fromJS(data, {}, this);
    };

    ItemInfoModel = function () {
        this.selectedItem = ko.observable();
        this.cachedItems = ko.observableArray([]);
        this.selectedTypeId = ko.observable(null).subscribeTo("selectedTypeId", false, transformTypeId.bind(this));
    };

    MarketModel = function (data) {
        this.marketGroups = ko.observableArray(ko.utils.arrayMap(data, function (group) {
            return new MarketGroupModel(group);
        }));
        this.selectedTypeId = ko.observable(null).publishOn("selectedTypeId", true);
        this.openLeafNode = ko.observable();
    };

    MarketGroupModel = function (data) {
        ko.mapping.fromJS(data, {}, this);

        this.childMarketGroups = ko.observableArray([]);
        this.invTypes = ko.observableArray([]);
        this.isOpen = ko.observable(false);
    };

    ko.utils.extend(MarketModel.prototype, {
        toggleGroup: function (marketGroup) {
            if (marketGroup.isOpen()) {
                // if it's open, close it
                marketGroup.isOpen(false);
            } else {
                if (marketGroup.hasTypes()) {
                    // show invTypes
                    if (marketGroup.invTypes() && marketGroup.invTypes().length > 0) {
                        // already has the items, so just show the list
                        marketGroup.isOpen(true);
                    } else {
                        // first time this group is being opened
                        // retrieve the invTypes,
                        // then display the list
                        $.ajax({
                            type: "GET",
                            url: "MarketGroup/GetTypes/",
                            data: { marketGroupID: marketGroup.marketGroupID() },
                            context: this,
                            contentType: "application/json; charset=utf-8",
                            dataType: "json",
                            success: function (data) {
                                var invTypes = [];
                                if (data && data.length > 0) {
                                    ko.utils.arrayForEach(data, function (type) {
                                        invTypes.push(new TypeModel(type));
                                    });
                                }
                                marketGroup.invTypes(invTypes);
                                marketGroup.isOpen(true);
                                // TODO: mark this group as open in $root to keep 
                                // track of which leaf is open, so that if another
                                // leaf is opened, it can be closed.
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
                            url: "MarketGroup/GetChildGroups/",
                            data: { marketGroupID: marketGroup.marketGroupID() },
                            context: marketGroup,
                            contentType: "application/json; charset=utf-8",
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
                url: "MarketGroup/GetTopGroups/",
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
}(window.EVEFIRSTMATE));
