import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { FeePaymentService } from '../../../Services/fee-payment.service';

@Component({
  selector: 'app-fee-paymetn-details',
  templateUrl: './fee-paymetn-details.component.html',
  styleUrl: './fee-paymetn-details.component.css'
})
export class FeePaymetnDetailsComponent implements OnInit {
  feePaymentId!: number;
  feePayment: any;

  constructor(
    private route: ActivatedRoute,
    private feePaymentService: FeePaymentService
  ) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.feePaymentId = +params['id'];
      this.getFeePaymentDetails();
    });
  }

  getFeePaymentDetails() {
    this.feePaymentService.getFeePaymentById(this.feePaymentId).subscribe(
      (data) => {
        this.feePayment = data;
        console.log(this.feePayment);
      },
      (error) => {
        console.error(error);
      }
    );
  }

  printDetails(): void {
    window.print();
  }
}
