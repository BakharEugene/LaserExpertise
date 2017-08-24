import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Response} from '@angular/http';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import { AuthenticationService } from '../services/authentication.service';
import {AlertService} from '../services/alert/alert.service';
import {User} from '../../models/user';


@Component({
    templateUrl: 'app/authorization/profile/profile.component.html',
    selector: 'profile',

})

export class ProfileComponent implements OnInit {

    user: User;
    contactsForm: FormGroup;
    personalDataForm: FormGroup;
    changePasswordForm: FormGroup;


    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private authenticationService: AuthenticationService,
        private alertService: AlertService) { }


    ngOnInit() {
        this.user = JSON.parse(localStorage.getItem('currentUser'));
        this.creatyEmptyForms();
        this.FillEmptyForms();
    }

    
    private creatyEmptyForms(): void {
        this.contactsForm = new FormGroup({
            Skype: new FormControl('', Validators.required),
            Telephone: new FormControl('', [Validators.required, Validators.minLength(7), Validators.pattern("^\d+$")])
        });
        this.personalDataForm = new FormGroup({
            FirstName: new FormControl('', [Validators.required, Validators.minLength(4)]),
            FamilyName: new FormControl('', [Validators.required, Validators.minLength(2)])
        });
        this.changePasswordForm = new FormGroup({
            OldPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
            NewPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
            RepeatNewPassword: new FormControl('', [Validators.required, Validators.minLength(6)]),
        });

    }
    private FillEmptyForms(): void {
        this.contactsForm.setValue({
            Skype: this.user.Skype,
            Telephone: this.user.Telephone
        });
    }
    profile() {
        alert("mem");
    }
    changePassword() {
        alert("kek");
    }
    changeContacts(skype: string, telephone: string) {
        alert(skype);
        alert(telephone)
    }
}
