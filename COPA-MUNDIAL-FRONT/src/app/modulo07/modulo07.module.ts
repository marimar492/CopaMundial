import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Modulo07RoutingModule } from './modulo07-routing.module';
import { VerPartidosComponent } from './components/ver-partidos/ver-partidos.component';
import { LogroEquipoComponent } from './components/logro-equipo/logro-equipo.component';
import { LogroCantidadComponent } from './components/logro-cantidad/logro-cantidad.component';

@NgModule({
  imports: [
    CommonModule,
    Modulo07RoutingModule,
    HttpClientModule,
    FormsModule
  ],
  declarations: [VerPartidosComponent, LogroEquipoComponent, LogroCantidadComponent]
})
export class Modulo07Module { }
