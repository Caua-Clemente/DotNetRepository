class Tarefa{
    private string titulo;
    private string descricao;
    private DateTime dataVencimento;
    
    public Tarefa(string titulo, string descricao, DateTime dataVencimento){
        this.titulo = titulo;
        this.descricao = descricao;
        this.dataVencimento = dataVencimento;
    }
}

class ListaTarefa{
    private List<Tarefa> tarefas;

    public void criarTarefa(){

    }

    public void visualizarTarefa(){
        
    }

    public void listarTarefas(){

    }

    public void marcarConcluida(){

    }

    public void listarPendentes(){

    }

    public void listarConcluidas(){

    }

    public void excluirTarefa(){

    }

    public void pesquisa(){

    }

    public void qtdeTotal(){

    }

    public void qtdeConcluida(){

    }

    public void qtdePendente(){

    }

    public void tarefaAntiga(){

    }

    public void tarefaRecente(){

    }

}

class Program(){
    public static void Main(){
        int opcao = 0;
        ListaTarefa lista = new ListaTarefa();

        do {
            Console.WriteLine("--- Menu de opcoes---");
            Console.WriteLine("1 - Criar tarefa \n2 - Listar Tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluida \n4 - Listar Tarefas pendentes");
            Console.WriteLine("5 - Listar Tarefas concluidas \n6 - Excluir tarefa");
            Console.WriteLine("7 - Pesquisar por palavra chave \n8 - Mostrar quantidade total de tarefas");
            Console.WriteLine("9 - Mostrar quantidade de tarefas concluidas \n10 - Mostrar quantidade de tarefas pendentes");
            Console.WriteLine("11 - Mostrar a tarefa mais antiga \n12 - Mostrar a tarefa mais recente");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma acao: ");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    lista.criarTarefa();
                break;
                case 2:
                    lista.listarTarefas();
                break;
                case 3:
                    lista.marcarConcluida();
                break;
                case 4:
                    lista.listarPendentes();
                break;
                case 5:
                lista.listarConcluidas();
                break;
                case 6:
                    lista.excluirTarefa();
                break;
                case 7:
                    lista.pesquisa();
                break;
                case 8:
                    lista.qtdeTotal();
                break;
                case 9:
                    lista.qtdeConcluida();
                break;
                case 10:
                    lista.qtdePendente();
                break;
                case 11:
                    lista.tarefaAntiga();
                break;
                case 12:
                    lista.tarefaRecente();
                break;
                
            }

        } while(opcao > 0 && opcao < 13);

        Console.WriteLine("Operacao finalizada");
    }
}