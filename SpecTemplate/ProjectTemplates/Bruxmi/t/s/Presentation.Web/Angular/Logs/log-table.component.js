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
var log_url_service_1 = require("./log-url.service");
var http_data_service_1 = require("../Shared/Http/http-data.service");
var info_bar_event_service_1 = require("../Shared/Info/info-bar-event.service");
var LogTableComponent = (function () {
    function LogTableComponent(http, infoService, logUrlService) {
        this.http = http;
        this.infoService = infoService;
        this.logUrlService = logUrlService;
        this.pageTitle = "Logs";
        this.isLoading = false;
    }
    LogTableComponent.prototype.ngOnInit = function () {
        this.pageSizes = [{ key: "0", value: 50 },
            { key: "1", value: 100 },
            { key: "2", value: 200 }
        ];
        this.logLevelFilter = [
            { key: "0", value: "All" },
            { key: "1", value: "Debug" },
            { key: "2", value: "Information" },
            { key: "3", value: "Warning" },
            { key: "4", value: "Error" },
            { key: "5", value: "Fatal" }
        ];
        this.logPaging = {
            Count: 0,
            IsDescending: true,
            PageIndex: 0,
            PageSize: 50,
            Logs: null,
            SearchTerm: "All"
        };
        this.getLogs();
    };
    LogTableComponent.prototype.pageSizeChanged = function (pageSizeIndex) {
        var convertedPageSizeIndex = Number.parseInt(pageSizeIndex);
        this.logPaging.PageSize = this.pageSizes[convertedPageSizeIndex].value;
        this.getLogs();
    };
    LogTableComponent.prototype.logLevelFilterChanged = function (logLevelIndex) {
        var convertedLogLevelIndex = Number.parseInt(logLevelIndex);
        this.logPaging.SearchTerm = this.logLevelFilter[convertedLogLevelIndex].value;
        this.getLogs();
    };
    LogTableComponent.prototype.getPageCount = function () {
        var result = "1";
        if (this.logPaging.PageSize != 0) {
            result = (this.logPaging.Count / this.logPaging.PageSize).toString();
            result = Number.parseInt(result).toString();
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
        if (!this.isLoading && this.logPaging.PageIndex > 0) {
            return true;
        }
        return false;
    };
    LogTableComponent.prototype.canClickNextPage = function () {
        var count = 0;
        if (this.logPaging.PageSize != 0) {
            var tmp = (this.logPaging.Count / this.logPaging.PageSize).toString();
            count = Number.parseInt(tmp);
        }
        if (!this.isLoading && this.logPaging.PageIndex < count) {
            return true;
        }
        return false;
    };
    LogTableComponent.prototype.getLogs = function () {
        var _this = this;
        this.isLoading = true;
        this.http.update(this.logUrlService.getQueryUrl(), 0, this.logPaging).subscribe(function (logsPaging) { return _this.onSucceedLoading(logsPaging); }, function (error) { return _this.onError(error); });
        this.infoService.showInfo("loading product...", "success");
    };
    LogTableComponent.prototype.onSucceedLoading = function (logPaging) {
        this.logPaging = logPaging;
        this.logPaging.PageSize = Number.parseInt(this.logPaging.PageSize.toString());
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
            styleUrls: ['log-table.component.css'],
        }), 
        __metadata('design:paramtypes', [http_data_service_1.HttpDataService, info_bar_event_service_1.InfoBarEventService, log_url_service_1.LogUrlService])
    ], LogTableComponent);
    return LogTableComponent;
}());
exports.LogTableComponent = LogTableComponent;
//# sourceMappingURL=log-table.component.js.map