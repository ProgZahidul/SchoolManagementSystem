import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FeePaymetnListComponent } from './components/FeePayment/fee-paymetn-list/fee-paymetn-list.component';
import { FeePaymetnCreateComponent } from './components/FeePayment/fee-paymetn-create/fee-paymetn-create.component';
import { FeePaymetnEditComponent } from './components/FeePayment/fee-paymetn-edit/fee-paymetn-edit.component';
import { FeePaymetnDetailsComponent } from './components/FeePayment/fee-paymetn-details/fee-paymetn-details.component';
import { FeeTypeListComponent } from './components/FeeType/fee-type-list/fee-type-list.component';
import { FeeTypeCreateComponent } from './components/FeeType/fee-type-create/fee-type-create.component';
import { FeeTypeEditComponent } from './components/FeeType/fee-type-edit/fee-type-edit.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { FeePaymentService } from './Services/fee-payment.service';

@NgModule({
  declarations: [
    AppComponent,
    FeePaymetnListComponent,
    FeePaymetnCreateComponent,
    FeePaymetnEditComponent,
    FeePaymetnDetailsComponent,
    FeeTypeListComponent,
    FeeTypeCreateComponent,
    FeeTypeEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [FeePaymentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
