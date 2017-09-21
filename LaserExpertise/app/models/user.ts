import {Privileges} from './privileges'
export class User {
    Id: number;
    FirstName: string;
    LastName: string;
    Email: string;
    Telephone: string;
    Skype: string
    Privileges: Privileges;
    Gender: string;
    Password: string;
    BirthDay: Date;


    constructor(username: string, password: string) {
        this.Email = username;
        this.Password = password;
    }
    
}
