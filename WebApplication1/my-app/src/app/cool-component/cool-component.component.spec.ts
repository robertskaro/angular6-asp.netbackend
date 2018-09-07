import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CoolComponentComponent } from './cool-component.component';

describe('CoolComponentComponent', () => {
  let component: CoolComponentComponent;
  let fixture: ComponentFixture<CoolComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CoolComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CoolComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
