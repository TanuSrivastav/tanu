import { AdminComponent } from "../Admin/admin.component";
import { HomeComponent } from "../home/home.component";
//import { UserdetailComponent } from "../Userdetail/userdetail.component";
import { ProductComponent } from "../Product/product.component";

export const MainRoutes= [
    {path:'',component:HomeComponent},
    {path:'home',component:HomeComponent},
    {path:'Admin',loadChildren:()=>import('../Admin/admin.module').then(m=>m.AdminModule)},
   // {path:'Userdetail',loadChildren:()=>import('../Userdetail/userdetail.module').then(m=>m.UserdetailModule)},
    {path:'Product',loadChildren:()=>import('../Product/product.module').then(m=>m.ProductModule)}
];