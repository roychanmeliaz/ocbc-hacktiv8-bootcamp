import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {Todo} from '../../models/Todo'
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent implements OnInit {

  @Output() newTodoEvent = new EventEmitter<Todo>();
  inputTodo:string="";

  // constructor() { }
  constructor(private mysnackbar: MatSnackBar) {}
    showSnackbar(msg: string, action: string) {
    this.mysnackbar.open(msg, action, {
      verticalPosition: 'top'
    });
  }

  todoForm = new FormGroup ({
    todo: new FormControl('',[
      Validators.required,
      Validators.minLength(5),
      Validators.pattern('^[a-zA-Z ]*$')
    ])
  })

  ngOnInit(): void {
  }

  // addTodo() {
  //   const todo:Todo = {
  //     content: this.inputTodo,
  //     completed: false
  //   };
  //   this.newTodoEvent.emit(todo);
  //   this.inputTodo="";
  // }

  get todo() {
    return this.todoForm.get('todo');
  }

  addTodoReactive() {
    console.log("run reactive")
    console.log(this.todoForm)
    if (this.todo?.invalid) {
      if (this.todo?.errors?.required) {
        this.showSnackbar(`Input required`,"OK")
      }
      if (this.todo?.errors?.pattern) {
        this.showSnackbar(`Pattern invalid. Use alphabet and spaces only`,"OK")
      }
      if (this.todo?.errors?.minlength) {
        this.showSnackbar(`Length invalid. Min ${this.todo?.errors?.minlength?.requiredLength} character(s)`,"OK")
      }
    } 
    else {
      this.showSnackbar(`Add ${this.todoForm.get('todo')?.value} berhasil`,"OK")
      const todo:Todo = {
        content: String(this.todoForm.get('todo')?.value),
        completed: false
      };
      this.newTodoEvent.emit(todo);
      this.todoForm.reset()  
    }
  }

}
