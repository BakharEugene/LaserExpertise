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
var artwork_service_1 = require("./artwork.service");
var artwork_1 = require("../models/artwork");
var serializable_1 = require("../serialize/serializable");
var ArtworkComponent = (function () {
    function ArtworkComponent(httpService) {
        this.httpService = httpService;
        this.pageSize = 6;
        this.artworks = [];
        this.pagesIndex = [];
        this.filteredItems = [];
    }
    ArtworkComponent.prototype.ngOnInit = function () {
        this.load();
    };
    ArtworkComponent.prototype.load = function () {
        var _this = this;
        this.httpService.artworks()
            .subscribe(function (data) {
            var artworksList = data.json();
            for (var index in artworksList) {
                var artwork = void 0;
                _this.artworks.push(artwork = serializable_1.SerializationHelper.toInstance(new artwork_1.Artwork, (JSON.stringify(artworksList[index]))));
            }
            _this.filteredItems = _this.artworks;
            _this.createPagination();
        });
    };
    ArtworkComponent.prototype.createPagination = function () {
        this.currentIndex = 1;
        this.pageStart = 1;
        this.pages = parseInt("" + this.filteredItems.length / this.pageSize);
        if (this.filteredItems.length % this.pageSize != 0) {
            this.pages++;
        }
        this.refreshItems();
    };
    ArtworkComponent.prototype.onChangePageSize = function () {
        this.createPagination();
    };
    ArtworkComponent.prototype.refreshItems = function () {
        this.artworks = this.filteredItems.slice((this.currentIndex - 1) * this.pageSize, (this.currentIndex) * this.pageSize);
        this.pagesIndex = this.fillArray();
    };
    ArtworkComponent.prototype.fillArray = function () {
        var obj = [];
        for (var index = this.pageStart; index < this.pageStart + this.pages; index++) {
            obj.push(index);
        }
        return obj;
    };
    ArtworkComponent.prototype.prevPage = function () {
        if (this.currentIndex > 1) {
            this.currentIndex--;
        }
        if (this.currentIndex < this.pageStart) {
            this.pageStart = this.currentIndex;
        }
        this.refreshItems();
    };
    ArtworkComponent.prototype.nextPage = function () {
        if (this.currentIndex < this.pages) {
            this.currentIndex++;
        }
        if (this.currentIndex >= (this.pageStart + this.pages)) {
            this.pageStart = this.currentIndex - this.pages + 1;
        }
        this.refreshItems();
    };
    ArtworkComponent.prototype.setPage = function (index) {
        this.currentIndex = index;
        this.refreshItems();
    };
    return ArtworkComponent;
}());
ArtworkComponent = __decorate([
    core_1.Component({
        selector: 'artwork',
        templateUrl: 'app/artwork/artwork.component.html',
        providers: [artwork_service_1.ArtworkService]
    }),
    __metadata("design:paramtypes", [artwork_service_1.ArtworkService])
], ArtworkComponent);
exports.ArtworkComponent = ArtworkComponent;
//# sourceMappingURL=artwork.component.js.map