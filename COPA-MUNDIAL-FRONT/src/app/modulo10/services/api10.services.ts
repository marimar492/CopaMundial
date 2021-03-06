import { Injectable } from '@angular/core';
import { Usuario10, IUsuario10, Conexion } from '../models/usuario.model';
import { RouterModule, Router } from '@angular/router';
import {
  HttpClient,
  HttpParams,
  HttpHeaders,
  HttpErrorResponse
} from '@angular/common/http';
import { Usuario } from '../../modulo01/models/usuario';

import { Location } from '@angular/common';

declare var bootbox, router: any;

@Injectable()
export class ApiService {
  private _usuario10: Usuario10;
  private _conexion: Conexion;
  constructor(private http: HttpClient) {
    this._usuario10 = new Usuario10();
    this._conexion = new Conexion();
    this._usuario10.Id = 2;
    // const httpHeaders = new HttpHeaders().set('Accept', 'application/json');
  }

  public ObtenerDatos(): Usuario10 {
    this._conexion.Controlador = 'ObtenerUsuario/';

    let url =
      this._conexion.RutaApi + this._conexion.Controlador + this._usuario10.Id;

    this.http.get<IUsuario10>(url, { responseType: 'json' }).subscribe(data => {
      this._usuario10.Nombre = data.Nombre;
      this._usuario10.Apellido = data.Apellido;
      this._usuario10.Correo = data.Correo;
      this._usuario10.FechaNacimiento = data.FechaNacimiento;
      this._usuario10.Activo = data.Activo;
      this._usuario10.Genero = data.Genero;
      this._usuario10.EsAdmin = data.EsAdmin;
      // this._usuario10.Message = data.Message;
    }, Error => {this.FatalError();});

    return this._usuario10;
  }

  public EditarPerfil(usuario: Usuario10): string {
    this._conexion.Controlador = 'ActualizarPerfil';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .put<IUsuario10>(url, usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          usuario.Message = data.Message;
          this.Error(usuario)
        } else {
          this.Succes('Usuario Editado Corectamente.');
        }
      }, Error => {this.FatalError();});

    return null;
  }

  public ActualizarCorreo(usuario: Usuario10, correoNuevo) {
    this._usuario10 = usuario;
    this._conexion.Controlador = 'ActualizarCorreoUsuario';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http.put<IUsuario10>(url, usuario, { responseType: 'json' }).subscribe(
      data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Correo editado con éxito');
        }
      },
      Error => {this.FatalError();}
    );
  }

  public ActualizarClave(usuario: Usuario10, claveNueva: string) {
    this._usuario10 = usuario;
    this._conexion.Controlador = 'ActualizarClaveUsuario/' + claveNueva;
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .put<IUsuario10>(url, usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Clave editada con éxito');
        }
      }, Error => {this.FatalError();});
  }

  public DesactivarCuentaPropia(usuario: Usuario10) {
    this._usuario10 = usuario;
    this._conexion.Controlador = 'DesactivarUsuarioPropio';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .put<IUsuario10>(url, usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Cuenta desactivada con éxito');
        }
      }, Error => {this.FatalError();});
  }

  public AdministradorActivarCuenta(idUsuario : number) {
    let _Usuario : Usuario10;
    _Usuario = new Usuario10();
    _Usuario.Id = idUsuario;

    this._conexion.Controlador = 'ActivarUsuario';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .put<IUsuario10>(url, _Usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Cuenta activada con éxito');
        }
      }, Error => {this.FatalError();});
  }

  public AdministradorDesactivaCuenta(idUsuario: number) {
    let _Usuario: Usuario10;
    _Usuario = new Usuario10();
    _Usuario.Id = idUsuario;

    this._conexion.Controlador = 'AdministradorDesactivaUsuario';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .put<IUsuario10>(url, _Usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Cuenta desactivada con éxito');
        }
      }, Error => {this.FatalError();});
  }

  public CrearUsuarioAdministrador(Usuario : Usuario10) {

    this._conexion.Controlador = 'CrearUsuarioAdministrador';
    let url = this._conexion.RutaApi + this._conexion.Controlador;

    this.http
      .post<IUsuario10>(url, Usuario, { responseType: 'json' })
      .subscribe(data => {
        if (data != null) {
          this._usuario10.Message = data.Message;
          this.Error(this._usuario10);
        } else {
          this.Succes('Administrador creado con éxito');
        }
      }, Error => {this.FatalError();});

  }

  private Error(usuario: Usuario10) {
    bootbox.alert(this._usuario10.Message);
  }

  private Succes(mensaje: string) {    
    bootbox.alert(mensaje, function(){ location.reload(); });

  }

  private FatalError() {
    bootbox.alert('Problema al establecer la conexión con el servidor');
  }
}
