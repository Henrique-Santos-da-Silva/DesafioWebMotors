import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Marca} from './models/Marca';
import {catchError, retry, take} from 'rxjs/operators';
import {Modelo} from './models/Modelo';
import {throwError} from 'rxjs';
import {Versao} from './models/Versao';
import {Anuncio} from './models/Anuncio';

@Injectable({
  providedIn: 'root'
})
export class WebmotorsService {
  private readonly BASE_URL = 'http://desafioonline.webmotors.com.br';
  private readonly API_LOCAL_URL = 'http://localhost:58909';

  constructor(private http: HttpClient) {
  }

  buscarMarcas() {
    return this.http.get<Marca[]>(this.BASE_URL + '/api/OnlineChallenge/Make')
      .pipe(take(1), catchError(this.handleError));
  }

  buscarModeloPorMarca(id: number) {
    return this.http.get<Modelo[]>(this.BASE_URL + '/api/OnlineChallenge/Model?MakeID=' + id)
      .pipe(take(1), catchError(this.handleError));
  }

  buscarVersao(id: number) {
    return this.http.get<Versao[]>(this.BASE_URL + '/api/OnlineChallenge/Version?ModelID=' + id)
      .pipe(take(1), catchError(this.handleError));
  }

  // TODO(Anuncios)
  buscarTodosAnuncios() {
    return this.http.get<Anuncio[]>(this.API_LOCAL_URL + '/api/Anuncio')
      .pipe(take(1), catchError(this.handleError));
  }

  buscarAnuncioPorId(id) {
    return this.http.get<Anuncio>(this.API_LOCAL_URL + '/api/Anuncio/' + id)
      .pipe(take(1), catchError(this.handleError));
  }

  criarAnuncio(anuncio) {
    return this.http.post<Anuncio>(this.API_LOCAL_URL + '/api/Anuncio/', anuncio)
      .pipe(take(1), catchError(this.handleError));
  }

  atualizarAnuncio(anuncio) {
    return this.http.put(this.API_LOCAL_URL + '/api/Anuncio/' + anuncio.id, anuncio)
      .pipe(take(1), catchError(this.handleError));
  }

  removerAnuncio(id) {
    return this.http.delete(this.API_LOCAL_URL + '/api/Anuncio/' + id).pipe(take(1), catchError(this.handleError));
  }


  handleError(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Erro ocorreu no lado do client
      errorMessage = error.error.message;
    } else {
      // Erro ocorreu no lado do servidor
      errorMessage = `Código do erro: ${error.status}, ` + `menssagem: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }

}
