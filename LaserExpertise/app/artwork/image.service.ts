import { Injectable } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router';

import { Http } from '@angular/http';
import { Image } from '../models/image';

@Injectable()
export class ImageService {

    constructor(private http: Http) { }

    imageById(id: number) {
        return this.http.get('/Images/Detail/'+id);
    }

    create(image: any) {
        alert("ty pidor");
        alert(JSON.stringify(image.name));
        return this.http.post('/Images/Create' + image, "");
    }
}