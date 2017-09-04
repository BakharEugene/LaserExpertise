import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { ArtworkComponent }  from './artwork.component';
import {ArtworkContentComponent} from './content/artwork-content.component';
import { ArtworCreateComponent } from './create/artwork-create.component';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        RouterModule,
        FormsModule
    ],

    declarations: [
        ArtworkComponent, ArtworkContentComponent, ArtworCreateComponent
    ],
    bootstrap: [ArtworkComponent]
})

export class ArtworkModule { }