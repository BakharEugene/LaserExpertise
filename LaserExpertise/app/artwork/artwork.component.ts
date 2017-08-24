import { Component, OnInit} from '@angular/core';
import { Response} from '@angular/http';
import { HttpService} from './artwork.service';
import {Artwork} from '../models/artwork';
import { RouterModule, Routes } from '@angular/router';
import {SerializationHelper} from '../serialize/serializable'


@Component({
    selector: 'artwork',
    templateUrl: 'app/artwork/artwork.component.html',
    providers: [HttpService]
})
export class ArtworkComponent implements OnInit {

    artworks: Artwork[];
    filteredItems: Artwork[];
    pageSize: number = 6;
    pages: number;
    currentIndex: number;
    pagesIndex: number[];
    pageStart: number;

    constructor(private httpService: HttpService) {
        this.artworks = [];
        this.pagesIndex = [];
        this.filteredItems = [];
    }

    ngOnInit() {
        this.load();
    }


    private load(): void {
        this.httpService.Artworks()
            .subscribe((data: Response) => {
                let artworksList = data.json();
                for (let index in artworksList) {
                    let artwork: Artwork;
                    this.artworks.push(artwork = SerializationHelper.toInstance(new Artwork, (JSON.stringify(artworksList[index]))));
                }
                
                this.filteredItems = this.artworks;
                this.createPagination();
            });
    }


    createPagination(): void {
        this.currentIndex = 1;
        this.pageStart = 1;
        this.pages = parseInt("" + this.filteredItems.length / this.pageSize);
        if (this.filteredItems.length % this.pageSize != 0) {
            this.pages++;
        }
        this.refreshItems();

    }
    onChangePageSize(): void {
        this.createPagination();
    }
    refreshItems(): void {
        this.artworks = this.filteredItems.slice((this.currentIndex - 1) * this.pageSize, (this.currentIndex) * this.pageSize);
        this.pagesIndex = this.fillArray();
    }

    fillArray(): any {
        let obj: any[]=[];
        for (let index = this.pageStart; index < this.pageStart + this.pages; index++) {
            obj.push(index);
        }
        return obj;
    }

    prevPage(): void {
        if (this.currentIndex > 1) {
            this.currentIndex--;
        }
        if (this.currentIndex < this.pageStart) {
            this.pageStart = this.currentIndex;
        }
        this.refreshItems();
    }

    nextPage(): void {
        if (this.currentIndex < this.pages) {
            this.currentIndex++;
        }
        if (this.currentIndex >= (this.pageStart + this.pages)) {
            this.pageStart = this.currentIndex - this.pages + 1;
        }
        this.refreshItems();
    }

    setPage(index: number): void {
        this.currentIndex = index;
        this.refreshItems();
    }
    



}