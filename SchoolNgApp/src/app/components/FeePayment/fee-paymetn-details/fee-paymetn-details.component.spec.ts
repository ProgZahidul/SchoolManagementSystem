import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeePaymetnDetailsComponent } from './fee-paymetn-details.component';

describe('FeePaymetnDetailsComponent', () => {
  let component: FeePaymetnDetailsComponent;
  let fixture: ComponentFixture<FeePaymetnDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeePaymetnDetailsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeePaymetnDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
