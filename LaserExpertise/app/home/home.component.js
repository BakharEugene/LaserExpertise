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
const serializable_1 = require('../serialize/serializable');
const home_service_1 = require('./home.service');
const artwork_1 = require('../models/artwork');
let HomeComponent = class HomeComponent {
    constructor(httpService) {
        this.httpService = httpService;
        this.artworks = [];
        for (var i = 0; i < 3; i++) {
            this.artworks[i] = [];
        }
        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }
    ngOnInit() {
        this.getArtworks();
    }
    getArtworks() {
        this.httpService.Artworks()
            .subscribe((data) => {
            let artworksList = data.json();
            let i = 0;
            let j = 0;
            let tempArtworkList = [];
            for (let index in artworksList) {
                let artwork;
                if (parseInt(index) < 12) {
                    tempArtworkList.push(artwork = serializable_1.SerializationHelper.toInstance(new artwork_1.Artwork, (JSON.stringify(artworksList[index]))));
                    i++;
                    if (i % 4 == 0) {
                        this.artworks[j] = tempArtworkList;
                        i = 0;
                        j++;
                        tempArtworkList = [];
                    }
                }
                else
                    break;
            }
        });
    }
};
HomeComponent = __decorate([
    core_1.Component({
        selector: 'home',
        templateUrl: 'app/home/home.component.html',
        providers: [home_service_1.HttpService]
    }), 
    __metadata('design:paramtypes', [home_service_1.HttpService])
], HomeComponent);
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=home.component.js.map