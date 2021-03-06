import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  counter = 0;
  text='';
  items = ['sepatu','jeans','kaos'];
  num=0;
  minDisable = true;

  buttonState = true;

  constructor() {}

  // 

  // event handlers

  setFalse() {
    this.buttonState=false;
  }

  addCounter(text:string) {
    this.counter++;
    this.text = text;
    console.log('klik')
  }

  increment() {
    this.num++;
    console.log('increment')
    this.minDisable=false;
  }
  decrement() {
    this.num--;
    console.log('decrement')
    if (this.minDisable==false && this.num<=0) {
      this.minDisable=true;
    }
  }

  addItemInParent(value:string) {
    this.items.push(value)
    console.log('additem')
  }

  hapusItem() {
    this.items.pop()
    console.log('hapusitem')
  }
}
