import { Injectable } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router';

import { Http } from '@angular/http';
import { Artwork } from '../models/artwork';

@Injectable()
export class ArtworkService {

    constructor(private http: Http) { }

    artworks() {
        return this.http.get('/Artworks/Index');
    }
    artworksById(id: number) {
        return this.http.get('/Artworks/Detail/'+id);
    }
    
    create(artwork: Artwork) {
        
        return this.http.post('/Artworks/Create' + artwork,"");
    }
}