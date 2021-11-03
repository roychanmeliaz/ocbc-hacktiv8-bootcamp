import { Injectable } from '@angular/core';

// needed
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError} from 'rxjs/operators';

// model
import { Payment } from './models/payment';

@Injectable({
  providedIn: 'root'
})
export class PaymentsService {

  // endpoint:string = "https://payment-api-roy.herokuapp.com/api/PaymentDetail"
  endpoint:string = "http://localhost:5000/api/PaymentDetail"

  constructor(private http:HttpClient) { }

  getPayments():Observable<any> {
    let api = `${this.endpoint}/`;
    return this.http.get(api)
    .pipe(
      map((res:any) => {
        return res || {}
      }),
      catchError(this.handleError)
    )
  }

  addPayment(payment: Payment): Observable<any> {
    const api = `${this.endpoint}/`;
    return this.http
      .post(api, payment)
      .pipe( catchError(this.handleError) )
  }

  deleteUser(id:string): Observable<any> {
    const api = `${this.endpoint}/${id}`;
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
