import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ShowTarefasComponent } from '../show-tarefas/show-tarefas.component';
import { InputTarefaComponent } from '../input-tarefa/input-tarefa.component';

@Component({
  selector: 'app-tarefas',
  standalone: true,
  imports: [CommonModule, ShowTarefasComponent, InputTarefaComponent],
  templateUrl: './tarefas.component.html',
  styleUrl: './tarefas.component.scss'
})
export class TarefasComponent {

}
