import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';

import { GoogleMapsComponent } from './components/google-maps/google-maps.component';
import { AboutusComponent} from './components/aboutus/aboutus.component';

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
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            {path:'aboutus', component:AboutusComponent},
            { path: 'search', component: GoogleMapsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
};
