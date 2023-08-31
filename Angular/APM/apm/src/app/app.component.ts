import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  // templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

  template:`
    <pm-monedas></pm-monedas>
    <pm-conversor></pm-conversor>
  `
})
export class AppComponent {
  pageTitle = 'APM';
}
