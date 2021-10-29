import { Component } from '@angular/core';
import { Task } from './models/tasks';
import { NgForm, NgModel } from '@angular/forms'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularForm';
  categories: string[] = [
    "Shopping",
    "Work",
    "Education",
    "Financing",
  ]

  tasks: Task[] = [];

  formIsInvalid:boolean = false;
  validFormInputs: {} = {
    taskName:true,
    category:true
  }

  validateForm(form:NgForm):boolean {
    Object.keys(this.validFormInputs).forEach(formInput => {

    })
    return false
  }
  
  handleFormOnSubmit(form:NgForm) {
    // handle submission here
    
    const {taskName,category} = form.value
    // if (!taskName || !category)
    if (!this.validateForm(form))
      this.formIsInvalid = true
    else {
      console.log({taskName,category})
    }

    // this.tasks.push(new Task(name,"incomplete",category))
    // form.reset()
  }
}
