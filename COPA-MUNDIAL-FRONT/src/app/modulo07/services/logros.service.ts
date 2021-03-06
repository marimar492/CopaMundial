import { Injectable } from '@angular/core';
//import { Injectable, OnInit, Inject } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { Router } from '@angular/router';
import { DTOLogroEquipo } from '../models/DTOLogroEquipo';
import { DTOLogroCantidad } from '../models/DTOLogroCantidad';
import { DTOLogroJugador } from  '../models/DTOLogroJugador';
import { DTOLogroEquipoResultado } from '../models/DTOLogroEquipoResultado';
import { DTOLogroVF } from '../models/DTOLogroVF';
import { DTOLogroPartidoId } from '../models/DTOLogroPartidoId';
import { DTOListaPartidosLogros } from '../models/DTOListaPartidosLogros';
import { DTOLogroCantidadResultado } from '../models/DTOLogroCantidadResultado';
import { Observable } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { Subject } from 'rxjs';
import { config } from '../../config';

/*
const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
};*/

declare var alerta;
/**
@Injectable({
  providedIn: 'root'
})*/

@Injectable()
export class LogrosService{

  public service: LogrosService;
  public apiURL = config.url + '/logros/';
  public dtoPartidoPorId: DTOListaPartidosLogros;
  public logrosEquipo : DTOLogroEquipo[];
  public logrosJugador: DTOLogroJugador[];
  public logrosCantidad : DTOLogroCantidad[];
  public logrosVF : DTOLogroVF[];
  public dtoPartidoId: DTOLogroPartidoId = new  DTOLogroPartidoId();
  public dtoListaPartido : DTOListaPartidosLogros[] = [];
  public dtoListaPartidoFinaliz : DTOListaPartidosLogros[] = [];


    constructor(public http: HttpClient)
    {

        this.logrosEquipo = new Array as Array <DTOLogroEquipo>;
        this.dtoPartidoPorId = new DTOListaPartidosLogros();
     }


    public ObtenerPartidoDTO(idPartido): DTOListaPartidosLogros
    {
      const url = this.apiURL+ 'obtenerLogroPartidoPorId';
      this.dtoPartidoPorId.IdPartido = idPartido;
        console.log(this.dtoPartidoPorId);
        this.http.put<DTOListaPartidosLogros>(url,this.dtoPartidoPorId,{ responseType: 'json' }).subscribe(
          data => {
            console.log(data);
               this.dtoPartidoPorId.Equipo1 = data.Equipo1;
               this.dtoPartidoPorId.Equipo2 = data.Equipo2;
               this.dtoPartidoPorId.IdEquipo1 = data.IdEquipo1;
               this.dtoPartidoPorId.IdEquipo2 = data.IdEquipo2;
               this.dtoPartidoPorId.Fecha = data.Fecha;
               this.dtoPartidoPorId.IdPartido = data.IdPartido;
          },
          Error => {
            alert("No se pudieron obtener los partidos pendientes");
          }
        );
        return this.dtoPartidoPorId;
      }

    public ObtenerPartidosFinalizados(): DTOListaPartidosLogros[]
    {
      const url = this.apiURL+ 'obtenerLogrosPartidosFinalizados';

        this.http.get<DTOListaPartidosLogros>(url, { responseType: 'json' }).subscribe(
          data => {
            for (let i = 0; i < Object.keys(data).length; i++) {
              let partido: DTOListaPartidosLogros;

              partido = new DTOListaPartidosLogros();

              partido.IdPartido = data[i].IdPartido;
              partido.Equipo1 = data[i].Equipo1;
              partido.Equipo2 = data[i].Equipo2;
              partido.Fecha = data[i].Fecha;

              this.dtoListaPartidoFinaliz[i] = partido;
              console.log(data);
            }
          },
          Error => {
            alert("No se pudieron obtener los partidos finalizados");
          }
        );

        return this.dtoListaPartidoFinaliz;
      }

      public ObtenerProximosPartidos(): DTOListaPartidosLogros[]
      {
        const url = this.apiURL+ 'obtenerProximosLogrosPartidos';

          this.http.get<DTOListaPartidosLogros>(url, { responseType: 'json' }).subscribe(
            data => {
              for (let i = 0; i < Object.keys(data).length; i++) {
                let partido: DTOListaPartidosLogros;

                partido = new DTOListaPartidosLogros();

                partido.IdPartido = data[i].IdPartido;
                partido.Equipo1 = data[i].Equipo1;
                partido.Equipo2 = data[i].Equipo2;
                partido.Fecha = data[i].Fecha;

                this.dtoListaPartido[i] = partido;
                console.log(data);
              }
            },
            Error => {
              alert("No se pudieron obtener los partidos pendientes");
            }
          );

          return this.dtoListaPartido;
        }


  public obtenerLogrosEquipoDTO(idPartido: number): DTOLogroEquipo[]
  {
          this.dtoPartidoId.idPartido = idPartido;
          const url = this.apiURL+ 'obtenerLogrosEquipoPendiente';
          this.http.put<DTOLogroEquipo[]>(url, idPartido, {
              responseType: 'json'
            })
            .subscribe(
              data => {
                for (let i = 0; i < Object.keys(data).length; i++) {
                  let logroEquipo: DTOLogroEquipo;
                  logroEquipo = new DTOLogroEquipo();

                  logroEquipo.IdPartido = data[i].IdPartido;
                  logroEquipo.LogroEquipo = data[i].LogroEquipo;

                  this.logrosEquipo[i] = logroEquipo;
                  console.log(data);

                }
                Error => {

                    alert("No hay logros de Equipos pendientes en el partido");

                }

              }
            );

          return this.logrosEquipo;

  }


  public AgregarLogroEquipo(dtoLogroEquipo: DTOLogroEquipo)
  {

    const url2 = this.apiURL+ 'agregarLogroEquipo';
    return this.http.post<DTOLogroEquipo>(url2, dtoLogroEquipo, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Logro equipo agregado correctamente');
          }
        },
        Error => {
          alert("Error al agregar el logro");
        }
      );
  }


  public obtenerLogrosCantidadDTO(idPartido: number): DTOLogroCantidad[]
  {
          this.dtoPartidoId.idPartido = idPartido;
          const url = this.apiURL+ 'obtenerLogrosCantidadPendiente';
          this.http.put<DTOLogroCantidad[]>(url, idPartido, {
              responseType: 'json'
            })
            .subscribe(
              data => {
                for (let i = 0; i < Object.keys(data).length; i++) {
                  let logroCantidad: DTOLogroCantidad;
                  logroCantidad = new DTOLogroCantidad();

                  logroCantidad.IdPartido = data[i].IdPartido;
                  logroCantidad.LogroCantidad = data[i].LogroCantidad;

                  this.logrosCantidad[i] = logroCantidad;
                  console.log(data);

                }
                Error => {

                    alert("No hay logros de Cantidad pendientes en el partido");

                }

              }
            );

          return this.logrosCantidad;

  }

  public AgregarLogroCantidad(dtoLogroCantidad: DTOLogroCantidad)
  {

    const url2 = this.apiURL+ 'agregarLogroCantidad';
    return this.http.post<DTOLogroCantidad>(url2, dtoLogroCantidad, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Logro cantidad agregado correctamente');
          }
        },
        Error => {
          alert("Error al agregar el logro");
        }
      );
  }

  public AsignarResutadoLogroCantidad(dtoLogroCantidadResult: DTOLogroCantidadResultado)
  {

    const url2 = this.apiURL+ 'asignarResultadoLogroCantidad';
    return this.http.post<DTOLogroCantidadResultado>(url2, dtoLogroCantidadResult, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Resultado cantidad registrado correctamente');
          }
        },
        Error => {
          alert("Error al registrar cantidad el logro");
        }
      );
  }

  public AsignarResutadoLogroEquipo(dtoLogroEquipoResult: DTOLogroEquipoResultado)
  {

    const url2 = this.apiURL+ 'asignarResultadoLogroEquipo';
    return this.http.post<DTOLogroEquipoResultado>(url2, dtoLogroEquipoResult, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Resultado equipo registrado correctamente');
          }
        },
        Error => {
          alert("Error al registrar cantidad el logro");
        }
      );
  }


  

  public obtenerLogrosJugadorDTO(idPartido: number): DTOLogroJugador[]
  {
          this.dtoPartidoId.idPartido = idPartido;
          const url = this.apiURL+ 'obtenerLogrosJugadorPendiente';
          this.http.put<DTOLogroJugador[]>(url, idPartido, {
              responseType: 'json'
            })
            .subscribe(
              data => {
                for (let i = 0; i < Object.keys(data).length; i++) {
                  let logroJugador: DTOLogroJugador;
                  logroJugador = new DTOLogroJugador();

                  logroJugador.IdPartido = data[i].IdPartido;
                  logroJugador.LogroJugador = data[i].LogroJugador;

                  this.logrosJugador[i] = logroJugador;
                  console.log(data);

                }
                Error => {

                    alert("No hay logros de Jugador pendientes en el partido");

                }

              }
            );

          return this.logrosJugador;

  }

  public AgregarLogroJugador(dtoLogroJugador: DTOLogroJugador)
  {

    const url2 = this.apiURL+ 'agregarLogroJugador';
    return this.http.post<DTOLogroJugador>(url2, dtoLogroJugador, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Logro jugador agregado correctamente');
          }
        },
        Error => {
          alert("Error al agregar el logro");
        }
      );
  }


    

  public obtenerLogrosVFDTO(idPartido: number): DTOLogroVF[]
  {
          this.dtoPartidoId.idPartido = idPartido;
          const url = this.apiURL+ 'obtenerLogrosVFPendiente';
          this.http.put<DTOLogroVF[]>(url, idPartido, {
              responseType: 'json'
            })
            .subscribe(
              data => {
                for (let i = 0; i < Object.keys(data).length; i++) {
                  let logroVF: DTOLogroVF;
                  logroVF = new DTOLogroVF();

                  logroVF.IdPartido = data[i].IdPartido;
                  logroVF.LogroVF = data[i].LogroVF;

                  this.logrosVF[i] = logroVF;
                  console.log(data);

                }
                Error => {

                    alert("No hay logros de Jugador pendientes en el partido");

                }

              }
            );

          return this.logrosVF;

  }

  public AgregarLogroVF(dtoLogroVF: DTOLogroVF)
  {

    const url2 = this.apiURL+ 'agregarLogroVF';
    return this.http.post<DTOLogroJugador>(url2, dtoLogroVF, { responseType: 'json' })
      .subscribe(
        data => {
          if (data != null) {
            console.log(data);
          } else {
            alert('Logro verdadero o falso agregado correctamente');
          }
        },
        Error => {
          alert("Error al agregar el logro");
        }
      );
  }






}