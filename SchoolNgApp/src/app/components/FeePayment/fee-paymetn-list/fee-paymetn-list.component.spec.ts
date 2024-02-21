import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeePaymetnListComponent } from './fee-paymetn-list.component';

describe('FeePaymetnListComponent', () => {
  let component: FeePaymetnListComponent;
  let fixture: ComponentFixture<FeePaymetnListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeePaymetnListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeePaymetnListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
