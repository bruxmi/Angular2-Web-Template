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
var core_1 = require("@angular/core");
var http_1 = require('@angular/http');
var Observable_1 = require('rxjs/Observable');
var HttpDataService = (function () {
    function HttpDataService(http) {
        this.http = http;
        this.headers = new http_1.Headers();
        this.headers.append('Content-Type', 'application/json');
        this.headers.append('Accept', 'application/json');
    }
    HttpDataService.prototype.handleError = function (error) {
        console.error(error);
        return Observable_1.Observable.throw(error.json().error || 'Server error');
    };
    HttpDataService.prototype.getAll = function (url) {
        return this.http.get(url)
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    HttpDataService.prototype.get = function (url, id) {
        return this.http.get(url + id)
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    HttpDataService.prototype.add = function (url, itemName) {
        var toAdd = JSON.stringify({ ItemName: itemName });
        return this.http.post(url, toAdd, { headers: this.headers })
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    HttpDataService.prototype.update = function (url, id, itemToUpdate) {
        return this.http.put(url + id, JSON.stringify(itemToUpdate), { headers: this.headers })
            .map(function (response) { return response.json(); })
            .catch(this.handleError);
    };
    HttpDataService.prototype.delete = function (url, id) {
        return this.http.delete(url + id)
            .catch(this.handleError);
    };
    HttpDataService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], HttpDataService);
    return HttpDataService;
}());
exports.HttpDataService = HttpDataService;
//# sourceMappingURL=http-data.service.js.map