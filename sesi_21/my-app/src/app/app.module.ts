import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ButtonComponent } from './button/button.component';
import { AsideComponent } from './aside/aside.component';
import { AddNewItemComponent } from './add-new-item/add-new-item.component';
import { CounterButtonComponent } from './counter-button/counter-button.component';
import { ParagraphComponent } from './paragraph/paragraph.component';
import { FileSizePipe } from './file-size.pipe';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ButtonComponent,
    AsideComponent,
    AddNewItemComponent,
    CounterButtonComponent,
    ParagraphComponent,
    FileSizePipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
