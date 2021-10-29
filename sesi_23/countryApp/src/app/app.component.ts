import { Component, OnInit } from '@angular/core';
import { Country } from './models/country';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'countryApp';

  ui_mode:number=0;

  countryToSend:Country = {} as Country

  countriesByGdp:Country[] = []
  countriesByArea:Country[] = []
  countriesByPopulation:Country[] = []

  countries:Country[] = [
    {
      country:"United States of America",
      capital:"Washington",
      area:9525067,
      population: 331002651,
      gdp: 22675271,
      currency:"US Dollar"
    },
    {
      country:"Indonesia",
      capital:"Jakarta",
      area:1904569,
      population: 273523615,
      gdp: 1158783,
      currency:"Indonesian Rupiah"
    },
    {
      country:"Russia",
      capital:"Moscow",
      area:17098246,
      population: 145934462,
      gdp: 1710734,
      currency:"Russian Ruble"
    },
    {
      country:"India",
      capital:"New Delhi",
      area:3287263,
      population: 1380004385,
      gdp: 3049704,
      currency:"Indian Rupee"
    },
    {
      country:"Canada",
      capital:"Ottawa",
      area:9984670,
      population: 37742154,
      gdp: 1883487,
      currency:"Canadian Dollar"
    },
    {
      country:"China",
      capital:"Beijing",
      area:9596961,
      population: 1439323776,
      gdp: 16642318,
      currency:"Renminbi"
    },
  ];

  ngOnInit() {
    this.countriesByGdp = [...this.countries];
    this.countriesByArea = [...this.countries];
    this.countriesByPopulation = [...this.countries];
    this.countriesByGdp.sort((a,b) => (a.gdp > b.gdp) ? -1 : ((b.gdp > a.gdp) ? 1 : 0))
    this.countriesByArea.sort((a,b) => (a.area > b.area) ? -1 : ((b.area > a.area) ? 1 : 0))
    this.countriesByPopulation.sort((a,b) => (a.population > b.population) ? -1 : ((b.population > a.population) ? 1 : 0))
    this.countriesByGdp = this.countriesByGdp.slice(0, 3);
    this.countriesByPopulation = this.countriesByPopulation.slice(0, 3);
    this.countriesByArea = this.countriesByArea.slice(0, 3);
  }
  gotoCountryDetail(countryName:string) {
    console.log(countryName)
    this.ui_mode=2;
    this.countryToSend = this.countries.find( ({country}) => country === countryName)!;
  }
}
