import { Component, OnInit } from '@angular/core';
import { FeePaymentService } from '../../../Services/fee-payment.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fee-paymetn-list',
  templateUrl: './fee-paymetn-list.component.html',
  styleUrl: './fee-paymetn-list.component.css'
})
export class FeePaymetnListComponent implements OnInit {
  feePayments: any[] = [];
  searchStudentId: number | undefined;

  constructor(
    private feePaymentService: FeePaymentService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getFeePayments();
  }

  getFeePayments(): void {
    this.feePaymentService.getFeePayments()
      .subscribe(data => {
        this.feePayments = data;
      });
  }

  goToFeePaymentDetails(id: number): void {
    this.router.navigate(['/fee-payments', id]);
  }

  deleteFeePayment(feePaymentId: number) {
    this.feePaymentService.deleteFeePayment(feePaymentId).subscribe(
      () => {
        console.log('Fee payment deleted successfully.');
        // Optionally, you can reload the fee payments after deletion
        this.getFeePayments();

      },
      (error) => {
        console.error('Error deleting fee payment:', error);
      }
    );
  }
  printDetails(): void {
    window.print();
  }
}

