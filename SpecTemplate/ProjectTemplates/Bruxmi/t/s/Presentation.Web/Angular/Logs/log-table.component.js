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
    }
    LogTableComponent.prototype.ngOnInit = function () {
        this.getLogs();
    };
    LogTableComponent.prototype.getLogs = function () {
        var _this = this;
        this.http.getAll("api/logQuery/").subscribe(function (logs) { return _this.onSucceedLoading(logs); }, function (error) { return _this.onError(error); });
        this.infoService.showInfo("loading product...", "success");
    };
    LogTableComponent.prototype.onSucceedLoading = function (logs) {
        this.logs = logs;
        this.infoService.showInfo("Loaded logging entries", "success");
    };
    LogTableComponent.prototype.onError = function (error) {
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