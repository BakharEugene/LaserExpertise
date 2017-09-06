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
var router_1 = require("@angular/router");
var SecurityService = SecurityService_1 = (function () {
    function SecurityService(router) {
        this.router = router;
        this.router = router;
    }
    SecurityService.prototype.canActivate = function (route) {
        var canActivate = false;
        var roles = route.data["roles"];
        var user = this.getCurrentUser();
        if (roles.length > 0 && user) {
            canActivate = this.checkRoles(roles, user.Role);
        }
        return canActivate;
    };
    SecurityService.prototype.getCurrentUser = function () {
        var user = JSON.parse(localStorage.getItem('currentUser'));
        return user;
    };
    SecurityService.containsRole = function (array, obj) {
        var index = array.length;
        while (index--) {
            if (array[index] === obj)
                return true;
        }
        return false;
    };
    SecurityService.prototype.checkRoles = function (availableRolesList, currentRole) {
        var flag = false;
        if (SecurityService_1.containsRole(availableRolesList, currentRole)) {
            flag = true;
        }
        return flag;
    };
    return SecurityService;
}());
SecurityService = SecurityService_1 = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [router_1.Router])
], SecurityService);
exports.SecurityService = SecurityService;
var SecurityService_1;
//# sourceMappingURL=security.service.js.map