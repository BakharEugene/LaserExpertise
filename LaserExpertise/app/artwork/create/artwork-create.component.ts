import { Component, OnInit} from '@angular/core';
import { Response } from '@angular/http';
import { Artwork } from '../../models/artwork';
import { ActivatedRoute, Router, RouterModule, Routes } from '@angular/router';
import {AlertService} from '../../alert/alert.service';
import { ArtworkService } from '../artwork.service';
@Component({
    selector: 'artwork-create',
    templateUrl: 'app/artwork/content/artwork-create.component.html',
    providers: [ArtworkService]
})
export class ArtworCreateComponent implements OnInit {
    model: any = {};
    loading: boolean;
    artwork: Artwork;

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
                this.alertService.error(JSON.stringify(error));
                this.loading = false;
            });
    }
}   