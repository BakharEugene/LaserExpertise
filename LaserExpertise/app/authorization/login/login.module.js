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
const http_1 = require('@angular/http');
const router_1 = require('@angular/router');
const forms_1 = require('@angular/forms');
const login_component_1 = require('./login.component');
const alert_service_1 = require('../services/alert/alert.service');
const authentication_service_1 = require('../services/authentication.service');
const user_service_1 = require('../services/user.service');
let LoginModule = class LoginModule {
};
LoginModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            http_1.HttpModule,
            router_1.RouterModule,
            forms_1.FormsModule
        ],
        providers: [
            alert_service_1.AlertService,
            authentication_service_1.AuthenticationService,
            user_service_1.UserService,
        ],
        declarations: [
            login_component_1.LoginComponent
        ],
        bootstrap: [login_component_1.LoginComponent]
    }), 
    __metadata('design:paramtypes', [])
], LoginModule);
exports.LoginModule = LoginModule;
//# sourceMappingURL=login.module.js.map