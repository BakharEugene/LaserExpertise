"use strict";
class PasswordValidation {
    static MatchPassword(AC) {
        let password = AC.get('password').value; // to get value in input tag
        let confirmPassword = AC.get('confirmPassword').value; // to get value in input tag
        if (password != confirmPassword) {
            console.log('false');
            AC.get('confirmPassword').setErrors({ MatchPassword: true });
        }
        else {
            console.log('true');
            return null;
        }
    }
}
exports.PasswordValidation = PasswordValidation;
//# sourceMappingURL=passwordvalidation.service.js.map