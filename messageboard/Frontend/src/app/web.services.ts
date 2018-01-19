import {Http} from '@angular/http';
import {Injectable} from '@angular/core';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class WebServices{
   constructor (private http: Http){}

  getMessages(){
     this.http.get ('http://localhost:53401/api/messages');
  }
}