import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from '../services/authentication.service';
import {AlertService} from '../services/alert/alert.service';
import {UserService} from '../services/user.service';
@Component({
    templateUrl: 'app/authorization/register/register.component.html',
        selector: 'register'
})

export class RegisterComponent {
    model: any = {};
    loading = false;

    constructor(
        private router: Router,
        private userService: UserService,
        private alertService: AlertService) { }

    register() {
        this.loading = true;
        this.userService.create(this.model)
            .subscribe(
            data => {
                this.alertService.success(JSON.stringify(data), true);
                this.router.navigate(['/login']);
            },
            error => {
                alert(error);
                this.alertService.error(JSON.stringify(error));
                this.loading = false;
            });
    }
}