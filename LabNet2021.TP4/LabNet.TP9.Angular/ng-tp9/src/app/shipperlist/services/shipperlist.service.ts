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
  constructor(private http: HttpClient) {}

  public crearShipper(shipperRequest: Shippers): Observable<any> {
    let url = environment.apiShippers + this.endpoint;
    return this, this.http.post(url, shipperRequest);
  }

  public obtenerShippers(): Observable<Array<Shippers>> {
    let url = environment.apiShippers + this.endpoint;
    return this.http.get<Array<Shippers>>(url);
  }
}
