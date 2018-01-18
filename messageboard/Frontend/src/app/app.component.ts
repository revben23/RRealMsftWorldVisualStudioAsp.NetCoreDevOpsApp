import { Component } from '@angular/core';
import {MessagesComponent} from './messages.componet';

@Component({
  selector: 'app-root',
  template: '<h1>{{title}}</h1><messages></messages>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Msft World Angular Message Board';
}
