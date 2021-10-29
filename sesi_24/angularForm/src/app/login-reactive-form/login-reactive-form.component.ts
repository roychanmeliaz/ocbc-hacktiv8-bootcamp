import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-login-reactive-form',
  templateUrl: './login-reactive-form.component.html',
  styleUrls: ['./login-reactive-form.component.css']
})
export class LoginReactiveFormComponent implements OnInit {

  constructor() { }

  loginData = new FormGroup({
    username: new FormControl('', [
      Validators.required,
      Validators.minLength(5)
    ]),
    password: new FormControl('')
  })

  isSubmitted = false



  handleIsSubmittedState() {
    if (this.isSubmitted===true)
      this.isSubmitted=false;
  }

  get username() {
    return this.loginData.get('username')
  }

  get password() {
    return this.loginData.get('password')
  }

  validateForm () {
    if (this.username?.errors) {
      console.log(this.username.errors  )
    }
  }

  handleLoginForm() {
    this.isSubmitted = true;
    // this.validateForm()
    // console.log(this.loginData.get('username'))
    // console.log(this.loginData.get('password'))
  }

  ngOnInit(): void {
  }

}
