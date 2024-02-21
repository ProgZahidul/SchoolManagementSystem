import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeePaymetnEditComponent } from './fee-paymetn-edit.component';

describe('FeePaymetnEditComponent', () => {
  let component: FeePaymetnEditComponent;
  let fixture: ComponentFixture<FeePaymetnEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeePaymetnEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeePaymetnEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
