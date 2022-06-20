import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from './product.model';

@Component({
  templateUrl: './Product.component.html'
})
export class ProductComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'ECommerce';
  myname = 'Tanu Srivastava'
  ProductModel: Product = new Product();
  CustmerModels: Array<Product> = new Array<Product>();
  AddProduct() {
    console.log(this.ProductModel);
    //this.CustmerModels.push(this.ProductModel);

    var Productdto={
      ProductId:this.ProductModel.ProductId,
      ProductName:this.ProductModel.ProductName,
      Category:Number(this.ProductModel.Category),
    }
    this.httpc.post("https://localhost:44365/api/product",Productdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.ProductModel = new Product();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditProduct(input: Product) {
    this.ProductModel = input;
  }
  DeleteProduct(input: Product) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44365/api/product").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.CustmerModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}