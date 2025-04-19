import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserListingComponent } from './components/user-listing/user-listing.component';

const routes: Routes = [

  { path: '', redirectTo: 'user-listing', pathMatch: 'full' },
  { path: 'user-listing', component: UserListingComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
