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
const core_1 = require('@angular/core');
const platform_browser_1 = require('@angular/platform-browser');
const forms_1 = require('@angular/forms');
const app_component_1 = require('./app.component');
const http_1 = require('@angular/http');
const app_routing_1 = require('./app-routing');
const artwork_module_1 = require('./artwork/artwork.module');
const home_module_1 = require('./home/home.module');
const register_module_1 = require('./authorization/register/register.module');
const login_module_1 = require('./authorization/login/login.module');
const profile_module_1 = require('./authorization/profile/profile.module');
const alert_component_1 = require('./authorization/services/alert/alert.component');
const alert_service_1 = require('./authorization/services/alert/alert.service');
let AppModule = class AppModule {
};
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
    }), 
    __metadata('design:paramtypes', [])
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map