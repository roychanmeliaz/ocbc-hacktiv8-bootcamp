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
  }
  decrement() {
    this.num--;
    console.log('decrement')
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
