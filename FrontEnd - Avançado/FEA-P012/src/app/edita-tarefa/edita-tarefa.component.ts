import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { tarefasStore } from '../store/tarefa.store';

@Component({
  selector: 'app-edita-tarefa',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './edita-tarefa.component.html',
  styleUrl: './edita-tarefa.component.scss'
})
export class EditaTarefaComponent {
  description: string = '';
  tarefasStore = inject(tarefasStore);

  constructor(private route: ActivatedRoute, private routes: Router) { }

  salvar() {
    this.tarefasStore.updateTarefa(this.route.snapshot.paramMap.get('id')!, this.description);

    setTimeout(() => {
      this.routes.navigate(['/']);
    }, 100);
  }
}
