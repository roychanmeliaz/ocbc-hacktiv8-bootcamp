import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {Todo} from '../../models/Todo'
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css']
})
export class AddTodoFormComponent implements OnInit {

  @Output() newTodoEvent = new EventEmitter<Todo>();
  inputTodo:string="";

  constructor() { }

  todoForm = new FormGroup ({
    todo: new FormControl('',[
      Validators.required,
      Validators.minLength(3),
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
    const todo:Todo = {
      content: String(this.todoForm.get('todo')?.value),
      completed: false
    };
    this.newTodoEvent.emit(todo);
    this.todoForm.reset()
  }

}
