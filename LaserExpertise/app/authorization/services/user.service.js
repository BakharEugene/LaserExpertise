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
const http_1 = require('@angular/http');
require('rxjs/Rx');
require('rxjs/add/operator/map');
let UserService = class UserService {
    constructor(http) {
        this.http = http;
    }
    getAll() {
        return this.http.get('/Users/Users', this.jwt()).map((response) => response.json());
    }
    getById(id) {
        return this.http.get('/Users/Users/' + id, this.jwt()).map((response) => response.json());
    }
    create(user) {
        return this.http.post('/Users/Create', user, this.jwt()).map((response) => response.json());
    }
    changePassword(oldPassword, newPassword) {
        return this.http.put('/Users/UpdatePassword', [oldPassword, newPassword], this.jwt()).map((response) => response.json());
    }
    update(user) {
        return this.http.put('/Users/Users/' + user.Id, user, this.jwt()).map((response) => response.json());
    }
    delete(id) {
        return this.http.delete('/Users/UsersRemove/' + id, this.jwt()).map((response) => response.json());
    }
    // private helper methods
    jwt() {
        // create authorization header with jwt token
        let currentUser = JSON.parse(localStorage.getItem('currentUser'));
        if (currentUser && currentUser.token) {
            let headers = new http_1.Headers({ 'Authorization': 'Bearer ' + currentUser.token });
            return new http_1.RequestOptions({ headers: headers });
        }
    }
};
UserService = __decorate([
    core_1.Injectable(), 
    __metadata('design:paramtypes', [http_1.Http])
], UserService);
exports.UserService = UserService;
//# sourceMappingURL=user.service.js.map