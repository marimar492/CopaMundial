import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DataTablesModule } from 'angular-datatables';
import { HttpClientModule } from '@angular/common/http';

import { Modulo08RoutingModule } from './modulo08-routing.module';
import { RegistrarApuestaComponent } from './components/registrar-apuesta/registrar-apuesta.component';
import { GestionarApuestaComponent } from './components/gestionar-apuesta/gestionar-apuesta.component';
import { VerApuestaComponent } from './components/ver-apuesta/ver-apuesta.component';

@NgModule({
  imports: [
    CommonModule,
     FormsModule,
     HttpClientModule,
     DataTablesModule,
     Modulo08RoutingModule
    ],
  declarations: [
    RegistrarApuestaComponent,
    GestionarApuestaComponent,
    VerApuestaComponent
  ]
})
export class Modulo08Module {}
