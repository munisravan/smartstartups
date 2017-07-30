import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';

import { GoogleMapsComponent } from './components/google-maps/google-maps.component';
import { AboutusComponent } from './components/aboutus/aboutus.component';

import { Ng4GeoautocompleteModule } from 'ng4-geoautocomplete';

import { MobilePrototypeComponent } from './components/mobile-prototype/mobile-prototype.component';

import {VideoComponent } from './components/video/video.component';

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        GoogleMapsComponent,
        AboutusComponent,
        MobilePrototypeComponent,
        VideoComponent
    ],
    imports: [
        Ng4GeoautocompleteModule.forRoot(),
        BrowserModule,
       
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            {path:'mobile', component: MobilePrototypeComponent},
            { path: 'aboutus', component: AboutusComponent },
            {path:'video', component:VideoComponent},
            { path: 'search', component: GoogleMapsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
};
