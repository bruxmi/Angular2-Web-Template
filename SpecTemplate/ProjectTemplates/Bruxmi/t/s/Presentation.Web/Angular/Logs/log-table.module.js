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
var common_1 = require('@angular/common');
var forms_1 = require('@angular/forms');
var app_routing_module_1 = require("../app-routing.module");
var shared_module_1 = require('../Shared/shared.module');
var log_table_component_1 = require('./log-table.component');
var LogModule = (function () {
    function LogModule() {
    }
    LogModule = __decorate([
        core_1.NgModule({
            imports: [
                forms_1.FormsModule, common_1.CommonModule, shared_module_1.SharedModule, app_routing_module_1.AppRoutingModule
            ],
            exports: [
                log_table_component_1.LogTableComponent
            ],
            declarations: [log_table_component_1.LogTableComponent],
        }), 
        __metadata('design:paramtypes', [])
    ], LogModule);
    return LogModule;
}());
exports.LogModule = LogModule;
exports.logQueryUrl = "api/logQuery/";
//# sourceMappingURL=log-table.module.js.map