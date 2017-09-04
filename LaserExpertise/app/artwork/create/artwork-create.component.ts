import { Component, OnInit} from '@angular/core';
import { Response } from '@angular/http';
import { Artwork } from '../../models/artwork';
import { ActivatedRoute, Router, RouterModule, Routes } from '@angular/router';
import {AlertService} from '../../alert/alert.service';
import { ArtworkService } from '../artwork.service';
@Component({
    selector: 'artwork-create',
    templateUrl: 'app/artwork/create/artwork-create.component.html',
    providers: [ArtworkService]
})
export class ArtworCreateComponent implements OnInit {
    model: any = {};
    loading: boolean;
    genres = [
        { id: 1, name: "United States" },
        { id: 2, name: "Australia" },
        { id: 3, name: "Canada" },
        { id: 4, name: "Brazil" },
        { id: 5, name: "England" }
    ];

    schools = [
        { id: 1, name: "kek" },
        { id: 2, name: "mem" },
        { id: 3, name: "lol" },
        { id: 4, name: "lul" },
        { id: 5, name: "lel" }
    ];

    constructor(
        private router: Router,
        private artworkService: ArtworkService,
        private alertService: AlertService) {
    }

    ngOnInit() {

    }

    create(): void {
        this.loading = true;
        this.artworkService.create(this.model)
            .subscribe(
            data => {
                this.alertService.success(JSON.stringify(data), true);
                this.router.navigate(['/artworks']);
            },
            error => {
                alert(JSON.stringify(this.model));

                this.alertService.error(JSON.stringify(error));
                this.loading = false;
            });
    }



}   