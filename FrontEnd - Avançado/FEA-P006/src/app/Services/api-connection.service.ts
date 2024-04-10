import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiConnectionService {

  constructor(private httpClient: HttpClient) { }

  public getBrasilData() {
    return this.httpClient.get('https://restcountries.com/v3.1/name/brazil');
  }
  
}
