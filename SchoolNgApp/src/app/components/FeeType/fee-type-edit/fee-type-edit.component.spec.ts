import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeeTypeEditComponent } from './fee-type-edit.component';

describe('FeeTypeEditComponent', () => {
  let component: FeeTypeEditComponent;
  let fixture: ComponentFixture<FeeTypeEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeeTypeEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeeTypeEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
