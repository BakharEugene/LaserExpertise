import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {ProfileComponent} from './profile.component'
import {AlertService} from '../services/alert/alert.service';
import {AuthenticationService} from '../services/authentication.service';
import {UserService} from '../services/user.service';


@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule
    ],
    providers: [
        AlertService,
        AuthenticationService,
        UserService,
    ],
    declarations: [
        ProfileComponent
    ],
    bootstrap: [ProfileComponent]
})

export class ProfileModule { }