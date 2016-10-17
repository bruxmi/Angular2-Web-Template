"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var http_data_service_1 = require("../Shared/Http/http-data.service");
var product_module_1 = require("./product.module");
var ProductListComponent = (function () {
    function ProductListComponent(http) {
        this.http = http;
        this.pageTitle = "Product List";
        this.imageWidth = 50;
        this.imageMargin = 2;
        this.showImage = false;
        this.listFilter = "";
    }
    ProductListComponent.prototype.toggleImage = function () {
        this.showImage = !this.showImage;
    };
    ProductListComponent.prototype.ngOnInit = function () {
        var _this = this;
        console.log("In OnInit");
        this.http.getAll(product_module_1.productQueryUrl).subscribe(function (product) {
            _this.products = product;
        });
    };
    ProductListComponent.prototype.onRatingClicked = function (message) {
        this.pageTitle = "Product List: " + message;
    };
    ProductListComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'pm-products',
            templateUrl: 'product-list.component.html',
            styleUrls: ["product-list.component.css"]
        }), 
        __metadata('design:paramtypes', [http_data_service_1.HttpDataService])
    ], ProductListComponent);
    return ProductListComponent;
}());
exports.ProductListComponent = ProductListComponent;
//# sourceMappingURL=product-list.component.js.map