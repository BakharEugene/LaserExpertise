import {Injectable} from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router';

import {Http} from '@angular/http';
import { Artwork } from '../models/artwork';

@Injectable()
export class HttpService {

    constructor(private http: Http) { }

    Artworks() {
        return this.http.get('/Artworks/Index');
    }
    ArtworksById(id: number) {
        return this.http.get('/Artworks/Detail/'+id);
    }
}