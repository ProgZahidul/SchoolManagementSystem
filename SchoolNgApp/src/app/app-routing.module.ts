import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FeePaymetnListComponent } from './components/FeePayment/fee-paymetn-list/fee-paymetn-list.component';
import { FeePaymetnCreateComponent } from './components/FeePayment/fee-paymetn-create/fee-paymetn-create.component';
import { FeePaymetnDetailsComponent } from './components/FeePayment/fee-paymetn-details/fee-paymetn-details.component';

const routes: Routes = [
  { path: 'fee-payments', component: FeePaymetnListComponent },
  { path: 'fee-payments/create', component: FeePaymetnCreateComponent },
  { path: 'fee-payments/:id', component: FeePaymetnDetailsComponent },
  { path: 'fee-payments/:id/edit', component: FeePaymetnListComponent },
  { path: '', redirectTo: '/fee-payments', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }


