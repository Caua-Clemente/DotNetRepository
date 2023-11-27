using System.Security.Permissions;

void cadastrarProduto(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    int cod = estoque.Count();
    int qtde;
    string nome; 
    float preco;

    Console.WriteLine("---Cadastrando produto---");
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    if(string.IsNullOrEmpty(nome)){
        Console.WriteLine("Erro: \nOs atributos do produto nao podem ser vazios");
        return;
    }


    Console.WriteLine("Quantidade em estoque: ");
    try{
        qtde = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }
    if(qtde < 0){
        Console.WriteLine("Erro: \nQuantidade e preco de um produto nao podem ser menores que 0");
        return;
    }


    Console.WriteLine("Preco unitario: ");
    try{
        preco = float.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }
    if(preco < 0){
        Console.WriteLine("Erro: \nQuantidade e preco de um produto nao podem ser menores que 0");
        return;
    }


    var produto = (cod, nome, qtde, preco);
    estoque.Add(produto);
}

void consultarProduto(List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("---Consultando produto---");
    Console.WriteLine("Digite o codigo do produto: ");
    int cod;
    try{
         cod = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(cod < 0 || cod >= estoque.Count()){
        Console.WriteLine("Erro:\n codigo nao encontrado");
        return;
    }

    var produto = estoque[cod];
    Console.WriteLine("Produto: ");
    Console.WriteLine($"{produto.cod} - {produto.nome} - R${produto.preco} - {produto.qtde}");
}

void adicionarQtde(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("--Atualizando Estoque---");
    Console.WriteLine("Digite o codigo do produto: ");
    int _cod;
    try{
         _cod = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(_cod < 0 || _cod >= estoque.Count()){
        Console.WriteLine("Erro:\n codigo nao encontrado");
        return;
    }
    
    Console.WriteLine("Quantidade de unidades adicionadas ao estoque: ");
    int _qtde;
    try{
        _qtde = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }
    if(_qtde <= 0){
        Console.WriteLine("Erro: \nA quantidade de produtos adicionados nao pode ser menor ou igual 0;");
        return;
    }

    var produto = estoque[_cod];
    produto.qtde += _qtde;
    estoque[_cod] = produto;
}

void retirarQtde(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("--Atualizando Estoque---");
    Console.WriteLine("Digite o codigo do produto: ");
    int _cod;
    try{
         _cod = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(_cod < 0 || _cod >= estoque.Count()){
        Console.WriteLine("Erro:\n codigo nao encontrado");
        return;
    }
    
    Console.WriteLine("Quantidade de unidades retiradas do estoque: ");
    int _qtde;
    try{
        _qtde = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(_qtde <= 0){
        Console.WriteLine("Erro: \nA quantidade de produtos retiradas nao pode ser menor ou igual 0;");
        return;
    }

    var produto = estoque[_cod];
    if(_qtde > produto.qtde){
        Console.WriteLine("Erro: \nA quantidade de produtos retiradas nao pode ser maior do que a quantidade atual;");
        return;
    }
    produto.qtde -= _qtde;
    estoque[_cod] = produto;
}

void linqQtde(List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("--Listando estoques menores que (n)---");
    Console.WriteLine("Digite a quantidade limite para listar: ");
    int limite = 0;
    try {
        limite = int.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(limite < 0){
        Console.WriteLine("Erro: \nO valor limite nao pode ser negativo");
        return;
    }

    Console.WriteLine($"Lista de estoques com {limite} ou menos produtos: ");

    var estoqueLimite = estoque.Where(x => x.qtde <= limite);
    Console.WriteLine(string.Join("\n", estoqueLimite.Select(e => $"{e.cod} - {e.nome} - R${e.preco} - {e.qtde}")));
}

void linqMinMax(List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("--Listando estoques entre valor (min) e (max)---");
    Console.WriteLine("Digite o valor minimo: ");
    float minimo = 0;
    try {
        minimo = float.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(minimo < 0){
        Console.WriteLine("Erro: \nOs valores minimo e maximo nao podem ser negativos");
        return;
    }

    Console.WriteLine("Digite o valor minimo: ");
    float maximo = 0;
    try {
        maximo = float.Parse(Console.ReadLine());
    }
    catch(Exception ex){
        Console.WriteLine($"Um erro ocorreu: \n{ex.Message}");
        return;
    }

    if(maximo < 0){
        Console.WriteLine("Erro: \nOs valores minimo e maximo nao podem ser negativos");
        return;
    }

    Console.WriteLine($"Lista de estoques com produtos de R${minimo} a R${maximo}: ");
    var estoqueMinMax = estoque.Where(x => x.preco >= minimo && x.preco <= maximo);
    Console.WriteLine(string.Join("\n", estoqueMinMax.Select(e => $"{e.cod} - {e.nome} - R${e.preco} - {e.qtde}")));
}

void linqTotal(List<(int cod, string nome, int qtde, float preco)> estoque){
    if(estoque.Count() == 0){
        Console.WriteLine("O estoque esta vazio. Retornando ao menu");
        return;
    }

    Console.WriteLine("--Listando valores totais do estoque---");
    var listaQtde = estoque.Select(x => x.qtde);
    var listaPreco = estoque.Select(x => x.preco);
    var totalProduto =  listaQtde.Zip(listaPreco, (x,y) => x * y).ToList();
    float totalEstoque = totalProduto.Sum();
    
    Console.WriteLine($"Valor total do estoque: {totalEstoque}");
    Console.WriteLine("Valor total por produto: ");
    Console.WriteLine(string.Join("\n", estoque.Select(e => $"{e.cod} - {e.nome} - R${e.preco * e.qtde}")));
}

List<(int cod, string nome, int qtde, float preco)> estoque = new();
int acao = 0;
do{
    Console.WriteLine("\n--Gerenciador de estoque---");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Consultar produto");
    Console.WriteLine("3 - Adicionar (n) ao estoque de produto");
    Console.WriteLine("4 - Retirar (n) ao estoque de produto");
    Console.WriteLine("5 - Listar estoques menores que (n)");
    Console.WriteLine("6 - Listar produtos com valor entre (min) e (max)");
    Console.WriteLine("7 - Consultar valor total do estoque");
    Console.WriteLine("0 - sair");
    
    Console.WriteLine("Digite uma opcao: ");
    bool checkTry = true;
    try {
        acao = int.Parse(Console.ReadLine());
    }
    catch(NullReferenceException ex){
        Console.WriteLine("Erro: Nao e possivel colocar uma opcao nula, digite novamente;");
        checkTry = false;
        acao = -1;
    }
    catch(Exception ex){
        checkTry = false;
        Console.WriteLine("Um erro ocorreu");
        Console.WriteLine(ex.Message);
        acao = -1;
    }

    if (checkTry == true){
        if(acao < 0 || acao > 7){
            Console.WriteLine("Erro: \nOpcao invalida, digite apenas de 0 a 7");
            checkTry = false;
            acao = -1;
        }
    }
    
    Console.WriteLine();

    switch(acao){
        case 0:
            Console.WriteLine("---Finalizando operacao---");
        break;

        case 1:
            cadastrarProduto(ref estoque);
        break;

        case 2:
            consultarProduto(estoque);
        break;

        case 3:
            adicionarQtde(ref estoque);
        break;

        case 4:
            retirarQtde(ref estoque);
        break;

        case 5:
            linqQtde(estoque);
        break;

        case 6:
            linqMinMax(estoque);
        break;

        case 7:
            linqTotal(estoque);
        break;

        default:
        break;
    }

} while(acao != 0);

Console.WriteLine();