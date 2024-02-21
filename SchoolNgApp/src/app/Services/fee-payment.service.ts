// fee-payment.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class FeePaymentService {
  private apiUrl = 'https://localhost:7225/api/FeePayments'; // Update with your actual API URL

  constructor(private http: HttpClient) { }

  getFeePayments(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  getFeePaymentById(id: number): Observable<any> {
    return this.http.get(`${this.apiUrl}/${id}`);
  }
  searchFeePayment(studentId: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}?studentId=${studentId}`);
  }

  createFeePayment(feePayment: any): Observable<any> {
    return this.http.post(this.apiUrl, feePayment);
  }

  updateFeePayment(feePayment: any): Observable<any> {
    return this.http.put(`${this.apiUrl}/${feePayment.id}`, feePayment);
  }

  deleteFeePayment(feePaymentId: number): Observable<void> {
    const url = `${this.apiUrl}/${feePaymentId}`;
    return this.http.delete<void>(url);
  }

  getFeeStructures(): Observable<any[]> {
    const url = `${this.apiUrl}FeeStructures`;  // Replace with your actual API endpoint
    return this.http.get<any[]>("https://localhost:7225/api/FeeStructures");
  }
  getFeeType(): Observable<any[]> {
    const url = `${this.apiUrl}FeeStructures`;  // Replace with your actual API endpoint
    return this.http.get<any[]>("https://localhost:7225/api/FeeTypes");
  }
}
