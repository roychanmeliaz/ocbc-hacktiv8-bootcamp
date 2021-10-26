import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-counter-button',
  templateUrl: './counter-button.component.html',
  styleUrls: ['./counter-button.component.css']
})
export class CounterButtonComponent implements OnInit {

  constructor() { }
  @Input() name = '';
  @Input() isDisabled = false;

  @Output() clickEventHandler = new EventEmitter<string>();

  ngOnInit(): void {
  }
  // 1 function untuk handle event
  onButtonClick() {
    this.clickEventHandler.emit("")
  }

  ngOnDestroy() {
    console.log("Button Destroyed")
  }


}
