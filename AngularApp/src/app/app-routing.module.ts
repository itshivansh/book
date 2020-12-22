import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistrationComponent } from './Components/Users/registration/registration.component';
import { UsersComponent } from './Components/users/users.component';


const routes: Routes = [
  {path:'',redirectTo:'/user/registration',pathMatch:'full'},
  {path:'user',component:UsersComponent,
  children:[
    {path:'registration',component:RegistrationComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
