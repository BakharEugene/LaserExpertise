﻿import { Component, OnInit } from '@angular/core';

import { AlertService } from './alert.service';

@Component({
    selector: 'alert',
    templateUrl: 'app/alert/alert.component.html'
})

export class AlertComponent {
    message: any;

    constructor(private alertService: AlertService) { }

    ngOnInit() {
        this.alertService.getMessage().subscribe(message => { this.message = message; });
    }
}