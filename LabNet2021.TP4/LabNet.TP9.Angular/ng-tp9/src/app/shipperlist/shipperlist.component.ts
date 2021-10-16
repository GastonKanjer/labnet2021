import { Component, OnInit, ViewChild } from '@angular/core';
import { AbstractControl, Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatTable } from '@angular/material/table';
import { ModalDirective } from 'angular-bootstrap-md';

import { Shippers } from './models/shippers';
import{NgbModal} from '@ng-bootstrap/ng-bootstrap';
import { ShipperlistService } from './services/shipperlist.service';



@Component({
  selector: 'app-shipperlist',
  templateUrl: './shipperlist.component.html',
  styleUrls: ['./shipperlist.component.scss'],
})
export class ShipperlistComponent implements OnInit {


  public listShippers:Array<Shippers>;
  public form:FormGroup;


mId=0;
mName='';
mPhone=0;



 /* get idCtrl(): AbstractControl {
    return this.form.get('id');
  }

  get nombreCtrl(): AbstractControl {
    return this.form.get('nombre');
  }

  get phoneCtrl(): AbstractControl {
    return this.form.get('phone');
  }*/



  constructor(private fb: FormBuilder, private modalService:NgbModal, private shippersService: ShipperlistService ) {}


 // @ViewChild(MatTable)table!:MatTable<Shippers>;


  ngOnInit(): void {
    this.obtenerShippers();
    console.log()
    this.initForm();
  }

  initForm(){

    this.form = this.fb.group({
      id:['',[Validators.required, Validators.maxLength(4)]],
      name:['',[Validators.required, Validators.maxLength(40)]],
      phone:['',[Validators.required, Validators.maxLength(15)]]
    });
  }

  onSubmit(): void {
    //this.listObjectShippers.push(this.form.value);
  }

  /*onClickLimpiar(): void {
    if (this.idCtrl) {
      this.idCtrl.setValue('');
    }

    if (this.nombreCtrl) {
      this.nombreCtrl.setValue('');
    }

    if (this.phoneCtrl) {
      this.phoneCtrl.setValue('');
    }
  }*/


  borrarFila(ship: Shippers) {
    if (confirm("¿Realmente quiere borrarlo?")) {
      //this.listObjectShippers.splice(ship.id,1);
     // this.table.renderRows();
    }
  }

  get f(){return this.form.controls;}
  guardarShipper(){
    var shipper = new Shippers();
    shipper.ShipperID= this.form.get('id').value;
    shipper.CompanyName = this.form.get('name').value;
    shipper.Phone= this.form.get('phone').value;

    this.shippersService.crearShipper(shipper).subscribe(res =>{
      this.form.reset();
      console.log('guardado');
    });
  }

  cancelarFormulario(){
    this.form.reset();
  }

  obtenerShippers(){
    this.shippersService.obtenerShippers().subscribe(res=>{
        this.listShippers=res;
        console.log(this.listShippers);
    });
  }
  abrirModal(content: any, ship:Shippers){
  /* this.modalService.open(content,{ariaLabelledBy:'modal-basic-tittle'});
   this.mId = ship.id;
   this.mName= ship.name;
   this.mPhone=ship.phone*/


  }


}





