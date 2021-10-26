import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {

  @Input() name = '';
  text = ['bootcamp', 'hacktiv8', 'ocbc'];
  random = 0;
  message = this.text[this.random];

  @Output() clickEventHandler = new EventEmitter<string>();

  constructor() { }

  // 1 function untuk handle event
  onButtonClick() {
    this.clickEventHandler.emit(this.text[this.random])
    this.random++;
    if (this.random>=this.text.length) {
      this.random = 0;
    }
    this.message = this.text[this.random]
  }

  ngOnInit(): void {
  }

}
