import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Country } from './Country';
import { City } from './City';
import { Weather } from './Weather';

@Component({
  selector: 'app-get-weather',
  templateUrl: './get-weather.component.html'
})
export class GetWeatherComponent {

  selectedCountry: Country = new Country('--Select--');
  selectedCity: City = new City('--Select--', '--Select--');
  countries: Country[];
  cities: City[];
  weather: Weather;

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {

    http.get<Country[]>(baseUrl + 'weather/getcountry').subscribe(result => {
      this.countries = result;
    }, error => console.error(error));

  }

  onSelectCountry(country) {
    this.selectedCity = new City('--Select--', '--Select--');
    this.http.get<City[]>(this.baseUrl + 'weather/getcity/' + country).subscribe(result => {
      this.cities = result;
    }, error => console.error(error));
  }

  onSelectCity(city) {
    this.http.get<Weather>(this.baseUrl + 'weather/getweather/' + city).subscribe(result => {
      this.weather = result;
    }, error => console.error(error));
  }
}



