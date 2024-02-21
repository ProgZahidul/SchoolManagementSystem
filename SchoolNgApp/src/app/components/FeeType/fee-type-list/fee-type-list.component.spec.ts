import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FeeTypeListComponent } from './fee-type-list.component';

describe('FeeTypeListComponent', () => {
  let component: FeeTypeListComponent;
  let fixture: ComponentFixture<FeeTypeListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FeeTypeListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FeeTypeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
