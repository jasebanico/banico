import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientXsrfModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule }  from '@angular/forms';
import { UserFormComponent } from '../components/userform/userform.component';
import { UsersListComponent } from '../components/userslist/userslist.component';
import { UsersService } from './users.service';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientXsrfModule.withOptions({
      cookieName: 'XSRF-TOKEN',
      headerName: 'X-XSRF-Token'
    })  
  ],
  declarations: [
    UserFormComponent,
    UsersListComponent
  ],
  providers: [ 
    UsersService
  ],
    bootstrap: [ 
  ]
})
export class UsersModule { }
