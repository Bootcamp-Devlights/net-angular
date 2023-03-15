import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuestionUpsertComponent } from './question-upsert.component';

describe('QuestionUpsertComponent', () => {
  let component: QuestionUpsertComponent;
  let fixture: ComponentFixture<QuestionUpsertComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuestionUpsertComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuestionUpsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
