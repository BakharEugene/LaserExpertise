"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var app_component_1 = require("./app.component");
var http_1 = require("@angular/http");
var app_routing_1 = require("./app-routing");
var artwork_module_1 = require("./artwork/artwork.module");
var home_module_1 = require("./home/home.module");
var register_module_1 = require("./authorization/register/register.module");
var login_module_1 = require("./authorization/login/login.module");
var profile_module_1 = require("./authorization/profile/profile.module");
var alert_component_1 = require("./alert/alert.component");
var alert_service_1 = require("./alert/alert.service");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule,
            forms_1.FormsModule,
            http_1.HttpModule,
            app_routing_1.AppRoutingModule,
            artwork_module_1.ArtworkModule,
            home_module_1.HomeModule,
            register_module_1.RegisterModule,
            login_module_1.LoginModule,
            profile_module_1.ProfileModule
        ],
        providers: [
            alert_service_1.AlertService
        ],
        declarations: [
            app_component_1.AppComponent,
            alert_component_1.AlertComponent
        ],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map