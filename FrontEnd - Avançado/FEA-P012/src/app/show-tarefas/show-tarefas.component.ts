import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { tarefasStore } from '../store/tarefa.store';
import { Tarefa } from '../models/tarefa.model';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-show-tarefas',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './show-tarefas.component.html',
  styleUrls: ['./show-tarefas.component.scss'],
})
export class ShowTarefasComponent {
  tarefasStore = inject(tarefasStore);

  removeTarefa(id: string) {
    this.tarefasStore.removeTarefa(id);
  }
}
