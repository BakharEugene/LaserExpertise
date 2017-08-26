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
const forms_1 = require("@angular/forms");
const authentication_service_1 = require('../services/authentication.service');
const alert_service_1 = require('../services/alert/alert.service');
let ProfileComponent = class ProfileComponent {
    constructor(route, router, authenticationService, alertService) {
        this.route = route;
        this.router = router;
        this.authenticationService = authenticationService;
        this.alertService = alertService;
    }
    ngOnInit() {
        this.user = JSON.parse(localStorage.getItem('currentUser'));
        this.creatyEmptyForms();
        this.FillEmptyForms();
    }
    creatyEmptyForms() {
        this.contactsForm = new forms_1.FormGroup({
            Skype: new forms_1.FormControl('', forms_1.Validators.required),
            Telephone: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(7), forms_1.Validators.pattern("^\d+$")])
        });
        this.personalDataForm = new forms_1.FormGroup({
            FirstName: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(4)]),
            FamilyName: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(2)]),
            Gender: new forms_1.FormControl(''),
            Birthday: new forms_1.FormControl('')
        });
        this.changePasswordForm = new forms_1.FormGroup({
            OldPassword: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(6)]),
            NewPassword: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(6)]),
            RepeatNewPassword: new forms_1.FormControl('', [forms_1.Validators.required, forms_1.Validators.minLength(6)]),
        });
    }
    FillEmptyForms() {
        this.contactsForm.setValue({
            Skype: this.user.Skype,
            Telephone: this.user.Telephone
        });
        alert(JSON.stringify(this.user.BirthDay));
        this.personalDataForm.setValue({
            FirstName: this.user.FirstName,
            FamilyName: this.user.LastName,
            Gender: this.user.Gender,
            Birthday: this.user.BirthDay
        });
    }
    profile() {
        alert("mem");
    }
    changePassword() {
        alert("kek");
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
    __metadata('design:paramtypes', [router_1.ActivatedRoute, router_1.Router, authentication_service_1.AuthenticationService, alert_service_1.AlertService])
], ProfileComponent);
exports.ProfileComponent = ProfileComponent;
//# sourceMappingURL=profile.component.js.map