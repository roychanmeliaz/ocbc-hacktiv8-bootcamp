import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Session26Component } from './session26.component';
import { Session26RoutingModule } from './session26-routing.module';

import { HttpClientModule } from '@angular/common/http'

import { ClickablesModule } from 'src/app/components/clickables/clickables.module';
import { SignupComponent } from './signup/signup.component';
import { SigninComponent } from './signin/signin.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { ReactiveFormsModule } from '@angular/forms';
import { StudioComponent } from './studio/studio.component';

@NgModule({
  declarations: [
    Session26Component,
    SignupComponent,
    SigninComponent,
    UserProfileComponent,
    StudioComponent,
  ],
  imports: [
    CommonModule,
    Session26RoutingModule,
    ClickablesModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
})
export class Session26Module { }
