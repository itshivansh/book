import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './Components/Users/login/login.component';
import { RegistrationComponent } from './Components/Users/registration/registration.component';
import { UsersComponent } from './Components/users/users.component';


const routes: Routes = [
  {path:'',redirectTo:'/users/registration',pathMatch:'full'},
  {path:'users',component:UsersComponent,
  children:[
    {path:'registration',component:RegistrationComponent},
    {path:'login',component:LoginComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
