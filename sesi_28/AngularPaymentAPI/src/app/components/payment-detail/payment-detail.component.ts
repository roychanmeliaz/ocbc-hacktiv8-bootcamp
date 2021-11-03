import { Component, OnInit } from '@angular/core';
import { Payment } from 'src/app/models/payment';
import { PaymentsService } from 'src/app/payments.service';
import { FormGroup, Validators, FormControl, FormGroupDirective, NgForm } from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}


@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styleUrls: ['./payment-detail.component.css']
})

export class PaymentDetailComponent implements OnInit {

  // mat table
  displayedColumns: string[] = ['paymentDetailId', 'cardOwnerName', 'cardNumber', 'expirationDate', 'actions'];
  // displayedColumns: string[] = ['paymentDetailId', 'cardOwnerName', 'cardNumber', 'expirationDate', 'securityCode', 'actions'];

  inputMode:number=1;
  currentlyEditedId:string=""

  // form validator
  form = {
    inputData: new FormGroup({
      cardOwnerName: new FormControl('',[
        Validators.required,
      ]),
      cardNumber: new FormControl('',[
        Validators.required,
      ]),
      expirationDate: new FormControl('',[
        Validators.required,
      ]),
      securityCode: new FormControl('',[
        Validators.required,
      ]),
    })
  }

  matcher = new MyErrorStateMatcher();


  // form getter
  get cardOwnerName() {
    return this.form.inputData.get('cardOwnerName');
  }
  get cardNumber() {
    return this.form.inputData.get('cardNumber');
  }
  get expirationDate() {
    return this.form.inputData.get('expirationDate');
  }
  get securityCode() {
    return this.form.inputData.get('securityCode');
  }

  paymentsList:Payment[] = [
    // {
    //   paymentDetailId: "0",
    //   cardOwnerName: "Roychan Meliaz",
    //   cardNumber: "1234567890123456",
    //   expirationDate: "05/26",
    //   securityCode: "333"
    // }
  ];

  constructor(
    private paymentsService: PaymentsService,
  ) { }

  ngOnInit(): void {
    this.getPayments();
    console.log(this.paymentsList)
    this.form.inputData.reset()
  }

  getPayments() {
    this.paymentsService.getPayments()
      .subscribe((response)=>{
        console.log('response diterima');
        this.paymentsList = response;
        console.log(this.paymentsList)
      })
  }

  onSubmit(formDirective:FormGroupDirective) {
    if (this.inputMode==1) {
      this.addUser(formDirective)
    }
    else {
      this.editUser(formDirective)
    }
  }

  addUser(formDirective:FormGroupDirective) {
    console.log("now adding")
    // check if validation is clear
    if (this.form.inputData.valid) { 
      // start sending data
      this.paymentsService.addPayment(this.form.inputData.value)
      .subscribe(
        (res) => {
          console.log("add success response:")
          console.log(res)
          if (res) {
            formDirective.resetForm();
            this.form.inputData.reset();
            // this.openSnackBar("Add success!", "OK");
            // this.inputMode=0;
            this.getPayments();
          }
        },
        (err) => {
          console.log("start err")
          console.log(err)
          console.log(err.error.message)
          console.log("end err")  
          // this.openSnackBar("Error! " + err.error.message, "OK");
        }
      );
    }
    console.log(this.form.inputData.value);
  }
  
  editUser(formDirective:FormGroupDirective) {
    console.log("editing")
  }

  editButton(id:string) {
    // this.form.inputData.reset();

    // this.form.inputData.markAsPristine();
    // this.form.inputData.markAsUntouched();
    // this.form.inputData.updateValueAndValidity();

    this.form.inputData.reset('')
    console.log("reset")
  }

  deleteButton(id:string) {
    this.paymentsService.deleteUser(id)
    .subscribe(
      (res) => {
        console.log("start res")
        console.log(res)
        console.log("end res")
        if (res) {
          this.form.inputData.reset();
          // this.openSnackBar("Delete success!", "OK");
          // this.inputMode=0;
          this.getPayments();
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
}
