import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import {LoginComponent} from './login.component'
import {AlertService} from '../services/alert/alert.service';
import {AuthenticationService} from '../services/authentication.service';
import {UserService} from '../services/user.service';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule,
        FormsModule
    ],
    providers: [
        AlertService,
        AuthenticationService,
        UserService,
    ],
    declarations: [
        LoginComponent
    ],
    bootstrap: [LoginComponent]
})

export class LoginModule { }