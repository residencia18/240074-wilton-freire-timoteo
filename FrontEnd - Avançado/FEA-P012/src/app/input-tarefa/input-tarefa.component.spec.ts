import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InputTarefaComponent } from './input-tarefa.component';

describe('InputTarefaComponent', () => {
  let component: InputTarefaComponent;
  let fixture: ComponentFixture<InputTarefaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InputTarefaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(InputTarefaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
