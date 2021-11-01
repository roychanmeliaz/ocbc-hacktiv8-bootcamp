import { Injectable } from '@angular/core';

import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError} from 'rxjs/operators';

import { Users } from './models/users';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  endpoint:string = "http://localhost:4000"
  constructor(
    private http:HttpClient
  ) { }

  getUsers():Observable<any> {
    let api = `${this.endpoint}/users`;
    return this.http.get(api)
    .pipe(
      map((res:any) => {
        return res || {}
      }),
      catchError(this.handleError)
    )
  }

  addUser(user: Users): Observable<any> {
    const api = `${this.endpoint}/users`;
    return this.http
      .post(api, user)
      .pipe( catchError(this.handleError) )
  }

  editUser(user: Users, id:string): Observable<any> {
    const api = `${this.endpoint}/users/${id}`;
    return this.http
      .put(api, user)
      .pipe( catchError(this.handleError) )
  }

  deleteUser(id:string): Observable<any> {
    const api = `${this.endpoint}/users/${id}`;
    return this.http
      .delete(api)
      .pipe( catchError(this.handleError) )
  }

  handleError(error: HttpErrorResponse) {
    let msg='';
    if (error.error instanceof ErrorEvent) {
      msg = error.error.message;
    } else {
      msg = `Error code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(error);
  }
}
