import { Component, inject } from '@angular/core';
import { tarefasStore } from '../store/tarefa.store';
import { Tarefa } from '../models/tarefa.model';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-input-tarefa',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './input-tarefa.component.html',
  styleUrl: './input-tarefa.component.scss'
})
export class InputTarefaComponent {
  newTask = '';
  tarefasStore = inject(tarefasStore);

  addTarefa() {
    const newTarefa: Tarefa = {
      id: this.generateId(),
      descricao: this.newTask,
    };

    this.tarefasStore.addTarefa(newTarefa);
    this.newTask = '';
  }

  generateId() {
    return Date.now().toString(36) + Math.random().toString(36).substring(2);
  }
}
