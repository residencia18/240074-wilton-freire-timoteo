import { signalStore, withMethods, withState, patchState } from '@ngrx/signals';
import { Tarefa } from '../models/tarefa.model';

type TarefasState = {
    tarefas: Tarefa[];
};

const initialState: TarefasState = {
    tarefas: [
        { id: '1', descricao: 'Aprender Angular com a residencia TIC18 do CEPEDI' },
        { id: '2', descricao: 'Aprender NgRx com a residencia TIC18 do CEPEDI' },
        { id: '3', descricao: 'Aprender Redux com a residencia TIC18 do CEPEDI' },
    ],
};

export const tarefasStore = signalStore(
    { providedIn: 'root' },
    withState(initialState),
    withMethods((store) => ({
        addTarefa(tarefa: Tarefa) {
            const tarefas = store.tarefas();
            patchState(store, { tarefas: [...tarefas, tarefa] });
        },
        removeTarefa(id: string) {
            const tarefas = store.tarefas();
            patchState(store, { tarefas: tarefas.filter(tarefa => tarefa.id !== id) });
        },
        updateTarefa(id: string, descricao: string) {
            const tarefas = store.tarefas();
            patchState(store, {
                tarefas: tarefas.map(tarefa =>
                    tarefa.id === id ? { ...tarefa, descricao } : tarefa
                )
            });
        },
    }))
);
