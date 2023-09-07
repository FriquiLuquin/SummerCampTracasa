import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MissionControlComponent } from './missioncontrol.component';
import { AstronautComponent } from './astronaut.component';

@NgModule({
  declarations: [
    AppComponent,
    MissionControlComponent,
    AstronautComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
