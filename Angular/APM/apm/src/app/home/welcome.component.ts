import { Component } from "@angular/core";

@Component({
    selector: 'pm-welcome',
    template: '<h2>{{saludo}}</h2>'
})

export class WelcomeComponent {
    saludo: string = "Hola Mundo!"
}