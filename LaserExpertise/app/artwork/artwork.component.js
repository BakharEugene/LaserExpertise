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
const artwork_service_1 = require('./artwork.service');
const artwork_1 = require('../models/artwork');
const serializable_1 = require('../serialize/serializable');
let ArtworkComponent = class ArtworkComponent {
    constructor(httpService) {
        this.httpService = httpService;
        this.pageSize = 6;
        this.artworks = [];
        this.pagesIndex = [];
        this.filteredItems = [];
    }
    ngOnInit() {
        this.load();
    }
    load() {
        this.httpService.Artworks()
            .subscribe((data) => {
            let artworksList = data.json();
            for (let index in artworksList) {
                let artwork;
                this.artworks.push(artwork = serializable_1.SerializationHelper.toInstance(new artwork_1.Artwork, (JSON.stringify(artworksList[index]))));
            }
            this.filteredItems = this.artworks;
            this.createPagination();
        });
    }
    createPagination() {
        alert(this.pageSize);
        this.currentIndex = 1;
        this.pageStart = 1;
        this.pages = parseInt("" + this.filteredItems.length / this.pageSize);
        if (this.filteredItems.length % this.pageSize != 0) {
            this.pages++;
        }
        this.refreshItems();
    }
    onChangePageSize() {
        this.createPagination();
    }
    refreshItems() {
        this.artworks = this.filteredItems.slice((this.currentIndex - 1) * this.pageSize, (this.currentIndex) * this.pageSize);
        this.pagesIndex = this.fillArray();
    }
    fillArray() {
        let obj = [];
        for (let index = this.pageStart; index < this.pageStart + this.pages; index++) {
            obj.push(index);
        }
        return obj;
    }
    prevPage() {
        if (this.currentIndex > 1) {
            this.currentIndex--;
        }
        if (this.currentIndex < this.pageStart) {
            this.pageStart = this.currentIndex;
        }
        this.refreshItems();
    }
    nextPage() {
        if (this.currentIndex < this.pages) {
            this.currentIndex++;
        }
        if (this.currentIndex >= (this.pageStart + this.pages)) {
            this.pageStart = this.currentIndex - this.pages + 1;
        }
        this.refreshItems();
    }
    setPage(index) {
        this.currentIndex = index;
        this.refreshItems();
    }
};
ArtworkComponent = __decorate([
    core_1.Component({
        selector: 'artwork',
        templateUrl: 'app/artwork/artwork.component.html',
        providers: [artwork_service_1.HttpService]
    }), 
    __metadata('design:paramtypes', [artwork_service_1.HttpService])
], ArtworkComponent);
exports.ArtworkComponent = ArtworkComponent;
//# sourceMappingURL=artwork.component.js.map