import { createAction, props } from '@ngrx/store';
import { Tarefa } from '../tarefa.model';

export const adicionarTarefa = createAction(
    '[Tarefa] Adicionar Tarefa',
    props<{ tarefa: Tarefa }>()
);

export const removerTarefa = createAction(
    '[Tarefa] Remover Tarefa',
    props<{ id: string }>()
);

export const editarTarefa = createAction(
    '[Tarefa] Editar Tarefa',
    props<{ id: string, descricao: string }>()
);
