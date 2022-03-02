using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static int posicao_equipamento = 0;
        static void Main(string[] args)
        {
        //variáveis controle de equipamentos
            String[] nome_equipamento = new string[1000];
            decimal[] preco_equipamento = new decimal[1000];
            int[] numero_serie = new int[1000];
            String[] data_fabricacao = new string[1000];
            String[] nome_fabricante = new string[1000];

        //variáveis controle de chamados
            String[] titulo_chamado = new string[1000];
            String[] descricao_chamado = new String[1000];
            String[] equipamento_chamado = new String[1000];
            String[] data_abertura_chamado = new string[1000];

        //menus
            while (true)
            {
                InserirTituloLimpar("Manutenção de Equipamentos");
                char opcao_menu_principal = MenuPrincipal();

                if (opcao_menu_principal == 's')
                {
                    break;
                }

                if (opcao_menu_principal == '1')
                {
                    InserirTituloLimpar("Controle de Equipamentos");
                    char opcao_controle_equipamentos;
                    MenuOpcoesControleEquipamentos(out opcao_controle_equipamentos);
                    VerificaOpcaoControleEquipamentos(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante, opcao_controle_equipamentos);
                    if (opcao_controle_equipamentos == 's')
                    {
                        continue;
                    }
                }
                else if (opcao_menu_principal == '2')
                {
                    InserirTituloLimpar("Controle de Chamados");
                    char opcao_controle_chamados;
                    MenuOpcoesControleChamados(out opcao_controle_chamados);
                    VerificaOpcaoControleChamados(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado, opcao_controle_chamados);
                    if (opcao_controle_chamados == 's')
                    {
                        continue;
                    }
                }
            }
        }

        #region Métodos do Menu
        static char MenuPrincipal()
        {
            char opcao_menu_principal;
            Console.WriteLine("[1] Controle de Equipamentos");
            Console.WriteLine("[2] Controle de Chamados");
            Console.WriteLine("[s] Sair");
            opcao_menu_principal = Convert.ToChar(Console.ReadLine().ToLower());
            return opcao_menu_principal;
        }
        static char MenuOpcoesControleEquipamentos(out char opcao_controle_equipamentos)
        {
            Console.WriteLine("[1] Registrar equipamentos");
            Console.WriteLine("[2] Visualizar todos os equipamentos registrados");
            Console.WriteLine("[3] Editar um equipamento");
            Console.WriteLine("[4] Excluir um equipamento já registrado");
            Console.WriteLine("[s] Sair Controle de Equipamentos");
            opcao_controle_equipamentos = Convert.ToChar(Console.ReadLine());
            return opcao_controle_equipamentos;
        }
        static char MenuOpcoesControleChamados(out char opcao_controle_chamados)
        {
            Console.WriteLine("[1] Título do Chamado");
            Console.WriteLine("[2] Descrição do Chamado");
            Console.WriteLine("[3] Equipamento");
            Console.WriteLine("[4] Data de Abertura");
            Console.WriteLine("[s] Sair Controle de Chamados");
            opcao_controle_chamados = Convert.ToChar(Console.ReadLine());
            return opcao_controle_chamados;
        }
        static void VerificaOpcaoControleEquipamentos(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante, char opcao_controle_equipamentos)
        {
            switch (opcao_controle_equipamentos)
            {
                case '1':
                    RegistrarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '2':
                    VizualizarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '3':
                    EditarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '4':
                    ExcluirEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
            }
        }
        static void VerificaOpcaoControleChamados(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado, char opcao_controle_chamados)
        {
            switch (opcao_controle_chamados)
            {
                case '1':
                    TituloChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '2':
                    DescricaoChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '3':
                    EquipamentoChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '4':
                    DataAberturaChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
            }
        }
        #endregion

        #region Métodos de Controle
        static void RegistrarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            InserirTituloLimpar("Regitrar Equipamento");

            Console.Write("Nome do Equipamento: ");
            string nome = Console.ReadLine();
            nome_equipamento[posicao_equipamento] = nome;

            Console.Write("Digite o preço do Equipamento: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            preco_equipamento[posicao_equipamento] = preco;

            Console.Write("Digite o número de série do Equipamento: ");
            int numeroSerie = Convert.ToInt32(Console.ReadLine());
            numero_serie[posicao_equipamento] = numeroSerie;

            Console.Write("Digite a data de fabricação do Equipamento: ");
            string data = Console.ReadLine();
            data_fabricacao[posicao_equipamento] = data;

            Console.Write("Digite o fabricante do Equipamento: ");
            string fabricante = Console.ReadLine();
            nome_fabricante[posicao_equipamento] = fabricante;

            posicao_equipamento++;

        }
        static void VizualizarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            InserirTituloLimpar("Vizualizar Equipamento");

            for (int i = 0; i < 10; i++)
            {
                    Console.WriteLine("Nome do equipamento: " + nome_equipamento[i]);
                    Console.WriteLine("Preço do equipamento: " + preco_equipamento[i]);
                    Console.WriteLine("Número de Série do equipamento: " + numero_serie[i]);
                    Console.WriteLine("Data de Fabricação do equipamento: " + data_fabricacao[i]);
            }
        }
        static void EditarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            InserirTituloLimpar("Editar Equipamento");
        }
        static void ExcluirEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            InserirTituloLimpar("Excluir Equipamento");
        }
        #endregion

        #region Métodos de Chamado

        static void TituloChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Título do Chamado");
        }
        static void DescricaoChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Descrição do Chamado");
        }
        static void EquipamentoChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Equipamento do Chamado");
        }
        static void DataAberturaChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Data de Abertura Chamado");
        }

        #endregion

        #region Métodos Auxiliares
        static void InserirTituloLimpar(string mensagem)
        {
            Console.Clear();
            Console.WriteLine(mensagem);
        }
        #endregion
    }
}