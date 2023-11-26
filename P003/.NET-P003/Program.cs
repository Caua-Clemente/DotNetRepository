using System.Security.Permissions;

(int cod, string nome, int qtde, float preco) cadastrarProduto(int listSize){
    int cod = listSize;
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
    return produto;
}

void consultarProduto(List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("---Consultando produto---");
    Console.WriteLine("Digite o codigo do produto: ");
    int cod = int.Parse(Console.ReadLine());
    var produto = estoque[cod];
    Console.WriteLine("Nome: {} \nQuantidade no estoque: {} \nPreco unitario: R${}", produto.nome, produto.qtde, produto.preco);
}

void atualizarEstoque(ref List<(int cod, string nome, int qtde, float preco)> estoque){
    Console.WriteLine("--Atualizando Estoque---");
    Console.WriteLine("Digite o codigo do produto: ");
    int _cod = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade de unidades adicionadas (ou retiradas) do estoque: ");
    int _qtde = int.Parse(Console.ReadLine());

    var produto = estoque[_cod];
    produto.qtde += _qtde;
    estoque[_cod] = produto;
}

List<(int cod, string nome, int qtde, float preco)> estoque = new();
int acao = 0;
do{
    Console.WriteLine("--Gerenciador de estoque---");
    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Consultar produto");
    Console.WriteLine("3 - Atualizar estoque de produto");
    Console.WriteLine("4 - Listar estoques menores que (n)");
    Console.WriteLine("5 - Listar produtos com valor entre (min) e (max)");
    Console.WriteLine("6 - Consultar valor total do estoque");
    Console.WriteLine("0 - sair");
    Console.WriteLine("Digite uma opcao: ");
    acao = int.Parse(Console.ReadLine());
    
    Console.WriteLine();

    switch(acao){
        case 0:
            Console.WriteLine("---Finalizando operacao---");
        break;

        case 1:
            estoque.Add(cadastrarProduto(estoque.Count));
        break;

        case 2:

        break;

        case 3:

        break;

        case 4:

        break;

        case 5:

        break;

        case 6:

        break;

        default:

        break;
        
    }

} while(acao != 0);

Console.WriteLine();