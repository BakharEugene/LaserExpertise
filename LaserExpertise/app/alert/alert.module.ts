import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';
import {AlertComponent} from './alert.component';
import {AlertService} from './alert.service';
@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule,
        FormsModule
    ],
    declarations: [
        AlertComponent
    ],

    providers: [AlertService],
    bootstrap: [AlertComponent]
})

export class AlertModule { }