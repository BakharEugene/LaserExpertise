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
const forms_1 = require('@angular/forms');
const alert_service_1 = require('../../alert/alert.service');
const user_service_1 = require('../services/user.service');
let ProfileComponent = class ProfileComponent {
    constructor(route, router, userService, alertService) {
        this.route = route;
        this.router = router;
        this.userService = userService;
        this.alertService = alertService;
        this.fb = new forms_1.FormBuilder();
    }
    ngOnInit() {
        this.user = JSON.parse(localStorage.getItem('currentUser'));
        this.createForms();
    }
    createForms() {
        this.contactsForm = this.fb.group({
            Skype: [this.user.Skype, [forms_1.Validators.required]],
            Telephone: [this.user.Telephone, [forms_1.Validators.required, forms_1.Validators.minLength(7), forms_1.Validators.pattern("^\d+$")]]
        });
        this.personalDataForm = this.fb.group({
            FirstName: [this.user.FirstName, [forms_1.Validators.required, forms_1.Validators.minLength(4)]],
            LastName: [this.user.LastName, [forms_1.Validators.required, forms_1.Validators.minLength(2)]],
            Gender: [this.user.Gender],
            Birthday: [this.user.BirthDay]
        });
        this.changePasswordForm = this.fb.group({
            OldPassword: ['', [forms_1.Validators.required, forms_1.Validators.minLength(6)]],
            Passwords: this.fb.group({
                NewPassword: ['', [forms_1.Validators.required, forms_1.Validators.minLength(6)]],
                RepeatNewPassword: ['', [forms_1.Validators.required, forms_1.Validators.minLength(6)]]
            }, {
                validator: this.areEqual
            })
        });
    }
    areEqual(group) {
        var valid = false;
        var val1 = group.controls["NewPassword"].value;
        var val2 = group.controls["RepeatNewPassword"].value;
        if (val1 === val2) {
            valid = true;
        }
        if (valid) {
            return null;
        }
        return {
            areEqual: true
        };
    }
    profile() {
    }
    changePassword() {
        this.userService.changePassword(this.changePasswordForm.controls["OldPassword"].value, this.changePasswordForm.controls["NewPassword"].value)
            .subscribe(data => {
            this.alertService.success(JSON.stringify(data), true);
            this.router.navigate(['/login']);
        }, error => {
            this.alertService.error(JSON.stringify(error));
        });
    }
    changeContacts(skype, telephone) {
        alert(skype);
        alert(telephone);
    }
};
ProfileComponent = __decorate([
    core_1.Component({
        templateUrl: 'app/authorization/profile/profile.component.html',
        selector: 'profile',
    }), 
    __metadata('design:paramtypes', [router_1.ActivatedRoute, router_1.Router, user_service_1.UserService, alert_service_1.AlertService])
], ProfileComponent);
exports.ProfileComponent = ProfileComponent;
//# sourceMappingURL=profile.component.js.map