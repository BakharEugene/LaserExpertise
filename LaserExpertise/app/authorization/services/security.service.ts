import {Injectable} from "@angular/core";
import {ActivatedRouteSnapshot, CanActivate, Router} from "@angular/router";
import {User} from "../../models/user";
import {Role} from "../../models/role";

@Injectable()
export class SecurityService implements CanActivate {
    constructor(private router: Router) {
        this.router = router;
    }

    canActivate(route: ActivatedRouteSnapshot): boolean {
        let canActivate: boolean = false;
        const roles = route.data["roles"] as Array<string>;
        const user: User = this.getCurrentUser();
        if (roles.length > 0 && user) {
            canActivate = this.checkRoles(roles, user.Role);
        }
        return canActivate;
    }

    getCurrentUser(): User {

        let user: User = JSON.parse(localStorage.getItem('currentUser'));
        return user;
    }

    static containsRole(array: any[], obj: any): boolean {
        let index = array.length;
        while (index--) {
            if (array[index] === obj)
                return true;
        }
        return false;
    }

    private checkRoles(availableRolesList: string[], currentRole:Role): boolean {
        let flag = false;
        if (SecurityService.containsRole(availableRolesList, currentRole)) {
            flag = true;
        }
        return flag;
    }
}