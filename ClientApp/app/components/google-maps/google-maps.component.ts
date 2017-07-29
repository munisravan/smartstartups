import { Component, OnInit } from '@angular/core';
import { Ng4GeoautocompleteModule } from 'ng4-geoautocomplete';
import { AgmCoreModule } from '@agm/core';



@Component({
  selector: 'app-google-maps',
  templateUrl: './google-maps.component.html',
  //styleUrls: ['./google-maps.component.scss']
  styles: [`
    agm-map {
      height: 300px;
    }
  `],


})
export class GoogleMapsComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  lat: number = 51.678418;
  lng: number = 7.809007;

  public userSettings: any = {
      showRecentSearch: true,
      geoCountryRestriction: ['au'],
      inputPlaceholderText: "Address"

  };

  autoCompleteCallback1(selectedData: any) {
      alert(selectedData);
  }

}
