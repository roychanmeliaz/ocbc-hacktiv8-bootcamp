import { Component, Input, OnInit } from '@angular/core';
import { Country } from 'src/app/models/country';

@Component({
  selector: 'app-country-detail',
  templateUrl: './country-detail.component.html',
  styleUrls: ['./country-detail.component.css']
})
export class CountryDetailComponent implements OnInit {
  @Input() data:Country={} as Country
  constructor() { }

  ngOnInit(): void {
    console.log(this.data)
  }

}
