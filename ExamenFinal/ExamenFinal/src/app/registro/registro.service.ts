import { Injectable } from '@angular/core'
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Iregistro } from './registro';

import { Observable, throwError } from "rxjs";
import { catchError, tap } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})

export class RegistroService {
  private registroUrl = 'https://localhost:7157/api/persona/registro';
  
  //idUsuario = localStorage.getItem('idUsuario')

  constructor(private http: HttpClient) { }

  //Realiza el POST de registro
  postRealizarAlta(alta: Iregistro): Observable<any> {
    console.log(alta);
    return this.http.post(this.registroUrl, alta);
    
  }

  
  private handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }
}