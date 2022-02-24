using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
    #region Declaração de Variáveis
            char opcao;
    #endregion

            MostrarOpcoes(out opcao);      
        }

    #region Métodos do Menu
        static void MostrarOpcoes(out char opcao)
        {
            Console.WriteLine("[1] Registrar equipamentos: ");
            Console.WriteLine("[2] Visualizar todos os equipamentos registrados: ");
            Console.WriteLine("[3] Editar um equipamento: ");
            Console.WriteLine("[4] Excluir um equipamento já registrado: ");
            opcao = Convert.ToChar(Console.ReadLine());
        }

        #endregion

    #region Métodos de Controle
        #endregion

    #region Métodos de Chamado
        #endregion
    }
}
