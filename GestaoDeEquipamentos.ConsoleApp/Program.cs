using System;

namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MenuOpcoes();
            } while (true);
            
        }

    #region Métodos do Menu
        static void MenuOpcoes()
        {
            Console.Write("[1] Registrar equipamentos: ");
            Console.Write("[2] Visualizar todos os equipamentos registrados: ");
            Console.Write("[3] Editar um equipamento: ");
            Console.Write("[4] Excluir um equipamento já registrado: ");
            Console.Write("[5] Excluir um equipamento já registrado: ");
        }

        #endregion

    #region Métodos de Controle
        #endregion

    #region Métodos de Chamado
        #endregion
    }
}
