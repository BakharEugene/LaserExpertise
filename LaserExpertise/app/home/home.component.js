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
var core_1 = require("@angular/core");
var serializable_1 = require("../serialize/serializable");
var home_service_1 = require("./home.service");
var artwork_1 = require("../models/artwork");
var HomeComponent = (function () {
    function HomeComponent(httpService) {
        this.httpService = httpService;
        this.artworks = [];
        for (var i = 0; i < 3; i++) {
            this.artworks[i] = [];
        }
        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }
    HomeComponent.prototype.ngOnInit = function () {
        this.getArtworks();
    };
    HomeComponent.prototype.getArtworks = function () {
        var _this = this;
        this.httpService.Artworks()
            .subscribe(function (data) {
            var artworksList = data.json();
            var i = 0;
            var j = 0;
            var tempArtworkList = [];
            for (var index in artworksList) {
                var artwork = void 0;
                if (parseInt(index) < 12) {
                    tempArtworkList.push(artwork = serializable_1.SerializationHelper.toInstance(new artwork_1.Artwork, (JSON.stringify(artworksList[index]))));
                    i++;
                    if (i % 4 == 0) {
                        _this.artworks[j] = tempArtworkList;
                        i = 0;
                        j++;
                        tempArtworkList = [];
                    }
                }
                else
                    break;
            }
        });
    };
    return HomeComponent;
}());
HomeComponent = __decorate([
    core_1.Component({
        selector: 'home',
        templateUrl: 'app/home/home.component.html',
        providers: [home_service_1.HttpService]
    }),
    __metadata("design:paramtypes", [home_service_1.HttpService])
], HomeComponent);
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=home.component.js.map