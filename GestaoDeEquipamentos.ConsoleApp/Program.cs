using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static int cont_equipamentos = 0;
        static int cont_chamados = 0;
        static int[] ids_equipamentos = new int[1000];
        static void Main(string[] args)
        {
            String[] nomes_equipamentos = new string[1000];
            decimal[] precos_equipamentos = new decimal[1000];
            int[] numeros_serie = new int[1000];
            String[] datas_fabricacao = new string[1000];
            String[] nomes_fabricantes = new string[1000];

            String[] titulo_chamado = new string[1000];
            String[] descricao_chamado = new String[1000];
            String[] equipamento_chamado = new String[1000];
            String[] data_abertura_chamado = new string[1000];

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
                    VerificaOpcaoControleEquipamentos(nomes_equipamentos, precos_equipamentos, numeros_serie, datas_fabricacao, nomes_fabricantes, opcao_controle_equipamentos);
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
            Console.WriteLine("[1] Registrar chamado");
            Console.WriteLine("[2] Vizualizar todos chamados");
            Console.WriteLine("[3] Editar chamados");
            Console.WriteLine("[4] Excluir chamados");
            Console.WriteLine("[s] Sair Controle de Chamados");
            opcao_controle_chamados = Convert.ToChar(Console.ReadLine());
            return opcao_controle_chamados;
        }
        #endregion

        #region Método Verificar Opções Menu
        static void VerificaOpcaoControleEquipamentos(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante, char opcao_controle_equipamentos)
        {
            switch (opcao_controle_equipamentos)
            {
                case '1':
                    InserirTituloLimpar("Regitrar Equipamento\n");
                    RegistrarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '2':
                    InserirTituloLimpar("Vizualizar Equipamento\n");
                    VizualizarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '3':
                    InserirTituloLimpar("Editar Equipamento\n");
                    EditarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '4':
                    InserirTituloLimpar("Excluir Equipamento\n");
                    ExcluirEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
            }
        }
        static void VerificaOpcaoControleChamados(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado, char opcao_controle_chamados)
        {
            switch (opcao_controle_chamados)
            {
                case '1':
                    RegistrarChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '2':
                    VizualizarChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '3':
                    EditarChamado(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
                case '4':
                    ExcluirChamados(titulo_chamado, descricao_chamado, equipamento_chamado, data_abertura_chamado);
                    break;
            }
        }
        #endregion

        #region Métodos de Controle
        static void RegistrarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            Console.Write("Informe o nome do Equipamento: ");
            string nome = Console.ReadLine();
            nome_equipamento[cont_equipamentos] = nome;

            Console.Write("Informe o preço do Equipamento: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            preco_equipamento[cont_equipamentos] = preco;

            Console.Write("Informe o número de série do Equipamento: ");
            int numeroSerie = Convert.ToInt32(Console.ReadLine());
            numero_serie[cont_equipamentos] = numeroSerie;

            Console.Write("Informe a data de fabricação do Equipamento: ");
            string data = Console.ReadLine();
            data_fabricacao[cont_equipamentos] = data;

            Console.Write("Informe o fabricante do Equipamento: ");
            string fabricante = Console.ReadLine();
            nome_fabricante[cont_equipamentos] = fabricante;

            cont_equipamentos++;
        }
        static void VizualizarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            for (int i = 0; i < cont_equipamentos; i++)
            {
                Console.WriteLine("ID do equipamento: " + i);
                Console.WriteLine("Nome do equipamento: " + nome_equipamento[i]);
                Console.WriteLine("Preço do equipamento: " + preco_equipamento[i]);
                Console.WriteLine("Número de série do equipamento: " + numero_serie[i]);
                Console.WriteLine("Data de fabricação do equipamento: " + data_fabricacao[i]);
                Console.WriteLine("Nome fabricante equipamento: " + nome_fabricante[i]);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        static void EditarEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            Console.Write("Informe o ID de um equipamento a ser editado: ");
            int id_usuario = Convert.ToInt32(Console.ReadLine());
            ids_equipamentos[cont_equipamentos] = id_usuario;

            Console.WriteLine("Informe os novos dados do Equipamento com o ID " + id_usuario);

            if (id_usuario == ids_equipamentos[cont_equipamentos])
            {
                Console.Write("Informe o novo nome do Equipamento: ");
                string nome = Console.ReadLine();
                nome_equipamento[cont_equipamentos - 1] = nome;

                Console.Write("Informe o novo preço do Equipamento: ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());
                preco_equipamento[cont_equipamentos - 1] = preco;

                Console.Write("Informe o novo número de série do Equipamento: ");
                int numeroSerie = Convert.ToInt32(Console.ReadLine());
                numero_serie[cont_equipamentos - 1] = numeroSerie;

                Console.Write("Informe o nova data de fabricação do Equipamento: ");
                string data = Console.ReadLine();
                data_fabricacao[cont_equipamentos - 1] = data;

                Console.Write("Informe o novo nome do fabricante do Equipamento: ");
                string fabricante = Console.ReadLine();
                nome_fabricante[cont_equipamentos - 1] = fabricante;
            }  
        }
        static void ExcluirEquipamento(string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            Console.Write("Informe o ID de um equipamento a ser excluído: ");
            int id_usuario = Convert.ToInt32(Console.ReadLine());
            ids_equipamentos[cont_equipamentos] = id_usuario;

            if (id_usuario == ids_equipamentos[cont_equipamentos])
            {
                
            }
        }
        #endregion

        #region Métodos de Chamado
        static void RegistrarChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Registrar chamado\n");

            Console.Write("Informe o título do chamado: ");
            string titulo = Console.ReadLine();
            titulo_chamado[cont_equipamentos] = titulo;

            Console.Write("Informe a descrição do chamado: ");
            string descricao = Console.ReadLine();
            descricao_chamado[cont_equipamentos] = descricao;

            Console.Write("Informe o ID do equipamento a ser chamado: ");
            int id_usuario = Convert.ToInt32(Console.ReadLine());
            int[] ids = new int[1000];

            Console.Write("Data de abertura do chamado: ");
            string data = Console.ReadLine();
            data_abertura_chamado[cont_equipamentos] = data;

            cont_chamados++;
            Console.ReadKey();
        }
        static void VizualizarChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Vizualizar Chamado\n");

            for (int i = 0; i < cont_chamados; i++)
            {
                Console.WriteLine("ID do chamado: " + i);
                Console.WriteLine("Título do chamado: " + titulo_chamado[i]);
                Console.WriteLine("Descrição do chamado: " + descricao_chamado[i]);
                Console.WriteLine("Equipamento do chamado: " + equipamento_chamado[i]);
                Console.WriteLine("Data de abertura do chamado: " + data_abertura_chamado[i]);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
        static void EditarChamado(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Editar Chamado\n");
        }
        static void ExcluirChamados(string[] titulo_chamado, string[] descricao_chamado, string[] equipamento_chamado, string[] data_abertura_chamado)
        {
            InserirTituloLimpar("Excluir Chamado\n");
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