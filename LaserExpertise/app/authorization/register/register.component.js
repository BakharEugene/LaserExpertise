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
const router_1 = require('@angular/router');
const alert_service_1 = require('../services/alert/alert.service');
const user_service_1 = require('../services/user.service');
let RegisterComponent = class RegisterComponent {
    constructor(router, userService, alertService) {
        this.router = router;
        this.userService = userService;
        this.alertService = alertService;
        this.model = {};
        this.loading = false;
    }
    register() {
        this.loading = true;
        this.userService.create(this.model)
            .subscribe(data => {
            this.alertService.success(JSON.stringify(data), true);
            this.router.navigate(['/login']);
        }, error => {
            alert(error);
            this.alertService.error(JSON.stringify(error));
            this.loading = false;
        });
    }
};
RegisterComponent = __decorate([
    core_1.Component({
        templateUrl: 'app/authorization/register/register.component.html',
        selector: 'register'
    }), 
    __metadata('design:paramtypes', [router_1.Router, user_service_1.UserService, alert_service_1.AlertService])
], RegisterComponent);
exports.RegisterComponent = RegisterComponent;
//# sourceMappingURL=register.component.js.map