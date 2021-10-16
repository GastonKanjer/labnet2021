import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Shippers } from '../models/shippers';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ShipperlistService {

  endpoint: string = 'ShippersApi';
  url = environment.apiShippers + this.endpoint;
  constructor(private http: HttpClient) {}

  public crearShipper(shipperRequest: Shippers): Observable<any> {
    return this, this.http.post(this.url, shipperRequest);
  }

  public obtenerShippers(): Observable<Array<Shippers>> {

    return this.http.get<Array<Shippers>>(this.url);
  }

  public borrarShipper(id){
    //debugger;
    let url =  environment.apiShippers + this.endpoint;
    return this.http.delete<any>(this.url+id)
  }

  public modificarShipper(shipperRequest:Shippers):Observable<any>{
    return this.http.put<any>(this.url + shipperRequest.ShipperID, shipperRequest)

  }
}
