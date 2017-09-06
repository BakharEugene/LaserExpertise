import { Component, OnInit} from '@angular/core';
import { Response } from '@angular/http';
import { User } from './models/user';
import {SerializationHelper} from './serialize/serializable'

@Component({
    selector: 'my-app',
    templateUrl: 'app/app.component.html'
})
export class AppComponent{

    currentUser: User 

    public isLoggedIn(): boolean {

        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
        if (this.currentUser) {

            return true;
        }

        return false;
    }
}