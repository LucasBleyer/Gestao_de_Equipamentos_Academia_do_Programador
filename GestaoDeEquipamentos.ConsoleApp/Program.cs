using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static int cont_equipamentos = 0;
        static int cont_chamados = 0;
        static void Main(string[] args)
        {
            String[] nomes_equipamentos = new string[1000];
            decimal[] precos_equipamentos = new decimal[1000];
            int[] numeros_serie = new int[1000];
            String[] datas_fabricacao = new string[1000];
            String[] nomes_fabricantes = new string[1000];
            int[] ids_equipamentos = new int[1000];

            String[] titulo_chamado = new string[1000];
            String[] descricao_chamado = new String[1000];
            String[] data_abertura_chamado = new string[1000];
            int[] ids_chamados = new int[1000];

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
                    VerificaOpcaoControleEquipamentos(ids_chamados, ids_equipamentos, nomes_equipamentos, precos_equipamentos, numeros_serie, datas_fabricacao, nomes_fabricantes, opcao_controle_equipamentos);
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
                    VerificaOpcaoControleChamados(ids_equipamentos, ids_chamados, titulo_chamado, descricao_chamado, data_abertura_chamado, opcao_controle_chamados);
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
            do
            {
                InserirTituloLimpar("Gestão de Equipamentos e Chamados\n");
                Console.WriteLine("[1] Controle de Equipamentos");
                Console.WriteLine("[2] Controle de Chamados");
                Console.WriteLine("[s] Sair");
                opcao_menu_principal = Convert.ToChar(Console.ReadLine().ToLower());
            } while (opcao_menu_principal != '1' && opcao_menu_principal != '2' && opcao_menu_principal != 's');
            return opcao_menu_principal;
        }
        static char MenuOpcoesControleEquipamentos(out char opcao_controle_equipamentos)
        {
            do
            {
                InserirTituloLimpar("Controle de Equipamentos\n");
                Console.WriteLine("[1] Registrar equipamentos");
                Console.WriteLine("[2] Visualizar todos os equipamentos registrados");
                Console.WriteLine("[3] Editar um equipamento");
                Console.WriteLine("[4] Excluir um equipamento já registrado");
                Console.WriteLine("[s] Sair Controle de Equipamentos");
                opcao_controle_equipamentos = Convert.ToChar(Console.ReadLine());
            } while (opcao_controle_equipamentos != '1' && opcao_controle_equipamentos != '2' && opcao_controle_equipamentos != '3' && opcao_controle_equipamentos != '4' && opcao_controle_equipamentos != 's');
            return opcao_controle_equipamentos;
        }
        static char MenuOpcoesControleChamados(out char opcao_controle_chamados)
        {
            do
            {
                InserirTituloLimpar("Controle de Chamados\n");
                Console.WriteLine("[1] Registrar chamado");
                Console.WriteLine("[2] Vizualizar todos chamados");
                Console.WriteLine("[3] Editar chamados");
                Console.WriteLine("[4] Excluir chamados");
                Console.WriteLine("[s] Sair Controle de Chamados");
                opcao_controle_chamados = Convert.ToChar(Console.ReadLine());
            } while (opcao_controle_chamados != '1' && opcao_controle_chamados != '2' && opcao_controle_chamados != '3' && opcao_controle_chamados != '4' && opcao_controle_chamados != 's');
            return opcao_controle_chamados;
        }
        #endregion

        #region Método Verificar Opções Menu
        static void VerificaOpcaoControleEquipamentos(int[] ids_chamados, int[] ids_equipamentos, string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante, char opcao_controle_equipamentos)
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
                    EditarEquipamento(ids_equipamentos, nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
                case '4':
                    InserirTituloLimpar("Excluir Equipamento\n");
                    ExcluirEquipamento(ids_chamados, ids_equipamentos, nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);
                    break;
            }
        }
        static void VerificaOpcaoControleChamados(int[] ids_equipamentos, int[] ids_chamados, string[] titulo_chamado, string[] descricao_chamado, string[] data_abertura_chamado, char opcao_controle_chamados)
        {
            switch (opcao_controle_chamados)
            {
                case '1':
                    InserirTituloLimpar("Registrar chamado\n");
                    RegistrarChamado(ids_equipamentos, titulo_chamado, descricao_chamado, data_abertura_chamado);
                    break;
                case '2':
                    InserirTituloLimpar("Vizualizar Chamado\n");
                    VizualizarChamado(ids_equipamentos, titulo_chamado, descricao_chamado, data_abertura_chamado);
                    break;
                case '3':
                    InserirTituloLimpar("Editar Chamado\n");
                    EditarChamado(ids_equipamentos, ids_chamados, titulo_chamado, descricao_chamado, data_abertura_chamado);
                    break;
                case '4':
                    InserirTituloLimpar("Excluir Chamado\n");
                    ExcluirChamados(ids_chamados, titulo_chamado, descricao_chamado, data_abertura_chamado);
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
            OperacaoEfutuada("Equipamento Registrado");
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
                    Console.WriteLine("Nome fabricante equipamento: " + nome_fabricante[i]+"\n");
                }
            OperacaoEfutuada("Existe(m) " + cont_equipamentos + " equipamento(s) registrado(s)... ");
            Console.Read(); 
        }
        static void EditarEquipamento(int[] ids_equipamentos, string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            VizualizarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);

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
            OperacaoEfutuada("Equipamento Editado");
        }
        static void ExcluirEquipamento(int[] ids_chamados, int[] ids_equipamentos, string[] nome_equipamento, decimal[] preco_equipamento, int[] numero_serie, string[] data_fabricacao, string[] nome_fabricante)
        {
            VizualizarEquipamento(nome_equipamento, preco_equipamento, numero_serie, data_fabricacao, nome_fabricante);

            Console.Write("Informe o ID de um equipamento a ser excluído: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());
            ids_equipamentos[cont_equipamentos] = id_excluir;

            for (int i = 0; i < ids_equipamentos.Length; i++)
            {
                if (id_excluir == ids_equipamentos[i])
                {
                    nome_equipamento[i] = null;
                    preco_equipamento[i] = default;
                    numero_serie[i] = default;
                    data_fabricacao[i] = null;
                    nome_fabricante[i] = null;

                    OperacaoEfutuada("Equipamento Excluído");
                    break;
                }
            }
        }
        #endregion

        #region Métodos de Chamado
        static void RegistrarChamado(int[] ids_equipamentos, string[] titulo_chamado, string[] descricao_chamado, string[] data_abertura_chamado)
        {
            Console.Write("Informe o título do chamado: ");
            string titulo = Console.ReadLine();
            titulo_chamado[cont_chamados] = titulo;

            Console.Write("Informe a descrição do chamado: ");
            string descricao = Console.ReadLine();
            descricao_chamado[cont_chamados] = descricao;

            Console.Write("Informe o ID do equipamento a ser chamado: ");
            int id_usuario = Convert.ToInt32(Console.ReadLine());
            ids_equipamentos[cont_chamados] = id_usuario;

            Console.Write("Data de abertura do chamado: ");
            string data = Console.ReadLine();
            data_abertura_chamado[cont_chamados] = data;

            cont_chamados++;
            OperacaoEfutuada("Chamado Registrado");
        }
        static void VizualizarChamado(int[] ids_equipamentos, string[] titulo_chamado, string[] descricao_chamado, string[] data_abertura_chamado)
        {
            for (int i = 0; i < cont_chamados; i++)
            {
                Console.WriteLine("ID do chamado: " + i);
                Console.WriteLine("Título do chamado: " + titulo_chamado[i]);
                Console.WriteLine("Descrição do chamado: " + descricao_chamado[i]);
                Console.WriteLine("ID do equipamento do chamado: " + ids_equipamentos[i]);
                Console.WriteLine("Data de abertura do chamado: " + data_abertura_chamado[i]);
            }
            OperacaoEfutuada("Existe(m) " + cont_chamados + " chamados(s) registrado(s)...");
            Console.Read();
        }
        static void EditarChamado(int[] ids_equipamentos, int[] ids_chamados, string[] titulo_chamado, string[] descricao_chamado, string[] data_abertura_chamado)
        {
            Console.Write("Informe o ID do chamado a ser editado: ");
            int id_editar = Convert.ToInt32(Console.ReadLine());
            ids_chamados[cont_chamados] = id_editar;

            Console.WriteLine("Informe os novos dados do Chamado com o ID " + id_editar);

            if (id_editar == ids_chamados[cont_chamados])
            {
                Console.Write("Informe o novo título do chamado: ");
                string titulo = Console.ReadLine();
                titulo_chamado[cont_chamados - 1] = titulo;

                Console.Write("Informe a nova descrição do chamado: ");
                string descricao = Console.ReadLine();
                descricao_chamado[cont_chamados - 1] = descricao;

                Console.Write("Informe o ID do equipamento a ser chamado: ");
                int id_usuario = Convert.ToInt32(Console.ReadLine());
                ids_equipamentos[cont_chamados - 1] = id_usuario;

                Console.Write("Informe o nova data de abertura do chamado: ");
                string data = Console.ReadLine();
                data_abertura_chamado[cont_chamados - 1] = data;
            }
            OperacaoEfutuada("Chamado Editado");
        }
        static void ExcluirChamados(int[] ids_chamados, string[] titulo_chamado, string[] descricao_chamado, string[] data_abertura_chamado)
        {
            Console.Write("Informe o ID de um equipamento a ser excluído: ");
            int id_excluir = Convert.ToInt32(Console.ReadLine());
            ids_chamados[cont_equipamentos - 1] = id_excluir;

            for (int i = 0; i < ids_chamados.Length; i++)
            {
                if (id_excluir == ids_chamados[i])
                {
                    titulo_chamado[i] = null;
                    descricao_chamado[i] = default;
                    data_abertura_chamado[i] = default;

                    OperacaoEfutuada("Chamado Excluído");
                    break;
                }
            }
        }
        #endregion

        #region Métodos Auxiliares
        static void InserirTituloLimpar(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        static void OperacaoEfutuada(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        #endregion
    }
}