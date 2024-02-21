import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeePaymetnCreateComponent } from './fee-paymetn-create.component';

describe('FeePaymetnCreateComponent', () => {
  let component: FeePaymetnCreateComponent;
  let fixture: ComponentFixture<FeePaymetnCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeePaymetnCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeePaymetnCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
