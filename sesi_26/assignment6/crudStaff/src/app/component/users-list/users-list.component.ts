import { Component, OnInit } from '@angular/core';
import { UsersService } from 'src/app/users.service';
import { Users } from 'src/app/models/users';
import { FormGroup, Validators, FormControl, AbstractControl } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.css']
})
export class UsersListComponent implements OnInit {
  displayedColumns: string[] = ['id', 'title', 'firstName', 'lastName', 'email', 'role', 'actions'];
  inputMode:number=0;
  currentlyEditedId:string=""
  form = {
    inputData: new FormGroup({
      title: new FormControl('',[
        Validators.required,
      ]),
      firstName: new FormControl('',[
        Validators.required,
      ]),
      lastName: new FormControl('',[
        Validators.required,
      ]),
      email: new FormControl('',[
        Validators.required,
        Validators.email
      ]),
      role: new FormControl('',[
        Validators.required,
      ]),
      password: new FormControl('',[
        this.triggerRequiredConditionally,
        // Validators.required,
        Validators.minLength(6)
      ]),
      confirmPassword: new FormControl('',[
        this.triggerRequiredConditionally,
        // Validators.required,
      ]),
    })
  }

  triggerRequiredConditionally(formControl: AbstractControl) {
    console.log(formControl.parent?.value?.title)
    if (formControl.parent?.value?.password!=null) {
      return null
    } else {      
      return Validators.required(formControl)
    }
  }

  usersList:Users[] = [
    {id:"0", title:"title", firstName:"firstName", lastName:"lastName", email:"email", role:"role", password:"pass", confirmPassword:"confpass"}
  ];

  constructor(
    private usersService:UsersService,
    public snackBar: MatSnackBar
  ) {
    this.inputMode=0;
  }

  get title() {
    return this.form.inputData.get('title');
  }
  get firstName() {
    return this.form.inputData.get('firstName');
  }
  get lastName() {
    return this.form.inputData.get('lastName');
  }
  get email() {
    return this.form.inputData.get('email');
  }
  get role() {
    return this.form.inputData.get('role');
  }
  get password() {
    return this.form.inputData.get('password');
  }
  get confirmPassword() {
    return this.form.inputData.get('confirmPassword');
  }

  ngOnInit(): void {
    this.getUsers();
    this.inputMode=0;
    this.form.inputData.reset()
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
       duration: 10000,
       verticalPosition: "top",
       panelClass: ['success-snackbar']
    });
  } 

  getUsers() {
    this.usersService.getUsers()
      .subscribe((response)=>{
        console.log('response diterima');
        this.usersList = response;
        console.log(this.usersList)
      })
  }

  mockUsers() {
    this.usersList = [
      {id:"0", title:"Newtitle", firstName:"firstName", lastName:"lastName", email:"email", role:"role", password:"pass", confirmPassword:"confpass"}
    ];  
  }

  addButton() {
    this.inputMode=1;
    // setTimeout(() => 
    // {
    //   this.password?.updateValueAndValidity();
    //   this.confirmPassword?.updateValueAndValidity();
    //   console.log("wait over")
    // },
    // 1000);
  }

  cancelButton() {
    this.inputMode=0;
    this.form.inputData.reset();
  }

  editButton(id:string) {
    this.inputMode=2;
    // setTimeout(() => 
    // {
    //   this.password?.updateValueAndValidity();
    //   this.confirmPassword?.updateValueAndValidity();
    //   console.log("wait over")
    // },
    // 1000);
    this.currentlyEditedId=id;
    let user = this.usersList.find(i => i.id == id);
    this.form.inputData.setValue({
      title: user?.title,
      firstName: user?.firstName,
      lastName: user?.lastName,
      email: user?.email,
      role: user?.role=="Admin"? "0":"1",
      password: "",
      confirmPassword: "",
    })
  }

  deleteButton(id:string) {
    this.inputMode=0;
    // this.currentlyEditedId=id;
    // start sending data
    this.usersService.deleteUser(id)
    .subscribe(
      (res) => {
        console.log("start res")
        console.log(res)
        console.log("end res")
        if (res) {
          this.form.inputData.reset();
          this.openSnackBar("Delete success!", "OK");
          this.inputMode=0;
          this.getUsers();
        }
      },
      (err) => {
        console.log("start err")
        console.log(err)
        console.log(err.error.message)
        console.log("end err")
        // this.openSnackBar(err.error.message, "OK");
      }
    );
  }
  
  doValidation():boolean {
    // validating ...
    if (this.form.inputData.invalid) {
      let errmsg:string="";
      if (this.title?.errors?.required) {
        errmsg+="\n- Title required."
      }
      if (this.firstName?.errors?.required) {
        errmsg+="\n- First Name required."
      }
      if (this.lastName?.errors?.required) {
        errmsg+="\n- Last Name required."
      }
      if (this.email?.errors?.required) {
        errmsg+="\n- Email required."
      }
      if (this.role?.errors?.required) {
        errmsg+="\n- Role required."
      }
      if (this.password?.errors?.required) {
        errmsg+="\n- Password required."
      }
      if (this.password?.errors?.minlength) {
        errmsg+="\n- Password minimum 6 characters."
      }
      if (this.confirmPassword?.errors?.required) {
        errmsg+="\n- Confirm Password required."
      }
      this.openSnackBar("Please insert form in the correct format:\n" + errmsg, "OK");
    }
    return (this.form.inputData.valid)
  }

  onSubmit() {
    if (this.inputMode==1) {
      this.addUser()
    }
    else {
      this.editUser()
    }
  }
  
  addUser() {
    console.log("now adding")
    // check if validation is clear
    if (this.doValidation()) { 
      // start sending data
      this.usersService.addUser(this.form.inputData.value)
      .subscribe(
        (res) => {
          console.log("start res")
          console.log(res)
          console.log("end res")  
          if (res) {
            this.form.inputData.reset();
            this.openSnackBar("Add success!", "OK");
            this.inputMode=0;
            this.getUsers();
          }
        },
        (err) => {
          console.log("start err")
          console.log(err)
          console.log(err.error.message)
          console.log("end err")  
          this.openSnackBar(err.error.message, "OK");
        }
      );
    }
    console.log(this.form.inputData.value);
  }

  editUser() {
    console.log("now editing")
    // check if validation is clear
    if (this.doValidation()) { 
      // start sending data
      this.usersService.editUser(this.form.inputData.value,this.currentlyEditedId)
      .subscribe((res) => {
        console.log(res)
        if (res) {
          this.form.inputData.reset();
          this.openSnackBar("Edit success!", "OK");
          this.inputMode=0;
          this.getUsers();
        }
      },
      (err) => {
        console.log(err)
        this.openSnackBar(err, "OK");
      });
    }
    console.log(this.form.inputData.value);
  }

}
