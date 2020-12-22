import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public service:UserService) {}
  

  ngOnInit(): void {

  }

  onSubmit(){
    this.service.register().subscribe(
      data=>{
        alert("Registered successfully");
      },
      err=>{
        alert("Registration failed")
      }
    );
  }
}
