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
const Subject_1 = require('rxjs/Subject');
let AlertService = class AlertService {
    constructor(router) {
        this.router = router;
        this.subject = new Subject_1.Subject();
        this.keepAfterNavigationChange = false;
        alert("4");
        // clear alert message on route change
        router.events.subscribe(event => {
            alert("4");
            if (event instanceof router_1.NavigationStart) {
                alert("5");
                if (this.keepAfterNavigationChange) {
                    alert("6");
                    // only keep for a single location change
                    this.keepAfterNavigationChange = false;
                    alert("7");
                }
                else {
                    alert("8");
                    // clear alert
                    this.subject.next();
                }
            }
        });
    }
    success(message, keepAfterNavigationChange = false) {
        alert("1");
        this.keepAfterNavigationChange = keepAfterNavigationChange;
        alert("2");
        this.subject.next({ type: 'success', text: message });
        alert("3");
    }
    error(message, keepAfterNavigationChange = false) {
        this.keepAfterNavigationChange = keepAfterNavigationChange;
        this.subject.next({ type: 'error', text: message });
    }
};
AlertService = __decorate([
    core_1.Injectable(), 
    __metadata('design:paramtypes', [router_1.Router])
], AlertService);
exports.AlertService = AlertService;
//# sourceMappingURL=alert.service.js.map