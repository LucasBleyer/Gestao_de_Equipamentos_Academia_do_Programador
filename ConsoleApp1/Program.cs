using System;

namespace ConsoleApp1
{
    internal class Class1
    {
        #region variáveis equipamentos
        static string[] nomesEquipamento = new string[10];
        static decimal[] precosEquipamento = new decimal[10];
        static string[] numerosSerieEquipamento = new string[10];
        static string[] fabricantesEquipamento = new string[10];
        static string[] datasFabricacaoEquipamento = new string[10];

        static int posicaoEquipamento = 0;
        #endregion

        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoSubMenu = ApresentarMenuEquipamentos();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoEquipamento();

                    else if (opcaoSubMenu == "2")
                        VisualizarEquipamentos();

                    else if (opcaoSubMenu == "3")
                        EditarEquipamentos();

                    else if (opcaoSubMenu == "4")
                        ExcluirEquipamentos();
                }
                else if (opcao == "2")
                {
                    string opcaoSubMenu = ApresentarMenuChamados();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoChamado();

                    else if (opcaoSubMenu == "2")
                        VisualizarChamados();

                    else if (opcaoSubMenu == "3")
                        EditarChamados();

                    else if (opcaoSubMenu == "4")
                        ExcluirChamados();
                }

                Console.ReadLine();
            }
        }

        #region Controle de Chamados
        private static void ExcluirChamados()
        {
            throw new NotImplementedException();
        }

        private static void EditarChamados()
        {
            throw new NotImplementedException();
        }

        private static void VisualizarChamados()
        {
            throw new NotImplementedException();
        }

        private static void InserirNovoChamado()
        {
            throw new NotImplementedException();
        }

        private static string ApresentarMenuChamados()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Chmados 1.0");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir novo Chamado");
            Console.WriteLine("Digite 2 para Visualizar Chamados");
            Console.WriteLine("Digite 3 para Editar um Chamado");
            Console.WriteLine("Digite 4 para Exluir um Chamado");

            Console.WriteLine("Digite s para Sair");

            string opcaoSubMenu = Console.ReadLine();

            return opcaoSubMenu;
        }

        #endregion

        #region Cadastro Equipamentos
        private static void ExcluirEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Excluindo Equipamentos:\n");

            Console.ReadLine();
            //código que exlcui...

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento excluido com sucesso :-)");
            Console.ResetColor();
        }

        private static void EditarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Editando Equipamentos:\n");

            Console.ReadLine();
            //código que edita...

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento editado com sucesso :-)");
            Console.ResetColor();
        }

        static void VisualizarEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Visualizando Equipamentos:\n");

            for (int posicao = 0; posicao < 10; posicao++)
            {
                if (nomesEquipamento[posicao] != null)
                {
                    Console.WriteLine("Nome:\t\t" + nomesEquipamento[posicao]);
                    Console.WriteLine("Preço:\t\t" + precosEquipamento[posicao]);
                    Console.WriteLine("Número de Série:\t" + numerosSerieEquipamento[posicao]);
                    Console.WriteLine("Data Fabricação:\t" + datasFabricacaoEquipamento[posicao]);
                    Console.WriteLine("Fabricante:\t\t" + fabricantesEquipamento[posicao]);
                    Console.WriteLine();
                }
            }
        }

        static void InserirNovoEquipamento()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Inserindo um novo Equipamento:\n");

            Console.Write("Digite o nome do Equipamento: ");
            string nome = Console.ReadLine();
            nomesEquipamento[posicaoEquipamento] = nome;

            Console.Write("Digite o preço do Equipamento: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            precosEquipamento[posicaoEquipamento] = preco;

            Console.Write("Digite o número de série do Equipamento: ");
            string numeroSerie = Console.ReadLine();
            numerosSerieEquipamento[posicaoEquipamento] = numeroSerie;

            Console.Write("Digite a data de fabricação do Equipamento: ");
            string data = Console.ReadLine();
            datasFabricacaoEquipamento[posicaoEquipamento] = data;

            Console.Write("Digite o fabricante do Equipamento: ");
            string fabricante = Console.ReadLine();
            fabricantesEquipamento[posicaoEquipamento] = fabricante;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEquipamento cadastrado com sucesso :-)");
            Console.ResetColor();

            posicaoEquipamento++;
        }

        static string ApresentarMenuEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir novo Equipamento");
            Console.WriteLine("Digite 2 para Visualizar Equipamentos");
            Console.WriteLine("Digite 3 para Editar um Equipamento");
            Console.WriteLine("Digite 4 para Exluir um Equipamento");

            Console.WriteLine("Digite s para Sair");

            string opcaoSubMenu = Console.ReadLine();

            return opcaoSubMenu;
        }
        #endregion

        static string ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Manutenção de Equipamentos 1.0");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para Cadastro de Equipamentos");
            Console.WriteLine("Digite 2 para Controle de Chamados");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

    }
}
