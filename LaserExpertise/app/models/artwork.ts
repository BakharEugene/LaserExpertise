import {Image} from './image';
export class Artwork {
    Id: number;
    Name: string;
    ArtistId: number;
    Images: Image[];
    Genre: string;
    School: string;
    Description: string;
}