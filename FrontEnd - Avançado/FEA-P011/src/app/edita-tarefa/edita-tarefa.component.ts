import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { Store } from '@ngrx/store';
import { TarefaState } from '../store/tarefa.reducer';
import { editarTarefa } from '../store/tarefa.actions';

@Component({
  selector: 'app-edita-tarefa',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './edita-tarefa.component.html',
  styleUrls: ['./edita-tarefa.component.css']
})
export class EditaTarefaComponent {
  description: string = '';

  constructor(private route: ActivatedRoute, private routes: Router, private store: Store<{ tarefas: TarefaState }>) { }

  salvar() {
    this.store.dispatch(editarTarefa({ id: this.route.snapshot.paramMap.get('id')!, descricao: this.description }));
    setTimeout(() => {
      this.routes.navigate(['/']);
    }, 100);
  }
}
