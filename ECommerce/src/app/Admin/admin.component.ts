import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Admin } from './admin.model';

@Component({
  templateUrl: './Admin.component.html'
})
export class AdminComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'ECommerce';
  myname = 'Tanu Srivastava'
  AdminModel: Admin = new Admin();
  AdminModels: Array<Admin> = new Array<Admin>();
  AddAdmin() {
    console.log(this.AdminModel);
    //this.AdminModel.push(this.AdminModel);

    var Admindto={
      AdminId:this.AdminModel.AdminId,
      AdminName:this.AdminModel.AdminName,
    }
    this.httpc.post("https://localhost:44365/api/admin",Admindto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.AdminModel = new Admin();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditAdmin(input: Admin) {
    this.AdminModel = input;
  }
  DeleteAdmin(input: Admin) {
    var index=this.AdminModel.indexOf(input);
    this.AdminModel.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44365/api/admin").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.AdminModel=input;
  }
  GetError(input:any){
    console.log(input);
  }
}