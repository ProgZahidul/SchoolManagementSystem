import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeeTypeCreateComponent } from './fee-type-create.component';

describe('FeeTypeCreateComponent', () => {
  let component: FeeTypeCreateComponent;
  let fixture: ComponentFixture<FeeTypeCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeeTypeCreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeeTypeCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
