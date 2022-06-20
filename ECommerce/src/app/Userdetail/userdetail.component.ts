import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Userdetail } from './userdetail.model';

@Component({
  templateUrl: './userdetail.component.html'
})
export class UserdetailComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'ECommerce';
  myname = 'Tanu Srivastava'
  UserdetailModel: Userdetail = new Userdetail();
  CustmerModels: Array<Userdetail> = new Array<Userdetail>();
  AddUserdetail() {
    console.log(this.UserdetailModel);
  this.CustmerModels.push(this.UserdetailModel);

    var Userdetaildto={
      //Id:this.UserdetailModel.Id,
      UserId:this.UserdetailModel.UserId,
      UserName:(this.UserdetailModel.UserName),
    }
    this.httpc.post("https://localhost:44381/api/Userdetail",Userdetaildto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.UserdetailModel = new Userdetail();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditUserdetail(input: Userdetail) {
    this.UserdetailModel = input;
  }
  DeleteUserdetail(input: Userdetail) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44381/api/Userdetail").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.CustmerModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}