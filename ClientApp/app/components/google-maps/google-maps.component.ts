import { Component, OnInit } from '@angular/core';
import { Ng4GeoautocompleteModule } from 'ng4-geoautocomplete';

import { location}  from './model'
declare var google: any;



@Component({
  selector: 'app-google-maps',
  templateUrl: './google-maps.component.html',
  styleUrls: ['./google-maps.component.css']
})
export class GoogleMapsComponent implements OnInit {

    public locationInfo: location;
   
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
  visible: boolean = false;

  public userSettings: any = {
      showRecentSearch: true,
      geoCountryRestriction: ['au'],
      inputPlaceholderText: "Address",
      showCurrentLocation: false

  };



  autoCompleteCallback1(selectedData: any) {
      //this.lat = selectedData.geometry.location.lat;
      //this.lng = selectedData.geometry.location.lng;
      this.visible = true;
      alert("you searched for latitude:" + selectedData.geometry.location.lat + " and longitude:" + selectedData.geometry.location.lng + "  This is a prototype so added static images");

  }



}
