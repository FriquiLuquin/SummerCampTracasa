import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, tap, throwError } from "rxjs";

import { IHistorial } from "./historial";

@Injectable({
  providedIn: 'root'
})

export class HistorialService {
  private idUsuario = "1d03a0ad-823b-4c28-a2f7-9ee42e2f2fde";
  private historialUrl = 'https://localhost:7055/api/Usuarios/' + this.idUsuario + '/Historial';
  private token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZmVybWluIiwianRpIjoiN2VkYmIxNGUtNmMxMy00MTFiLTliOWQtMjNlMzdhNmIzYjg4IiwiZXhwIjoxNjkzOTkzNDU0LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQyMDAifQ.CVurPqdZhaYJVVJSju9quVqUgN_yMzWjtwg566X6B3g"

  constructor(private http: HttpClient) { }

  getHistorial(): Observable<IHistorial[]> {
    let headers = new HttpHeaders().set('Authorization', `Bearer ${this.token}`);
    return this.http.get<IHistorial[]>(this.historialUrl, { headers }).pipe(
      tap(data => console.log('All', JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {
    // in a real world app, we may send the server to some remote logging infrastructure
    // instead of just logging it to the console
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }
}