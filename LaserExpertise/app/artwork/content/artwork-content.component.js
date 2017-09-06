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
var artwork_service_1 = require("../artwork.service");
var artwork_1 = require("../../models/artwork");
var router_1 = require("@angular/router");
var serializable_1 = require("../../serialize/serializable");
var ArtworkContentComponent = (function () {
    function ArtworkContentComponent(httpService, activateRoute) {
        this.httpService = httpService;
        this.activateRoute = activateRoute;
        this.id = activateRoute.snapshot.params['id'];
    }
    ArtworkContentComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.httpService.artworksById(this.id).subscribe(function (data) {
            _this.artwork = serializable_1.SerializationHelper.toInstance(new artwork_1.Artwork, (JSON.stringify(data.json())));
        });
    };
    return ArtworkContentComponent;
}());
__decorate([
    core_1.Input(),
    __metadata("design:type", Number)
], ArtworkContentComponent.prototype, "id", void 0);
ArtworkContentComponent = __decorate([
    core_1.Component({
        selector: 'artwork-content',
        templateUrl: 'app/artwork/content/artwork-content.component.html',
        providers: [artwork_service_1.ArtworkService]
    }),
    __metadata("design:paramtypes", [artwork_service_1.ArtworkService,
        router_1.ActivatedRoute])
], ArtworkContentComponent);
exports.ArtworkContentComponent = ArtworkContentComponent;
//# sourceMappingURL=artwork-content.component.js.map