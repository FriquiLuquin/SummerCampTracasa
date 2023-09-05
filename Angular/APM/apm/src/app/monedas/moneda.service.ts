import { HttpClient, HttpHeaders, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, tap, throwError } from "rxjs";

import { IMoneda } from "./moneda";

@Injectable({
  providedIn: 'root'
})

export class MonedaService {
  private monedaUrl = 'https://localhost:7055/api/Monedas';
  private token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZmVybWluIiwianRpIjoiZjU2MGFhNGQtZTNiNC00YTM0LTk1MDUtMWM4NDFiNWY3NTViIiwiZXhwIjoxNjkzOTIxNTk5LCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjUwMDAiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjQyMDAifQ.NWMoIH8Lg2AAEtTLK-4NR6Ygru79fqnAvmCLI82CXFI"

  constructor(private http: HttpClient) { }

  getMonedas(): Observable<IMoneda[]> {
    let headers = new HttpHeaders().set('Authorization', `Bearer ${this.token}`);
    return this.http.get<IMoneda[]>(this.monedaUrl, { headers }).pipe(
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