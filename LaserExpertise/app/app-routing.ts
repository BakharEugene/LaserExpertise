import { NgModule }    from '@angular/core';
import { RouterModule, Routes, ActivatedRoute } from '@angular/router';

import { ArtworkComponent }   from './artwork/artwork.component';
import {ArtworkContentComponent} from './artwork/content/artwork-content.component';

import {LoginComponent} from './authorization/login/login.component';
import {RegisterComponent} from './authorization/register/register.component';

const routes: Routes = [
    { path: '', redirectTo: 'artworks', pathMatch: 'full' },
    { path: 'artworks', component: ArtworkComponent },
    { path: 'artworks/detail/:id', component: ArtworkContentComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: 'logout', component: LoginComponent },


];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
