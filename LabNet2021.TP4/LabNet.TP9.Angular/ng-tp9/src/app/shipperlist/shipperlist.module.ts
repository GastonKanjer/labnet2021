import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperlistComponent } from './shipperlist.component';
import { ReactiveFormsModule } from '@angular/forms';


import { MatTableModule } from '@angular/material/table';
import {FormsModule} from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    ShipperlistComponent
  ],
  imports: [
    CommonModule,
    MatTableModule,
    MatInputModule,
    MatButtonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule

  ],
  exports:[
    ShipperlistComponent
  ]
})
export class ShipperlistModule { }
