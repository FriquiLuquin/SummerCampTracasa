import { Injectable } from '@angular/core'
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { IPersona} from './Persona';

import { Observable, throwError } from "rxjs";
import { catchError, tap } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})

export class PersonaService {
  private personaUrl = 'https://localhost:7157/api/persona';
  
  //idUsuario = localStorage.getItem('idUsuario')

  constructor(private http: HttpClient) { }

  getPersona(): Observable<IPersona[]> {
    return this.http.get<IPersona[]>(this.personaUrl).pipe(
      catchError(this.handleError)
    );
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