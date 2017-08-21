import { Component, OnInit} from '@angular/core';
import { Response} from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import {User} from '../models/user'
import {SerializationHelper} from '../serialize/serializable'
import { HttpService} from './home.service';
import {Artwork} from '../models/artwork';

@Component({
    selector: 'home',
    templateUrl: 'app/home/home.component.html',
    providers: [HttpService]

})
export class HomeComponent {
    currentUser: User;
    artworks: Artwork[][];
    constructor(private httpService: HttpService) {
        this.artworks = [];

        for (var i: number = 0; i < 3; i++) {
            this.artworks[i] = [];
        }


        this.currentUser = JSON.parse(localStorage.getItem('currentUser'));
    }

    ngOnInit() {
        this.getArtworks();
    }
    private getArtworks(): void {
        this.httpService.Artworks()
            .subscribe((data: Response) => {
                let artworksList = data.json();
                let i: number = 0;
                let j: number = 0;
                let tempArtworkList: Artwork[] = [];

                for (let index in artworksList) {
                    let artwork: Artwork;
                    if (parseInt(index) < 12) {
                        tempArtworkList.push(artwork = SerializationHelper.toInstance(new Artwork, (JSON.stringify(artworksList[index]))));
                        i++;
                        
                        if (i % 4 == 0) {
                            this.artworks[j] = tempArtworkList;      
                            i = 0;
                            j++;
                            tempArtworkList = [];
                        }
                    }
                    else break;
                }
            });
    }
}
