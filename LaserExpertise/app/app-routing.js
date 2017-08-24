"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
const core_1 = require('@angular/core');
const router_1 = require('@angular/router');
const artwork_component_1 = require('./artwork/artwork.component');
const artwork_content_component_1 = require('./artwork/content/artwork-content.component');
const home_component_1 = require('./home/home.component');
const login_component_1 = require('./authorization/login/login.component');
const register_component_1 = require('./authorization/register/register.component');
const profile_component_1 = require('./authorization/profile/profile.component');
const routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'artworks', component: artwork_component_1.ArtworkComponent },
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'artworks/detail/:id', component: artwork_content_component_1.ArtworkContentComponent },
    { path: 'login', component: login_component_1.LoginComponent },
    { path: 'register', component: register_component_1.RegisterComponent },
    { path: 'logout', component: login_component_1.LoginComponent },
    { path: 'profile', component: profile_component_1.ProfileComponent }
];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = __decorate([
    core_1.NgModule({
        imports: [router_1.RouterModule.forRoot(routes)],
        exports: [router_1.RouterModule]
    }), 
    __metadata('design:paramtypes', [])
], AppRoutingModule);
exports.AppRoutingModule = AppRoutingModule;
//# sourceMappingURL=app-routing.js.map