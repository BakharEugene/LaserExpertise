import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { AppComponent }   from './app.component';
import { HttpModule } from '@angular/http';
import {AppRoutingModule} from './app-routing';
import {ArtworkModule} from './artwork/artwork.module';
import {HomeModule} from './home/home.module'
import {RegisterModule} from './authorization/register/register.module'
import {LoginModule} from './authorization/login/login.module'
import {AlertModule} from './authorization/services/alert/alert.module';

import { AlertComponent } from './authorization/services/alert/alert.component';
import { AlertService} from './authorization/services/alert/alert.service';



@NgModule({
    imports: [BrowserModule,
        FormsModule,
        HttpModule,
        AppRoutingModule,
        ArtworkModule,
        HomeModule,
        RegisterModule,
        LoginModule,

    ],
    providers: [
        AlertService
    ],
    declarations: [AppComponent,
        AlertComponent
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }