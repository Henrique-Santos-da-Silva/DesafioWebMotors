import { Injectable } from '@angular/core';
import {CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Resolve} from '@angular/router';
import {Observable, of} from 'rxjs';
import {Anuncio} from '../models/Anuncio';
import {WebmotorsService} from '../webmotors.service';

@Injectable({
  providedIn: 'root'
})
export class AnuncioResolverGuard implements Resolve<Anuncio> {

  constructor(private service: WebmotorsService) {}

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Anuncio>  {
    if (route.params && route.params['id']) {
      return this.service.buscarAnuncioPorId( route.params['id'])
    }

    return of({
      id: null,
      marca: null,
      modelo: null,
      versao: null,
      ano: null,
      quilometragem: null,
      observacao: null
    });

  }


}
