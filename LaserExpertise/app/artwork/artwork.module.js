"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var forms_1 = require("@angular/forms");
var artwork_component_1 = require("./artwork.component");
var artwork_content_component_1 = require("./content/artwork-content.component");
var artwork_create_component_1 = require("./create/artwork-create.component");
var ArtworkModule = (function () {
    function ArtworkModule() {
    }
    return ArtworkModule;
}());
ArtworkModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            http_1.HttpModule,
            router_1.RouterModule,
            forms_1.FormsModule
        ],
        declarations: [
            artwork_component_1.ArtworkComponent, artwork_content_component_1.ArtworkContentComponent, artwork_create_component_1.ArtworCreateComponent
        ],
        bootstrap: [artwork_component_1.ArtworkComponent]
    })
], ArtworkModule);
exports.ArtworkModule = ArtworkModule;
//# sourceMappingURL=artwork.module.js.map