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
import {WebServices} from './web.services';
import{ HttpModule} from '@angular/http';


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
    MatToolbarModule,
    HttpModule
  ],
  providers: [WebServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
