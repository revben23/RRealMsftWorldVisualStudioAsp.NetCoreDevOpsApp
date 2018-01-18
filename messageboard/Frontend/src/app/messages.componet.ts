import { Component } from '@angular/core'

@Component({
  selector: 'messages',
  template: `
  <div *ngFor="let message of messages">
      <mat-card style="margin:8px"> 
     <mat-card-title> {{message.owner }}</mat-card-title>
     <mat-card-content> {{message.text}}</mat-card-content>
      </mat-card>
   </div>
   `

   
})

export class MessagesComponent{
    messages = [{text: 'Some Text', owner: 'Revi'}, {text: 'More text', owner: 'Christopher'}];
}