import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Response} from '@angular/http';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthenticationService } from '../services/authentication.service';
import {AlertService} from '../../alert/alert.service';
import {User} from '../../models/user';
import {UserService} from '../services/user.service';

import { PasswordValidation }  from '../services/passwordvalidation.service';

@Component({
    templateUrl: 'app/authorization/profile/profile.component.html',
    selector: 'profile',

})

export class ProfileComponent implements OnInit {

    user: User;
    fb: FormBuilder;
    contactsForm: FormGroup;
    personalDataForm: FormGroup;
    changePasswordForm: FormGroup;


    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private userService: UserService,
        private alertService: AlertService) {
        this.fb = new FormBuilder();
    }


    ngOnInit() {
        this.user = JSON.parse(localStorage.getItem('currentUser'));
        this.createForms();
    }


    private createForms(): void {
        this.contactsForm = this.fb.group({
            Skype: [this.user.Skype, [Validators.required]],
            Telephone: [this.user.Telephone, [Validators.required, Validators.minLength(7), Validators.pattern("^\d+$")]]
        });
        this.personalDataForm = this.fb.group({
            FirstName: [this.user.FirstName, [Validators.required, Validators.minLength(4)]],
            LastName: [this.user.LastName, [Validators.required, Validators.minLength(2)]],
            Gender: [this.user.Gender],
            Birthday: [this.user.BirthDay]
        });
        this.changePasswordForm = this.fb.group({
            OldPassword: ['', [Validators.required, Validators.minLength(6)]],
            Passwords: this.fb.group({
                NewPassword: ['', [Validators.required, Validators.minLength(6)]],
                RepeatNewPassword: ['', [Validators.required, Validators.minLength(6)]]
            },
                {
                    validator: this.areEqual
                }
            )

        });
    }

    areEqual(group: FormGroup) {
        var valid = false;

        var val1 = group.controls["NewPassword"].value;
        var val2 = group.controls["RepeatNewPassword"].value;

        if (val1 === val2) { valid = true; }

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
            .subscribe(
            data => {
                this.alertService.success(JSON.stringify(data), true);
                this.router.navigate(['/login']);
            },
            error => {
                this.alertService.error(JSON.stringify(error));
                this.loading = false;
            });
    }


    changeContacts(skype: string, telephone: string) {
        alert(skype);
        alert(telephone)
    }
}
