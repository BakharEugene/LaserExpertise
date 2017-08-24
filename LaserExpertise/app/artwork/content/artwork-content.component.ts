import { Component, OnInit, Input} from '@angular/core';
import { Response} from '@angular/http';
import { HttpService} from '../artwork.service';
import {Artwork} from '../../models/artwork';
import { ActivatedRoute, RouterModule, Routes } from '@angular/router';
import {SerializationHelper} from '../../serialize/serializable'

@Component({
    selector: 'artwork-content',
    templateUrl: 'app/artwork/content/artwork-content.component.html',
    providers: [HttpService]
})
export class ArtworkContentComponent implements OnInit {
    @Input() id: number;
    artwork: Artwork;

    constructor(private httpService: HttpService,
        private activateRoute: ActivatedRoute) {
        this.id = activateRoute.snapshot.params['id'];

    }

    ngOnInit() {
        this.httpService.ArtworksById(this.id).subscribe((data: Response) => {
            this.artwork = SerializationHelper.toInstance(new Artwork, (JSON.stringify(data.json())));
            alert(JSON.stringify(this.artwork));
        });
    }
}   