import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { Route } from '@angular/router';
import { ActivatedRouteSnapshot } from '@angular/router';
import { RouterStateSnapshot } from '@angular/router';

@Injectable()
export class LoggedInGuard implements CanActivate {

constructor(private router: Router) {}

  canActivate(route: ActivatedRouteSnapshot,
              state: RouterStateSnapshot): boolean | Observable<boolean> | Promise<boolean> {
    //if (noTieneSesionIniciada) {
      //this.router.navigate(['login']);
      //return false;
    //}
    console.log('prueba logged-ijn guard');
    if(localStorage.getItem('userId') != null){
      return true;
    }

    console.log('no entro en el if');

    this.router.navigate(['/inicio', 'login']);
    return false;
  }
}
