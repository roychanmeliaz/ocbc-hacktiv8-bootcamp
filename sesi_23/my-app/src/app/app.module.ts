import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NoEncapsulationComponent } from './view-encapsulation/no-encapsulation/no-encapsulation.component';
import { EmulatedEncapsulationComponent } from './view-encapsulation/emulated-encapsulation/emulated-encapsulation.component';
import { ShadowDomEncapsulationComponent } from './view-encapsulation/shadow-dom-encapsulation/shadow-dom-encapsulation.component';

@NgModule({
  declarations: [
    AppComponent,
    NoEncapsulationComponent,
    EmulatedEncapsulationComponent,
    ShadowDomEncapsulationComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
