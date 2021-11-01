import { Injectable } from '@angular/core';

import { User } from '../models/User';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  endpoint: string = "http://localhost:3000";
  headers = new HttpHeaders().set('Content-Type','application/json');

  constructor(private http:HttpClient) { }

  signUp(user: User): Observable<any> {
    const api = `${this.endpoint}/register`;
    return this.http
      .post(api, user)
      .pipe( catchError(this.handleError) )
  }

  signIn(user:User) {
    const api = `${this.endpoint}/login`;
    return this.http
      .post(api, user)
      .subscribe((res:any) => {
        localStorage.setItem('access_token',res.token)
      })
      // .pipe( catchError(this.handleError) )
  }

  handleError(err: HttpErrorResponse){
    if (err.error instanceof ErrorEvent)
      return throwError(err.error.message)
    else
      return throwError(`Server-side error code: ${err.status}\nMessage:" ${err.message}`)
  }
}
