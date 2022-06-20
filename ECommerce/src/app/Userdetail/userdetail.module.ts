import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { UserdetailRoutes } from '../routing/routing.userdetail';
import { UserdetailComponent } from './userdetail.component';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    UserdetailComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forChild(UserdetailRoutes)
  ],
  providers: [],
  bootstrap: [UserdetailComponent]
})
export class UserdetailModule { }