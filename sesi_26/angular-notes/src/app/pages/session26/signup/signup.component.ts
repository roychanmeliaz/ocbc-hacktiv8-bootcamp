import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {

  constructor(
    public authService:AuthService,
    public router:Router) {

    }

  form = {
    inputData: new FormGroup({
      name: new FormControl('',[
        Validators.required,
        Validators.minLength(5)
      ]),
      password: new FormControl('',[
        Validators.required,
        Validators.minLength(5)
      ]),
      email: new FormControl('',[
        Validators.required,
        Validators.email
      ]),
    })
  }

  get name() {
    return this.form.inputData.get('name')
  }

  get email() {
    return this.form.inputData.get('email')
  }

  get password() {
    return this.form.inputData.get('password')
  }

  ngOnInit(): void {
  }

  register() {
    this.authService
    .signUp(this.form.inputData.value) // akan mengembalikan Observables<User>
    .subscribe((res) => {
      console.log(res)
      if (res) {
        this.form.inputData.reset()
        this.router.navigate(['session26','signin'])
      }
    })
  }

}
