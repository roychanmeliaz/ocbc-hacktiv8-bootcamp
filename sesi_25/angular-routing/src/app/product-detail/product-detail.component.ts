import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../models/product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {
  ProductId:number;
  product:Product = {} as Product;
  productService: ProductService;

  constructor(activatedRoute: ActivatedRoute, productService:ProductService) { 
    this.ProductId = activatedRoute.snapshot.params.productID
    this.productService = productService;

  }

  ngOnInit(): void {
    this.getOneProduct(this.ProductId)
  }

  getOneProduct(id:number) {
    this.productService.getOneProduct(id).subscribe(p => this.product = p)
  }

}
