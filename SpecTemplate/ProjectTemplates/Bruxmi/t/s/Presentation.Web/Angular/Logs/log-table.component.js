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
var info_bar_event_service_1 = require("../Shared/Info/info-bar-event.service");
var LogTableComponent = (function () {
    function LogTableComponent(http, infoService) {
        this.http = http;
        this.infoService = infoService;
        this.pageTitle = "Logs";
        this.isLoading = false;
    }
    LogTableComponent.prototype.ngOnInit = function () {
        this.logPaging = {
            Count: 0,
            IsDescending: true,
            PageIndex: 0,
            PageSize: 5,
            Logs: null,
            SearchTerm: "All"
        };
        this.getLogs();
    };
    LogTableComponent.prototype.getLogs = function () {
        var _this = this;
        this.isLoading = true;
        this.http.update("api/logQuery/", 0, this.logPaging).subscribe(function (logs) { return _this.onSucceedLoading(logs); }, function (error) { return _this.onError(error); });
        this.infoService.showInfo("loading product...", "success");
    };
    LogTableComponent.prototype.getPageCount = function () {
        var result = "0";
        if (this.logPaging.PageSize != 0) {
            result = (this.logPaging.Count / this.logPaging.PageSize).toPrecision();
        }
        return result;
    };
    LogTableComponent.prototype.prevPage = function () {
        this.logPaging.PageIndex--;
        this.getLogs();
    };
    LogTableComponent.prototype.nextPage = function () {
        this.logPaging.PageIndex++;
        this.getLogs();
    };
    LogTableComponent.prototype.canClickPrevPage = function () {
        if (this.isLoading || this.logPaging.PageIndex == 0) {
            return false;
        }
        return true;
    };
    LogTableComponent.prototype.canClickNextPage = function () {
        if (this.isLoading || this.logPaging.PageIndex == this.logPaging.Count) {
            return false;
        }
        return true;
    };
    LogTableComponent.prototype.onSucceedLoading = function (logPaging) {
        this.logPaging = logPaging;
        this.logs = logPaging.Logs;
        this.isLoading = false;
        this.infoService.showInfo("Loaded logging entries", "success");
    };
    LogTableComponent.prototype.onError = function (error) {
        this.isLoading = false;
        this.infoService.showInfo("Loading product failed: " + error, "danger");
    };
    LogTableComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'log-table',
            templateUrl: 'log-table.component.html',
            styleUrls: ['log-table.component.css']
        }), 
        __metadata('design:paramtypes', [http_data_service_1.HttpDataService, info_bar_event_service_1.InfoBarEventService])
    ], LogTableComponent);
    return LogTableComponent;
}());
exports.LogTableComponent = LogTableComponent;
//# sourceMappingURL=log-table.component.js.map