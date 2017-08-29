import { Component, OnInit, Input} from '@angular/core';
import { Response} from '@angular/http';
import { ArtworkService} from '../artwork.service';
import {Artwork} from '../../models/artwork';
import { ActivatedRoute, RouterModule, Routes } from '@angular/router';
import {SerializationHelper} from '../../serialize/serializable'

@Component({
    selector: 'artwork-content',
    templateUrl: 'app/artwork/content/artwork-content.component.html',
    providers: [ArtworkService]
})
export class ArtworkContentComponent implements OnInit {
    @Input() id: number;
    artwork: Artwork;

    constructor(private httpService: ArtworkService,
        private activateRoute: ActivatedRoute) {
        this.id = activateRoute.snapshot.params['id'];

    }

    ngOnInit() {
        this.httpService.artworksById(this.id).subscribe((data: Response) => {
            this.artwork = SerializationHelper.toInstance(new Artwork, (JSON.stringify(data.json())));
            alert(JSON.stringify(this.artwork));
        });
    }
}   