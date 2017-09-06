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
var router_1 = require("@angular/router");
var alert_service_1 = require("../../alert/alert.service");
var artwork_service_1 = require("../artwork.service");
var ArtworCreateComponent = (function () {
    function ArtworCreateComponent(router, artworkService, alertService) {
        this.router = router;
        this.artworkService = artworkService;
        this.alertService = alertService;
        this.model = {};
        this.genres = [
            { id: 1, name: "United States" },
            { id: 2, name: "Australia" },
            { id: 3, name: "Canada" },
            { id: 4, name: "Brazil" },
            { id: 5, name: "England" }
        ];
        this.schools = [
            { id: 1, name: "kek" },
            { id: 2, name: "mem" },
            { id: 3, name: "lol" },
            { id: 4, name: "lul" },
            { id: 5, name: "lel" }
        ];
    }
    ArtworCreateComponent.prototype.ngOnInit = function () {
    };
    ArtworCreateComponent.prototype.create = function () {
        var _this = this;
        this.loading = true;
        this.artworkService.create(this.model)
            .subscribe(function (data) {
            _this.alertService.success(JSON.stringify(data), true);
            _this.router.navigate(['/artworks']);
        }, function (error) {
            alert(JSON.stringify(_this.model));
            _this.alertService.error(JSON.stringify(error));
            _this.loading = false;
        });
    };
    ArtworCreateComponent.prototype.onChange = function (event) {
    };
    return ArtworCreateComponent;
}());
ArtworCreateComponent = __decorate([
    core_1.Component({
        selector: 'artwork-create',
        templateUrl: 'app/artwork/create/artwork-create.component.html',
        providers: [artwork_service_1.ArtworkService]
    }),
    __metadata("design:paramtypes", [router_1.Router,
        artwork_service_1.ArtworkService,
        alert_service_1.AlertService])
], ArtworCreateComponent);
exports.ArtworCreateComponent = ArtworCreateComponent;
//# sourceMappingURL=artwork-create.component.js.map