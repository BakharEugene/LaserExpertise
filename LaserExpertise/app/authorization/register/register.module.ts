import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import {RegisterComponent} from './register.component'
import {AlertService} from '../../alert/alert.service';
import {AuthenticationService} from '../services/authentication.service';
import {UserService} from '../services/user.service';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule,
        FormsModule
    ],
    declarations: [
        RegisterComponent
    ],
    providers: [
        AlertService,
        AuthenticationService,
        UserService,
    ],
    bootstrap: [RegisterComponent]
})

export class RegisterModule { }