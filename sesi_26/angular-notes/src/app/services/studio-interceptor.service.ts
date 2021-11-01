import { HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { StudioService } from './studio.service';

@Injectable({
  providedIn: 'root'
})
export class StudioInterceptorService implements HttpInterceptor{

  constructor( private studioService:StudioService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler) {
    const authToken = this.studioService.token;
    req = req.clone({
      setHeaders: {
        Authorization: "Bearer "+authToken
      }
    })
    return next.handle(req)
  }
}
