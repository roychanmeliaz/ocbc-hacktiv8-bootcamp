import { Component, OnInit, TemplateRef,ViewChild } from '@angular/core';
import { Payment } from 'src/app/models/payment';
import { PaymentsService } from 'src/app/payments.service';
import { FormGroup, Validators, FormControl, FormGroupDirective, NgForm } from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';

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
  currentlyEditedId:string="";
  securityFormDisabled:boolean = false;

  // form validator
  form = {
    inputData: new FormGroup({
      cardOwnerName: new FormControl('',[
        Validators.required,
      ]),
      cardNumber: new FormControl('',[
        Validators.required,
        Validators.pattern(/^\d{4}[-]\d{4}[-]\d{4}[-]\d{4}$/),
      ]),
      expirationDate: new FormControl('',[
        Validators.required,
        Validators.pattern(/^\d{2}[/]\d{2}$/),
      ]),
      securityCode: new FormControl({ value: '', disabled: this.securityFormDisabled },[
        Validators.required,
        Validators.pattern(/^\d{3}$/),
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
    private dialog: MatDialog
  ) { }
  @ViewChild('reqsuccess', { static: true }) reqsuccess!:  TemplateRef<any>;
  @ViewChild('reqerror', { static: true }) reqerror!:  TemplateRef<any>;
  @ViewChild('loadDialog', { static: true }) loadDialog!:  TemplateRef<any>;
  @ViewChild('confirmDialog', { static: true }) confirmDialog!:  TemplateRef<any>;

  ngOnInit(): void {
    this.getPayments();
    console.log(this.paymentsList)
    this.form.inputData.reset()
  }

  openDialog(templateRef:any) {
    let dialogRef = this.dialog.open(templateRef, {
    //  width: '300px'
    });
  }

  openSuccessDialog() {
    this.openDialog(this.reqsuccess);
  }

  openErrorDialog() {
    this.openDialog(this.reqerror);
  }

  openLoadDialog() {
    return this.dialog.open(this.loadDialog, {
      disableClose: true,
    });
  }

  openConfirmDialog() {
    return this.dialog.open(this.confirmDialog, {
      //  width: '300px'
    });
  }
  
  getPayments() {
    // open dialog
    let loadDialogRef = this.openLoadDialog();
    this.paymentsService.getPayments()
      .subscribe((response)=>{
        loadDialogRef.close();
        console.log('response diterima');
        this.paymentsList = response;
        console.log(this.paymentsList)
      })
  }

  onSubmit(formDirective:FormGroupDirective) {
    if (this.inputMode==1) {
      this.addPayment(formDirective)
    }
    else {
      this.editPayment(formDirective)
    }
  }
  cancelButton(formDirective:FormGroupDirective) {
    this.inputMode=1;
    formDirective.resetForm();
    this.form.inputData.reset();
    this.form.inputData.controls['securityCode'].enable()
}

  addPayment(formDirective:FormGroupDirective) {
    console.log("now adding")
    // check if validation is clear
    if (this.form.inputData.valid) { 
      // open dialog
      let loadDialogRef = this.openLoadDialog();
      // start sending data
      this.paymentsService.addPayment(this.form.inputData.value)
      .subscribe(
        (res) => {
          loadDialogRef.close();
          this.openSuccessDialog()
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
          loadDialogRef.close();
          console.log("start err")
          console.log(err)
          console.log(err.error.message)
          console.log("end err")  
          this.openErrorDialog()
          // this.openSnackBar("Error! " + err.error.message, "OK");
        }
      );
    }
    console.log(this.form.inputData.value);
  }
  
  editPayment(formDirective:FormGroupDirective) {
    console.log("now editing")
    // check if validation is clear
    if (this.form.inputData.valid) { 
      // open dialog
      let loadDialogRef = this.openLoadDialog();
      // start sending data
      // this.form.inputData.controls['securityCode'].enable()
      let editDataObject:Payment = Object.assign({}, this.form.inputData.value)
      editDataObject.paymentDetailId = this.currentlyEditedId;
      console.log(typeof(editDataObject))
      console.log(editDataObject)
      this.paymentsService.editPayment(editDataObject,this.currentlyEditedId)
      .subscribe((res) => {
        loadDialogRef.close();
        console.log(res)
        if (res==null) {
          this.inputMode=1;
          formDirective.resetForm();
          this.form.inputData.reset();
          this.form.inputData.controls['securityCode'].enable()
          this.openSuccessDialog()
          // this.openSnackBar("Edit success!", "OK");
          this.getPayments();
        }
      },
      (err) => {
        loadDialogRef.close();
        console.log(err)
        // this.openSnackBar("Error! " + err.error.message, "OK");
        this.openErrorDialog()
      });
    }
    console.log(this.form.inputData.value);
  }

  editButton(id:string) {
    // this.cancelButton();
    console.log(id)
    console.log(this.paymentsList)
    this.inputMode=2;
    // this.form.inputData.controls['securityCode'].disable()
    // setTimeout(() => 
    // {
    //   this.password?.updateValueAndValidity();
    //   this.confirmPassword?.updateValueAndValidity();
    //   console.log("wait over")
    // },
    // 1000);
    this.currentlyEditedId=id;
    let payment = this.paymentsList.find(i => i.paymentDetailId == id);
    this.form.inputData.setValue({
      cardOwnerName: payment?.cardOwnerName,
      cardNumber: payment?.cardNumber,
      expirationDate: payment?.expirationDate,
      securityCode: payment?.securityCode,
    })
  }

  deleteButton(id:string) {
    let confirmDialogRef = this.openConfirmDialog();
    confirmDialogRef.afterClosed().subscribe(res => {
      if (res==true) {
        this.deletePayment(id);
      }
    })
  }

  deletePayment(id:string) {
    let loadDialogRef = this.openLoadDialog();
    this.paymentsService.deletePayment(id)
    .subscribe(
      (res) => {
        loadDialogRef.close();
        console.log("start res")
        console.log(res)
        console.log("end res")
        if (res) {
          this.form.inputData.reset();
          this.openSuccessDialog()
          // this.openSnackBar("Delete success!", "OK");
          this.inputMode=1;
          this.getPayments();
        }
      },
      (err) => {
        loadDialogRef.close();
        console.log("start err")
        console.log(err)
        console.log(err.error.message)
        console.log("end err")
        // this.openSnackBar(err.error.message, "OK");
        this.openErrorDialog()
      }
    );
  }
}
