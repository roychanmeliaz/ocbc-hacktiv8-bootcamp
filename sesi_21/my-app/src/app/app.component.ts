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
  showParagraph = true;

  messages = [
    "I can see you",
    "You cannot see me anymore",
    "Now you see me",
    "Now you don't"
  ]

  people= [
    {
      name: "Ricky",
      age: 17,
      country: "MARS"
    },
    {
      name: "Etasa",
      age: 19,
      country: "USA"
    },
    {
      name: "Bayu",
      age: 19,
      country: "HK"
    },
    {
      name: "Etasa",
      age: 19,
      country: "USA"
    },
    {
      name: "Ryan",
      age: 18,
      country: "UK"
    },
    {
      name: "Rara",
      age: 18,
      country: "USA"
    }
  ]

  // pipe
  currentDate = new Date;

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
