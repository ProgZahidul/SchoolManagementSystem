import { Component, OnInit } from '@angular/core';
import { FeeStructure } from '../../../Models/FeePaymentService/FeeStructure';
import { FeePayment } from '../../../Models/FeePaymentService/FeePayment';
import { FeePaymentService } from '../../../Services/fee-payment.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fee-paymetn-create',
  templateUrl: './fee-paymetn-create.component.html',
  styleUrl: './fee-paymetn-create.component.css'
})
export class FeePaymetnCreateComponent implements OnInit {

  public feeStructuresList: FeeStructure[] = [];
  public model: FeePayment = new FeePayment();
  public selectedStandardId: number | null = null;
  public availableStandards: { id: number, name: string }[] = [];

  constructor(private feePaymentService: FeePaymentService, private router: Router) { }

  ngOnInit(): void {
    this.fetchFeeStructures();
    this.model = new FeePayment();
  }

  OnSubmit() {
    console.log('Submitting data:', this.model);

    this.feePaymentService.createFeePayment(this.model).subscribe({
      next: () => {
        this.router.navigate(['/fee-payments']);
      },
      error: (err) => { console.log(err); }
    });
  }

  fetchFeeStructures() {
    this.feePaymentService.getFeeStructures().subscribe(
      (data: FeeStructure[]) => {
        this.feeStructuresList = data;

        // Extract unique standardIds and standardNames
        const uniqueStandardsMap = new Map<number, string>();
        data.forEach(structure => {
          if (!uniqueStandardsMap.has(structure.standardId)) {
            uniqueStandardsMap.set(structure.standardId, structure.standardName);
          }
        });
        this.availableStandards = Array.from(uniqueStandardsMap.entries()).map(([id, name]) => ({ id, name }));
      },
      (error) => {
        console.error('Error fetching fee structures:', error);
      }
    );
  }

  // Add a method to filter fee structures based on selected standardId
  filterFeeStructures(): FeeStructure[] {
    if (this.selectedStandardId === null) {
      // If standardId is null, include all fee structures
      return this.feeStructuresList;
    } else {
      // Filter fee structures based on selected standardId
      return this.feeStructuresList
        .filter(structure => structure.standardId === this.selectedStandardId);
    }
  }
}

