import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShowTarefasComponent } from '../show-tarefas/show-tarefas.component';
import { InputTarefaComponent } from '../input-tarefa/input-tarefa.component';

@Component({
  selector: 'app-tarefas',
  standalone: true,
  imports: [CommonModule, ShowTarefasComponent, InputTarefaComponent],
  templateUrl: './tarefas.component.html',
  styleUrls: ['./tarefas.component.css']
})
export class TarefasComponent {

}
