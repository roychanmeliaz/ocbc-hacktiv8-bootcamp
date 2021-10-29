import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Country } from 'src/app/models/country';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  @Input() countriesByGdp:Country[] = []
  @Input() countriesByArea:Country[] = []
  @Input() countriesByPopulation:Country[] = []
  // @Output() clickEvent = new EventEmitter<number>()
  @Output() clickEvent = new EventEmitter<string>()

  constructor() { }

  ngOnInit(): void {
  }
  // emitEvent(id:number) {
  //   this.clickEvent.emit(id)
  // }
  emitEvent(countryName:string) {
    this.clickEvent.emit(countryName)
  }

}
