import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls:['./home.component.css']
})
export class HomeComponent {

    onSignin() {
        alert("Thanks for signing up and you knew it is a prototype");
    }
}
