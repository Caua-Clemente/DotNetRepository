class Tarefa{
    private string titulo;
    private string descricao;
    private DateTime dataVencimento;
    private bool concluido;
    
    public Tarefa(string titulo, string descricao, DateTime dataVencimento){
        this.titulo = titulo;
        this.descricao = descricao;
        this.dataVencimento = dataVencimento;
        this.concluido = false;
    }

    public string getTitulo(){
        return this.titulo;
    }

    public string getDescricao(){
        return this.descricao;
    }

    public DateTime getData(){
        return this.dataVencimento;
    }

    public bool getConcluido(){
        return this.concluido;
    }

    public void setConcluido(){
        this.concluido = true;
    }
}

class ListaTarefa{
    private List<Tarefa> tarefas;

    public void criarTarefa(){
        string titulo, descricao, dataStr;
        int dia, mes, ano;

        Console.WriteLine("Digite o titulo da tarefa: ");
        titulo = Console.ReadLine();

        Console.WriteLine("Digite a descricao da tarefa: ");
        descricao = Console.ReadLine();

        Console.WriteLine("Digite a data de vencimento da terefa (dd/mm/aaaa): ");
        dataStr = Console.ReadLine();

        dia = int.Parse(dataStr.Substring(0,2));
        mes = int.Parse(dataStr.Substring(3,2));
        ano = int.Parse(dataStr.Substring(6,4));

        DateTime data = new DateTime(ano, mes, dia, 0, 0, 0, 0);

        Tarefa tarefa = new Tarefa(titulo, descricao, data);
        this.tarefas.Add(tarefa);
        Console.WriteLine("Tarefa criada com sucesso! \n");
    }

    public void visualizarTarefa(int index){
        Tarefa tarefa = this.tarefas[index];
        Console.WriteLine(tarefa.getTitulo());
        Console.WriteLine(tarefa.getDescricao());
        Console.WriteLine("Data de vencimento: " + tarefa.getData());
        if(tarefa.getConcluido())
            Console.WriteLine("Concluido \n");
        else
            Console.WriteLine("Nao concluido \n");
    }

    public void listarTarefas(){
        for(int i = 0; i < tarefas.Count; i++){
            visualizarTarefa(i);
        }
    }

    public void marcarConcluida(){
        int index;
        Console.WriteLine("Digite o numero da tarefa a ser marcada: ");
        index = int.Parse(Console.ReadLine());
        if(tarefas[index].getConcluido())
            Console.WriteLine("A tarefa ja foi concluida\n");
        else {
            this.tarefas[index].setConcluido();
            Console.WriteLine("Tarefa concluida com sucesso \n");
        }
    }

    public void listarPendentes(){
        Console.WriteLine("Tarefas pendentes: \n");
        for(int i = 0; i < tarefas.Count; i++){
            if(!tarefas[i].getConcluido())
                visualizarTarefa(i);
        }
    }

    public void listarConcluidas(){
        Console.WriteLine("Tarefas concluidas: \n");
        for(int i = 0; i < tarefas.Count; i++){
            if(tarefas[i].getConcluido())
                visualizarTarefa(i);
        }
    }

    public void excluirTarefa(){
        int index;
        Console.WriteLine("Digite o numero da tarefa a ser marcada: ");
        index = int.Parse(Console.ReadLine());
        if(index < 0 || index >= tarefas.Count)
            Console.WriteLine("Nao existe nenhuma tarefa na posicao digitada \n");
        else {
            tarefas.RemoveAt(index);
            Console.WriteLine("Tarefa excluida com sucesso \n");
        }
    }

    public void pesquisa(){
        string word;
        Console.WriteLine("Digite uma palavra chave: ");
        word = Console.ReadLine();
        for(int i = 0; i < tarefas.Count; i++){
            if(tarefas[i].getTitulo().Contains(word) || tarefas[i].getDescricao().Contains(word))
                visualizarTarefa(i);
        }
    }

    public void qtdeTotal(){
        Console.WriteLine("Quantidade total de tarefas: " + tarefas.Count);
    }

    public void qtdeConcluida(){
        int qtde = 0;
        for(int i = 0; i < tarefas.Count; i++){
            if(tarefas[i].getConcluido())
                qtde += 1;
        }
        
        Console.WriteLine("Quantidade de tarefas concluidas: " + qtde);
    }

    public void qtdePendente(){
        int qtde = 0;
        for(int i = 0; i < tarefas.Count; i++){
            if(!tarefas[i].getConcluido())
                qtde += 1;
        }
        
        Console.WriteLine("Quantidade de tarefas pendentes: " + qtde);
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