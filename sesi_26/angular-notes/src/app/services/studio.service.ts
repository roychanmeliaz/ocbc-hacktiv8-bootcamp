import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StudioService {
  endpoint: string = "http://localhost:3000/studios";

  constructor(
    private http: HttpClient
  ) { }

  get token() {
    return localStorage.getItem('access_token')
  }

  getStudios () {
    const api = `${this.endpoint}`;
    return this.http.get(api)
    .pipe(catchError(this.handleError));
  }

  handleError(err: HttpErrorResponse){
    if (err.error instanceof ErrorEvent)
      return throwError(err.error.message)
    else
      return throwError(`Server-side error code: ${err.status}\nMessage:" ${err.message}`)
  }  
}
