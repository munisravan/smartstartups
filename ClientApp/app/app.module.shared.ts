import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';

import { GoogleMapsComponent } from './components/google-maps/google-maps.component';
import { AboutusComponent } from './components/aboutus/aboutus.component';

import { Ng4GeoautocompleteModule } from 'ng4-geoautocomplete';



export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        GoogleMapsComponent,
        AboutusComponent
    ],
    imports: [
        Ng4GeoautocompleteModule,
        BrowserModule,
       
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            {path:'aboutus', component:AboutusComponent},
            { path: 'search', component: GoogleMapsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
};
