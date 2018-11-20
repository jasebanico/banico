import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InviteComponent } from './invite.component';
import { InviteFormComponent } from '../components/invite-form/invite-form.component';
import { AuthGuard } from '../../../shared/auth/auth.guard';

const INVITE_ROUTES: Routes = [
  { path: 'invite', component: InviteComponent, children: [
    { path: '', component: InviteFormComponent, canActivate: [AuthGuard], data: { module: 'invite' } }
  ] }
];

@NgModule({
    imports: [
        RouterModule.forChild(INVITE_ROUTES)
    ],
    exports: [
        RouterModule
    ]
})
export class InviteRoutingModule {}