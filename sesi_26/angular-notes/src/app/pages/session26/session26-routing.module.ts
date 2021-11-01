import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieService } from 'src/app/services/movie.service';
import { Session26Component } from './session26.component';
import { SigninComponent } from './signin/signin.component';
import { SignupComponent } from './signup/signup.component';
import { StudioComponent } from './studio/studio.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

const routes: Routes = [
  {
    path: 'session26',
    component: Session26Component,
    children: [
      {path: 'signin', component: SigninComponent},
      // localhost:4200/session26/signin
      {path: 'signup', component: SignupComponent},
      {path: 'studios', component: StudioComponent},
      // {path: 'movies', component: MovieService}
    ]}
];

// router untuk feature module dapat kalian buat dengan argument...
//     --routing

// ...ketika kalian membuat module baru dengan
//     ng g module <NAMA_MODULE>

// contoh: ng g[enerate] module <NAMA_MODULE> --routing

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class Session26RoutingModule { }
