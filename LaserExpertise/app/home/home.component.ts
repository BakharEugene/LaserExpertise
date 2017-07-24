import { Component, OnInit} from '@angular/core';
import { Response} from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import {User} from '../models/user'

@Component({
    selector: 'home',
    templateUrl: 'app/home/home.component.html',
})
export class HomeComponent {
    currentUser: User;
    constructor() {
        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }

    ngOnInit() {

    }
}
