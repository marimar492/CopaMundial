import { Component, OnInit } from '@angular/core';
import {RouterModule, Router } from '@angular/router';
declare var jquery:any;
declare var $ :any;

@Component({
  selector: 'app-consultar-ciudad',
  templateUrl: './consultar-ciudad.component.html',
  styleUrls: ['./consultar-ciudad.component.css']
})
export class ConsultarCiudadComponent implements OnInit {


  ciudades: any = [
      {id:"1",nombre: 'Moscú',habitantes: 50, descripcion: 'hola'},
      {id:"2",nombre: 'San Petersburgo', habitantes: 1, descripcion: 'como'},
      {id:"3",nombre: 'Kaliningrado', habitantes: 5, descripcion: 'estas'},
      {id:"4",nombre: 'Nizhny Nóvgorod', habitantes: 2, descripcion: 'bien'},
      {id:"5",nombre: 'Volgogrado',habitantes: 1000, descripcion: 'chevere'}
  ]  



  constructor(){}
 // constructor(private router: Router){}

  ngOnInit() {
  $('#infoCiudad').hide();
  }


mostrarInformacion(): void{

  this.ciudades.forEach(function(value) { 
    	if (value.id == $('select[id=Ciudad]').val()) { 
        $('p[id=nombre]').text('').append(value.nombre);
        $('p[id=habitantes]').text('').append(value.habitantes);
        $('p[id=descripcion]').text('').append(value.descripcion);
      } 
    }
  ); 
  $('h2[id=nombreCiudad]').text('').append($('select[id=Ciudad]').val());
 
  $('#infoCiudad').show();

  
}

  //volver(): void {
		//this.router.navigate(['admin/city']);
  //}

}