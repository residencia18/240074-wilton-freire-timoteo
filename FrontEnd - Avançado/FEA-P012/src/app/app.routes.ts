import { Routes } from '@angular/router';
import { EditaTarefaComponent } from './edita-tarefa/edita-tarefa.component';
import { TarefasComponent } from './tarefas/tarefas.component';

export const routes: Routes = [
    { path: '', component: TarefasComponent },
    { path: 'edita-tarefa/:id', component: EditaTarefaComponent }
];