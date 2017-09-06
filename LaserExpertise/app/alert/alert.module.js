"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var alert_component_1 = require("./alert.component");
var alert_service_1 = require("./alert.service");
var AlertModule = (function () {
    function AlertModule() {
    }
    return AlertModule;
}());
AlertModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            http_1.HttpModule,
            router_1.RouterModule,
            forms_1.FormsModule
        ],
        declarations: [
            alert_component_1.AlertComponent
        ],
        providers: [alert_service_1.AlertService],
        bootstrap: [alert_component_1.AlertComponent]
    })
], AlertModule);
exports.AlertModule = AlertModule;
//# sourceMappingURL=alert.module.js.map