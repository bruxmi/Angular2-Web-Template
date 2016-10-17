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
var info_bar_color_1 = require("./info-bar-color");
var info_bar_event_service_1 = require("./info-bar-event.service");
var infoMessage_1 = require("./infoMessage");
var InfoBarComponent = (function () {
    function InfoBarComponent(infoService) {
        this.infoService = infoService;
        this.showAlways = false;
        this.isVisible = false;
        this.infoMessage = new infoMessage_1.InfoMessage();
    }
    InfoBarComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.setStatus("default");
        this.infoService.infoMessageChanged.asObservable().subscribe(function (a) { return _this.setMessage(a); });
    };
    InfoBarComponent.prototype.setMessage = function (message) {
        this.infoMessage = message;
        this.setStatus(message.status);
        this.showInfoBar();
    };
    InfoBarComponent.prototype.setStatus = function (status) {
        this.status = status;
        switch (this.status) {
            case "success":
                this.curBgColor = new info_bar_color_1.InfoBarColor("success", "rgba(122, 184, 0, 0.7)");
                this.icon = 'glyphicon glyphicon-ok';
                break;
            case "danger":
                this.curBgColor = new info_bar_color_1.InfoBarColor("default", "rgba(211, 211, 211, 0.7)");
                this.icon = 'glyphicon glyphicon-remove';
                break;
            default:
                this.curBgColor = new info_bar_color_1.InfoBarColor("default", "rgba(211, 211, 211, 0.7)");
                this.icon = 'glyphicon glyphicon-info-sign';
        }
    };
    InfoBarComponent.prototype.getInfoBarColor = function () {
        return this.curBgColor.rgbaCode;
    };
    InfoBarComponent.prototype.showInfoBar = function () {
        var _this = this;
        this.isVisible = true;
        setTimeout(function () {
            if (!_this.showAlways) {
                _this.isVisible = false;
            }
            _this.setStatus("default");
            _this.infoMessage.message = "";
        }, 3000);
    };
    InfoBarComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: "info-bar",
            templateUrl: "info-bar.component.html",
            styleUrls: ["info-bar.component.css"],
            animations: [
                core_1.trigger('flyInOut', [
                    core_1.state('in', core_1.style({ transform: 'translateY(0)' })),
                    core_1.transition('void => *', [
                        core_1.style({ transform: 'translateY(-100%)' }),
                        core_1.animate(100)
                    ]),
                    core_1.transition('* => void', [
                        core_1.animate(100, core_1.style({ transform: 'translateY(100%)' }))
                    ])
                ])
            ]
        }), 
        __metadata('design:paramtypes', [info_bar_event_service_1.InfoBarEventService])
    ], InfoBarComponent);
    return InfoBarComponent;
}());
exports.InfoBarComponent = InfoBarComponent;
;
//# sourceMappingURL=info-bar.component.js.map