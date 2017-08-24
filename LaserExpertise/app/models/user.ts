import {Role} from './role'
export class User {
    Id: number;
    FirstName: string;
    LastName: string;
    Email: string;
    Telephone: string;
    Skype: string
    Role: Role;
    Gender: boolean;
    Password: string;


    constructor(username: string, password: string) {
        this.Email = username;
        this.Password = password;
    }
    
}
