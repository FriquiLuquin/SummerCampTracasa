import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  // templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

  template:`
    <pm-conversor></pm-conversor>
    <pm-historial></pm-historial>
    <!-- <pm-monedas></pm-monedas> -->
  `
})
export class AppComponent {
  pageTitle = 'APM';
}
