import { Component, OnInit } from '@angular/core';
import { Ng4GeoautocompleteModule } from 'ng4-geoautocomplete';
declare var google: any;



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
      //var mapProp = {
      //    center: new google.maps.LatLng(51.508742, -0.120850),
      //    zoom: 5,
      //    mapTypeId: google.maps.MapTypeId.ROADMAP
      //};
      //var map = new google.maps.Map(document.getElementById("gmap"), mapProp);
  }

  lat: number = 51.678418;
  lng: number = 7.809007;

  public userSettings: any = {
      showRecentSearch: true,
      geoCountryRestriction: ['au'],
      inputPlaceholderText: "Address",
      showCurrentLocation:false

  };



  autoCompleteCallback1(selectedData: any) {
      alert(selectedData);
  }



}
