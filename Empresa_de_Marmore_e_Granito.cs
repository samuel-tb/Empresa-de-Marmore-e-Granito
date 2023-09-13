namespace Loja_de_marmore_e_granito
{
    internal class Program
    {
        static string[] nome = new string[999];
        static int[] codigo = new int[999];
        static int[] numero = new int[999];
        static decimal[] medida = new decimal[999];
        static string[] descricao = new string[999];
        static decimal[] valorcompra = new decimal[999];
        static decimal[] valorvenda = new decimal[999];
        static string[] origem = new string[999];
        static string[] tipo = new string[999];
        static int i, resp;
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Max Rochas e Produtos Ornamentais!!\n");
            int op = 0;
            while (op != 5)
            {
                Console.WriteLine("|================================|");
                Console.WriteLine("|>>>>>>> Gestão de Blocos <<<<<<<|");
                Console.WriteLine("|1 - Cadastrar Blocos            |");
                Console.WriteLine("|2 - Listar Blocos               |");
                Console.WriteLine("|3 - Buscar Bloco por código     |");
                Console.WriteLine("|4 - Listar Blocos por pedreira  |");
                Console.WriteLine("|5 - Sair                        |");
                Console.WriteLine("|================================|");
                Console.Write("\nEscolha uma opção: ");
                op = int.Parse(Console.ReadLine()!);
                switch (op)
                {
                    case 1:

                        Cadastro();
                        break;

                    case 2:

                        ListarBlocos();
                        break;

                    case 3:

                        BuscarPorCodigo();
                        break;

                    case 4:

                        ListarPorPedreira();
                        break;

                    case 5:

                        Sair();
                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Essa opção não existe.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

            }
        }

        private static void Cadastro()
        {
            Console.Clear();
            if (i == 0)
            {
                Console.WriteLine(">>>>> Cadastro <<<<<");
                Console.Write("\nQuantos blocos deseja cadastrar ? ");
                resp = int.Parse(Console.ReadLine()!);
                Console.WriteLine("");
                for (i = 0; i < resp; i++)
                {
                    Console.Write($"Digite o tipo (mármore ou granito) do {i + 1}° bloco: ");
                    tipo[i] = Console.ReadLine()!;
                    Console.Write($"Digite o nome do {tipo[i]}: ");
                    nome[i] = Console.ReadLine()!;
                    Console.Write($"Digite o número do {nome[i]}: ");
                    numero[i] = int.Parse(Console.ReadLine()!);
                    Console.Write($"Digite o código do {nome[i]}: ");
                    codigo[i] = int.Parse(Console.ReadLine()!);
                    Console.Write($"Digite a medida (em metros cúbicos, ex: 0,00) do {nome[i]}: ");
                    medida[i] = decimal.Parse(Console.ReadLine()!);
                    Console.Write($"Digite o valor de compra (ex: 0,00) do {nome[i]}: ");
                    valorcompra[i] = decimal.Parse(Console.ReadLine()!);
                    Console.Write($"Digite o valor de venda (ex: 0,00) do {nome[i]}: ");
                    valorvenda[i] = decimal.Parse(Console.ReadLine()!);
                    Console.Write($"Digite a pedreira que corresponde ao {nome[i]}: ");
                    origem[i] = Console.ReadLine()!;
                    Console.Write($"Digite a descrição do {nome[i]}: ");
                    descricao[i] = Console.ReadLine()!;
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("");
                }
                Console.WriteLine("Cadastro Concluido.");
            }

            else
            {
                Console.WriteLine("O cadastro já foi feito.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();
            Console.Clear();

        }

        private static void ListarBlocos()
        {
            Console.Clear();
            if (i == 0)
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");
            }
            else
            {
                Console.WriteLine(">>>>>> Lista de Blocos <<<<<<\n");
                for (i = 0; i < resp; i++)
                {
                    Console.WriteLine("=========================================================");
                    Console.WriteLine($"Tipo - {tipo[i]}");
                    Console.WriteLine($"Nome - {nome[i]}");
                    Console.WriteLine($"Número - {numero[i]}");
                    Console.WriteLine($"Código - {codigo[i]}");
                    Console.WriteLine($"Medida - {medida[i]}");
                    Console.WriteLine($"Valor de compra - R${valorcompra[i]}");
                    Console.WriteLine($"Valor de venda - R${valorvenda[i]}");
                    Console.WriteLine($"Origem - {origem[i]}");
                    Console.WriteLine($"Descrição - {descricao[i]}");
                    Console.WriteLine("=========================================================");
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void BuscarPorCodigo()
        {
            Console.Clear();
            if (i == 0)
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");

            }

            else
            {
                Console.Write("Digite o código que deseja buscar: ");
                int buscar = int.Parse(Console.ReadLine()!);
                Console.Clear();
                int b = Array.IndexOf(codigo, buscar);
                Console.WriteLine($"O item que corresponde ao código {buscar} é: \n");
                Console.WriteLine("=========================================================");
                Console.WriteLine($"Tipo - {tipo[b]}");
                Console.WriteLine($"Nome - {nome[b]}");
                Console.WriteLine($"Número - {numero[b]}");
                Console.WriteLine($"Medida - {medida[b]}");
                Console.WriteLine($"Valor de compra - R${valorcompra[b]}");
                Console.WriteLine($"Valor de venda - R${valorvenda[b]}");
                Console.WriteLine($"Origem - {origem[b]}");
                Console.WriteLine($"Descrição - {descricao[b]}");
                Console.WriteLine("=========================================================");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void ListarPorPedreira()
        {
            Console.Clear();
            if (i == 0)
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");

            }
            else
            {
                Ordem();
                Console.Clear();
                Ordem();

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Ordem()
        {
            string aux, aux1, aux2, aux3;
            int aux4, aux5;
            decimal aux6, aux7, aux8;

          
            
                for (i = 0; i < resp; i++)
                {
                    if (origem[i] != origem[i + 1])
                    {
                        
                        aux = origem[i + 1];
                        aux1 = descricao[i + 1];
                        aux2 = nome[i + 1];
                        aux3 = tipo[i + 1];
                        aux4 = codigo[i + 1];
                        aux5 = numero[i + 1];
                        aux6 = medida[i + 1];
                        aux7 = valorcompra[i + 1];
                        aux8 = valorvenda[i + 1];

                        origem[i + 1] = origem[i];
                        descricao[i + 1] = descricao[i];
                        nome[i + 1] = nome[i];
                        tipo[i + 1] = tipo[i];
                        codigo[i + 1] = codigo[i];
                        numero[i + 1] = numero[i];
                        medida[i + 1] = medida[i];
                        valorcompra[i + 1] = valorcompra[i];
                        valorvenda[i + 1] = valorvenda[i];

                        origem[i] = aux;
                        descricao[i] = aux1;
                        nome[i] = aux2;
                        tipo[i] = aux3;
                        codigo[i] = aux4;
                        numero[i] = aux5;
                        medida[i] = aux6;
                        valorcompra[i] = aux7;
                        valorvenda[i] = aux8;

                        

                    }

                    else if (origem[i] == origem[i + 1])
                    {

                        for (i = 0; i < resp; i++)
                        {
                            Console.WriteLine("=========================================================");
                            Console.WriteLine($">>>>>>> Pedreira: {origem[i]} <<<<<<<\n");
                            Console.WriteLine($"Tipo - {tipo[i]}");
                            Console.WriteLine($"Nome - {nome[i]}");
                            Console.WriteLine($"Número - {numero[i]}");
                            Console.WriteLine($"Medida - {medida[i]}");
                            Console.WriteLine($"Valor de compra - R${valorcompra[i]}");
                            Console.WriteLine($"Valor de venda - R${valorvenda[i]}");
                            Console.WriteLine($"Descrição - {descricao[i]}");
                            Console.WriteLine("=========================================================");
                        }
                    }
                }
            
            
        }
              
        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Encerrando sistema...");
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Obrigado por entrar na Max Rochas e Produtos Ornamentais.\nVolte sempre :D\n\n");
        }
    }
}


