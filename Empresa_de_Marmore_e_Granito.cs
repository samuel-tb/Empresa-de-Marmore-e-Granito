namespace Loja_de_marmore_e_granito
{
    internal class Program
    {
        static string[] nome = new string[999];                                             // Variável usada para cadastrar o nome do bloco
        static int[] codigo = new int[999];                                                 // Variável usada para cadastrar o código do bloco
        static int[] numero = new int[999];                                                 // Variável usada para cadastrar o número do bloco
        static decimal[] medida = new decimal[999];                                         // Variável usada para cadastrar o medida do bloco
        static string[] descricao = new string[999];                                        // Variável usada para cadastrar o descrição do bloco
        static decimal[] valorcompra = new decimal[999];                                    // Variável usada para cadastrar o valor de compra do bloco
        static decimal[] valorvenda = new decimal[999];                                     // Variável usada para cadastrar o valor de venda do bloco
        static string[] origem = new string[999];                                           // Variável usada para cadastrar o pedreira que corresponde ao bloco
        static string[] tipo = new string[999];                                             // Variável usada para cadastrar o tipo do bloco
        static int i, resp;                                                                 // Variável "i" usada para fazer o loop do for, e variável "resp" usada para receber                                                                                     o valor de quantos blocos seram cadastrados
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Max Rochas e Produtos Ornamentais!!\n");
            int op = 0;                                                                     // Variável usada para receber o valor da opção selecionada
            while (op != 5)                                                                 // Loop para o menu de opções repetir enquanto a opção selecionada não for "5"
            {
                Console.WriteLine("|================================|");                    // Menu de Opções
                Console.WriteLine("|>>>>>>> Gestão de Blocos <<<<<<<|");
                Console.WriteLine("|1 - Cadastrar Blocos            |");
                Console.WriteLine("|2 - Listar Blocos               |");
                Console.WriteLine("|3 - Buscar Bloco por código     |");
                Console.WriteLine("|4 - Listar Blocos por pedreira  |");
                Console.WriteLine("|5 - Sair                        |");
                Console.WriteLine("|================================|");
                Console.Write("\nEscolha uma opção: ");
                op = int.Parse(Console.ReadLine()!);                                        // "op" recebe o valor digitado pelo usuário
                switch (op)                                                                 // Armazena o valor do "op"
                {
                    case 1:                                                                 // Caso escolha "1"

                        Cadastro();                                                         //Puxa a função do cadastro de blocos
                        break;

                    case 2:                                                                 // Caso escolha "2"

                        ListarBlocos();                                                     // Puxa a função da listagem de blocos
                        break;

                    case 3:                                                                 // Caso escolha "3"

                        BuscarPorCodigo();                                                  // Puxa a função de buscar por código do bloco
                        break;

                    case 4:                                                                 // Caso escolha "4"

                        ListarPorPedreira();                                                // Puxa a função de ordenar os blocos de acordo com a pedreira
                        break;

                    case 5:                                                                 // Caso escolha "5"

                        Sair();                                                             // Puxa a função de sair
                        break;

                    default:                                                                            // Caso a escolha for diferente de 1 ou 2 ou 3 ou 4 ou 5      

                        Console.Clear();                                                                // Limpa tudo escrito antes                                   
                        Console.WriteLine("Essa opção não existe.");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções");
                        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar
                        Console.Clear();                                                                // Limpa tudo escrito antes
                        break;

                }

            }
        }

        private static void Cadastro()                                                                       // Função de cadastrar blocos
        {
            Console.Clear();                                                                                // Limpa tudo escrito antes
            if (i == 0)                                                                                     // Se o usuário ainda não cadastrou os blocos
            {
                Console.WriteLine(">>>>> Cadastro <<<<<");
                Console.Write("\nQuantos blocos deseja cadastrar ? ");                          
                resp = int.Parse(Console.ReadLine()!);                                                      // Armazena o valor que corresponde a quantos blocos deseja cadastrar
                Console.WriteLine("");
                for (i = 0; i < resp; i++)                                                                  // Estrutura de repetição para o cadastro dos blocos
                {
                    Console.Write($"Digite o tipo (mármore ou granito) do {i + 1}° bloco: ");               // Pergunta qual o tipo de bloco deseja cadastrar
                    tipo[i] = Console.ReadLine()!;                                                          // Armazena o valor do tipo do bloco
                    Console.Write($"Digite o nome do {tipo[i]}: ");                                         // Pergunta o nome do bloco
                    nome[i] = Console.ReadLine()!;                                                          // Armazena o nome do bloco
                    Console.Write($"Digite o número do {nome[i]}: ");                                       // Pergunta o número do bloco
                    numero[i] = int.Parse(Console.ReadLine()!);                                             // Armazena o número do bloco
                    Console.Write($"Digite o código do {nome[i]}: ");                                       // Pergunta o código do bloco
                    codigo[i] = int.Parse(Console.ReadLine()!);                                             // Armazena o código do bloco
                    Console.Write($"Digite a medida (em m³, ex: 0,00) do {nome[i]}: ");                     // Pergunta a medida do bloco
                    medida[i] = decimal.Parse(Console.ReadLine()!);                                         // Armazena a medida do bloco
                    Console.Write($"Digite o valor de compra (ex: 0,00) do {nome[i]}: ");                   // Pergunta o valor de compra do bloco
                    valorcompra[i] = decimal.Parse(Console.ReadLine()!);                                    // Armazena o valor de compra do bloco
                    Console.Write($"Digite o valor de venda (ex: 0,00) do {nome[i]}: ");                    // Pergunta o valor de venda do bloco
                    valorvenda[i] = decimal.Parse(Console.ReadLine()!);                                     // Armazena o valor de compra do bloco
                    Console.Write($"Digite a pedreira que corresponde ao {nome[i]}: ");                     // Pergunta a pedreira do bloco
                    origem[i] = Console.ReadLine()!;                                                        // Armazena a pedreira do bloco
                    Console.Write($"Digite a descrição do {nome[i]}: ");                                    // Pergunta a descrição do bloco
                    descricao[i] = Console.ReadLine()!;                                                     // Armazena a descrição do bloco
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("");
                }
                Console.WriteLine("Cadastro Concluido.");
            }

            else                                                                            // Se o usuário já cadastrou os blocos
            {
                Console.WriteLine("O cadastro já foi feito.");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar
            Console.Clear();                                                                // Limpa tudo escrito antes

        }

        private static void ListarBlocos()                                                  // Função de listar blocos
        {
            Console.Clear();                                                                // Limpa tudo escrito antes
            if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos 
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");
            }
            else                                                                            // Se o usuário já cadastrou os blocos
            {
                Console.WriteLine(">>>>>> Lista de Blocos <<<<<<\n");
                for (i = 0; i < resp; i++)                                                  // Estrutura de repetição para listar os blocos
                {
                    Console.WriteLine("=========================================================");
                    Console.WriteLine($"Tipo - {tipo[i]}");                                             // Lista o tipo do bloco
                    Console.WriteLine($"Nome - {nome[i]}");                                             // Lista o nome do bloco
                    Console.WriteLine($"Número - {numero[i]}");                                         // Lista o número do bloco
                    Console.WriteLine($"Código - {codigo[i]}");                                         // Lista o código do bloco
                    Console.WriteLine($"Medida - {medida[i]}m³");                                       // Lista a medida do bloco
                    Console.WriteLine($"Valor de compra - R${valorcompra[i]}");                         // Lista o valor de compra do bloco
                    Console.WriteLine($"Valor de venda - R${valorvenda[i]}");                           // Lista o valor de venda do bloco
                    Console.WriteLine($"Pedreira - {origem[i]}");                                       // Lista a pedreira do bloco    
                    Console.WriteLine($"Descrição - {descricao[i]}");                                   // Lista a descrição do bloco
                    Console.WriteLine("=========================================================");
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar
            Console.Clear();                                                                // Limpa tudo escrito antes
        }

        private static void BuscarPorCodigo()
        {
            Console.Clear();                                                                // Limpa tudo escrito antes
            if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos 
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");

            }

            else                                                                            // Se o usuário já cadastrou os blocos
            {
                Console.Write("Digite o código que deseja buscar: ");                       
                int buscar = int.Parse(Console.ReadLine()!);                                // Váriavel que recebe o código que o usuário deseja bsucar
                Console.Clear();                                                            // Limpa tudo escrito antes

                for (i = 0; i < resp; i++)                                                  // Estrutura de repetição para listar o bloco correspondente ao código digitado pelo usuário
                {
                    if (buscar == codigo[i])
                    {
                        Console.WriteLine($"O item que corresponde ao código {buscar} é: \n");
                        Console.WriteLine("=========================================================");
                        Console.WriteLine($"Tipo - {tipo[i]}");                                                 // Lista o tipo do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Nome - {nome[i]}");                                                 // Lista o nome do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Número - {numero[i]}");                                             // Lista o número do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Medida - {medida[i]}m³");                                           // Lista a medida do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Valor de compra - R${valorcompra[i]}");                             // Lista o valor de compra do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Valor de venda - R${valorvenda[i]}");                               // Lista o valor de venda do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Pedreira - {origem[i]}");                                           // Lista a pedreira do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine($"Descrição - {descricao[i]}");                                       // Lista a descrição do bloco que corresponde ao código digitado pelo usuário
                        Console.WriteLine("=========================================================\n");
                    }

                }
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar
            Console.Clear();                                                                // Limpa tudo escrito antes
        }

        private static void ListarPorPedreira()
        {
            Console.Clear();                                                                // Limpa tudo escrito antes
            if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos
            {
                Console.WriteLine("O cadastro dos itens ainda não foi feito.");
                Console.WriteLine("Volte depois de cadastrar algum item");

            }
            else                                                                            // Se o usuário já cadastrou os blocos
            {
                Ordem();                                                                    // Puxa a função de ordenar o blocos por pedreira
                Console.Clear();
                Ordem();

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");
            Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar
            Console.Clear();                                                                // Limpa tudo escrito antes
        }

        private static void Ordem()                                                         // Função de ordenar o blocos por pedreira
        {
            string aux, aux1, aux2, aux3;                                                   // Variáveis usadas para organizar os blocos
            int aux4, aux5;
            decimal aux6, aux7, aux8;



            for (i = 0; i < resp; i++)                                                      // Estrutura de repetição para verificar e organizar os blocos por pedreira
            {
                if (origem[i] != origem[i + 1])                                             // Se a pedreira atual for diferente a da próxima pedreira do array
                {

                    aux = origem[i + 1];                                                    // "aux" vira o valor da próxima pedreira do array
                    aux1 = descricao[i + 1];                                                // "aux1" vira o valor da próxima descrição do array
                    aux2 = nome[i + 1];                                                     // "aux2" vira o valor do próximo nome do array
                    aux3 = tipo[i + 1];                                                     // "aux3" vira o valor do próximo tipo do array
                    aux4 = codigo[i + 1];                                                   // "aux4" vira o valor do próximo código do array
                    aux5 = numero[i + 1];                                                   // "aux5" vira o valor do próximo número do array
                    aux6 = medida[i + 1];                                                   // "aux6" vira o valor da próxima medida do array
                    aux7 = valorcompra[i + 1];                                              // "aux7" vira o valor do próximo valor de compra do array
                    aux8 = valorvenda[i + 1];                                               // "aux8" vira o valor do próximo valor de venda do array

                    origem[i + 1] = origem[i];                                              // A pedreira atual vira o valor da próxima pedreira do array
                    descricao[i + 1] = descricao[i];                                        // A descrição atual vira o valor da próxima descrição do array
                    nome[i + 1] = nome[i];                                                  // O nome atual vira o valor do próximo nome do array
                    tipo[i + 1] = tipo[i];                                                  // O tipo atual vira o valor do próximo tipo do array
                    codigo[i + 1] = codigo[i];                                              // O código atual vira o valor do próximo código do array
                    numero[i + 1] = numero[i];                                              // O número atual vira o valor do próximo número do array
                    medida[i + 1] = medida[i];                                              // A medida atual vira o valor da próxima medida do array
                    valorcompra[i + 1] = valorcompra[i];                                    // O valor de compra atual vira o valor do próximo valor de compra do array
                    valorvenda[i + 1] = valorvenda[i];                                      // O valor de venda vira o valor do próximo valor de venda do array

                    origem[i] = aux;                                                        // A origem atual do array vira o valor do "aux"
                    descricao[i] = aux1;                                                    // A descrição atual do array vira o valor do "aux1"
                    nome[i] = aux2;                                                         // O nome atual do array vira o valor do "aux2"
                    tipo[i] = aux3;                                                         // O tipo atual do array vira o valor do "aux3"
                    codigo[i] = aux4;                                                       // O código atual do array vira o valor do "aux4"
                    numero[i] = aux5;                                                       // O número atual do array vira o valor do "aux5"
                    medida[i] = aux6;                                                       // A medida atual do array vira o valor do "aux6"
                    valorcompra[i] = aux7;                                                  // O valor de compra atual do array vira o valor do "aux7"
                    valorvenda[i] = aux8;                                                   // O valor de venda do array vira o valor do "aux8"



                }

                else if (origem[i] == origem[i + 1])                                        // Se a pedreira atual for igual a da próxima pedreira do array                                                      
                {

                    for (i = 0; i < resp; i++)                                              // Estrutura de repetição para listar os blocos
                    {
                        Console.WriteLine("=========================================================");
                        Console.WriteLine($">>>>>>> Pedreira: {origem[i]} <<<<<<<\n");                      // Lista a pedreira do bloco
                        Console.WriteLine($"Tipo - {tipo[i]}");                                             // Lista o tipo do bloco
                        Console.WriteLine($"Nome - {nome[i]}");                                             // Lista o nome do bloco
                        Console.WriteLine($"Número - {numero[i]}");                                         // Lista o número do bloco
                        Console.WriteLine($"Medida - {medida[i]}m³");                                       // Lista a medida do bloco
                        Console.WriteLine($"Valor de compra - R${valorcompra[i]}");                         // Lista o valor de compra do bloco
                        Console.WriteLine($"Valor de venda - R${valorvenda[i]}");                           // Lista o valor de venda do bloco
                        Console.WriteLine($"Descrição - {descricao[i]}");                                   // Lista a descrição do bloco
                        Console.WriteLine("=========================================================");
                    }
                }
            }


        }

        private static void Sair()                                                                                  // Função de sair
        {
            Console.Clear();                                                                                        // Limpa tudo escrito antes
            Console.WriteLine("Encerrando sistema...");
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();                                                                                      // Comando para apertar qualquer tecla para continuar
            Console.Clear();                                                                                        // Limpa tudo escrito antes
            Console.WriteLine("Obrigado por entrar na Max Rochas e Produtos Ornamentais.\nVolte sempre :D\n\n");
        }
    }
}


