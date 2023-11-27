using System.Security.Permissions;

void cadastrarProduto(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    int cod = estoque.Count();
    int qtde;
    string nome; 
    float preco;

    Console.WriteLine("---Cadastrando produto---");
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    Console.WriteLine("Quantidade em estoque: ");
    qtde = int.Parse(Console.ReadLine());
    Console.WriteLine("Preco unitario: ");
    preco = float.Parse(Console.ReadLine());
    
    var produto = (cod, nome, qtde, preco);
    estoque.Add(produto);
}

void consultarProduto(List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("---Consultando produto---");
    Console.WriteLine("Digite o codigo do produto: ");
    int cod = int.Parse(Console.ReadLine());
    var produto = estoque[cod];
    Console.WriteLine($"{produto.cod} - {produto.nome} - {produto.preco} - {produto.qtde}");
}

void adicionarQtde(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Atualizando Estoque---");
    Console.WriteLine("Digite o codigo do produto: ");
    int _cod = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade de unidades adicionadas ao estoque: ");
    int _qtde = int.Parse(Console.ReadLine());

    var produto = estoque[_cod];
    produto.qtde += _qtde;
    estoque[_cod] = produto;
}

void retirarQtde(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Atualizando Estoque---");
    Console.WriteLine("Digite o codigo do produto: ");
    int _cod = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade de unidades retiradas do estoque: ");
    int _qtde = int.Parse(Console.ReadLine());

    var produto = estoque[_cod];
    produto.qtde += _qtde;
    estoque[_cod] = produto;
}

void linqQtde(List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Listando estoques menores que (n)---");
    Console.WriteLine("Digite a quantidade limite para listar: ");
    int limite = int.Parse(Console.ReadLine());
    Console.WriteLine($"Lista de estoques com {limite} ou menos produtos: ");

    var estoqueLimite = estoque.Where(x => x.qtde <= limite);
    Console.WriteLine(string.Join("\n ", estoqueLimite.Select(e => $"{e.cod} - {e.nome} - {e.preco} - {e.qtde}")));
}

void linqMinMax(List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Listando estoques entre valor (min) e (max)---");
    Console.WriteLine("Digite o valor minimo: ");
    float minimo = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor maximo: ");
    float maximo = float.Parse(Console.ReadLine());
    
     Console.WriteLine($"Lista de estoques com produtos de R${minimo} a R${maximo}: ");
    var estoqueMinMax = estoque.Where(x => x.preco >= minimo && x.preco <= maximo);
    Console.WriteLine(string.Join("\n ", estoqueMinMax.Select(e => $"{e.cod} - {e.nome} - {e.preco} - {e.qtde}")));
}

void linqTotal(List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Listando valores totais do estoque---");
    var listaQtde = estoque.Select(x => x.qtde);
    var listaPreco = estoque.Select(x => x.preco);
    var totalProduto =  listaQtde.Zip(listaPreco, (x,y) => x * y).ToList();
    float totalEstoque = totalProduto.Sum();
    
    Console.WriteLine($"Valor total do estoque: {totalEstoque}");
    Console.WriteLine("Valor total por produto: ");
    Console.WriteLine(string.Join("\n ", estoque.Select(e => $"{e.cod} - {e.nome} - {e.preco * e.qtde}")));
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
    acao = int.Parse(Console.ReadLine());
    
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
            Console.WriteLine("Opcao invalida, digite novamente");
        break;
        
    }

} while(acao != 0);

Console.WriteLine();