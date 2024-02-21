
export class FeePayment {
  feePaymentId: number = 0;
  studentId: number = 0;
  discount: number = 0;
  amountPaid: number = 0;
  feeStructures: { feeStructureId: number }[] = [];
}

//{
//  "studentId": 1,
//    "discount": 5,
//      "amountPaid": 500,
//        "feeStructures": [
//          { "feeStructureId": 3 }
//        ]
//}

//Not like
//{
//  "studentId": 1,
//    "discount": 5,
//      "amountPaid": 500,
//        "feeStructures": [3]
//}
