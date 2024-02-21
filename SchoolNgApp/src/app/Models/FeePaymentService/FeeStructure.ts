export class FeeStructure {
  feeStructureId!: number;
  feeTypeId!: number;
  typeName!: string;
  standardId!: number;
  standardName!: string;
  monthly!: boolean;
  yearly!: boolean;
  feeAmount!: number;
  feeType!: FeeType; // Replace 'FeeType' with your actual model if available
  standard!: Standard; // Replace 'Standard' with your actual model if available
}

export class FeeType {
  feeTypeId!: number;
  feeTypeName!: string;
  // Add other properties as needed
}

export class Standard {
  standardId!: number;
  standardName!: string;
  // Add other properties as needed
}
