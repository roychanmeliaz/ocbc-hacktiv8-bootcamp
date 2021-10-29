import { Component, OnInit } from '@angular/core';
import {Todo} from '../../models/Todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  todos:Todo[]=[];
  msg_val: string="";

  constructor() { }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'Cuci baju',
        completed: false
      },
      {
        content: 'Cuci piring',
        completed: false
      }
    ]
  }

  toggleDone (id:number) {
    this.todos.map((v,i) => {
      if (i==id) v.completed = !v.completed;
      console.log(v);
      return v;
    })
  }

  // editTodo(id:number) {
  //   this.todos[id].editing=!this.todos[id].editing;
  // }

  editTodo(id:number) {
    this.msg_val=this.todos[id].content;
    console.log(this.msg_val)
    this.deleteTodo(id);
  }

  doneEditTodo(id:number) {
    this.todos[id].editing=!this.todos[id].editing;
  }

  deleteTodo(id:number) {
    this.todos = this.todos.filter((v,i) => i !== id);
  }

  addTodo(todo:Todo) {
    this.todos.push(todo);
    this.msg_val='';
  }

}
