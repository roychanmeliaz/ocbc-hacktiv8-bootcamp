import { Injectable } from '@angular/core';

import { Product } from './models/product';
import { PRODUCTS } from './models/mock-products';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  products = of(PRODUCTS)

  constructor() { }

  getProducts(): Observable<Product[]> {
    return this.products;
  }

  getOneProduct(id:number):Observable<Product> {
    return this.products
      .pipe(
        map(
          products => products.find(p => p.id == id)!
        )
      )
    // return this.products.pipe(map(products => products.filter(product => product.id == id)[0])) 
  }
}
