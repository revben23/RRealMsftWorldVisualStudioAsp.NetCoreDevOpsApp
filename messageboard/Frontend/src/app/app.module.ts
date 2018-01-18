import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {
        MatButtonModule, 
        MatCardModule,
        MatInputModule,
        MatSnackBarModule,
        MatToolbarModule
} from '@angular/material';

import { Component } from '@angular/core';
import {MessagesComponent} from './messages.componet'

import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent, MessagesComponent, 
  ],
  imports: [
    BrowserModule, 
    BrowserAnimationsModule,
    MatButtonModule, 
    MatCardModule,
    MatInputModule,
    MatSnackBarModule,
    MatToolbarModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
