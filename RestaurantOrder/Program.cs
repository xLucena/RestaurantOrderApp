using System;
namespace RestaurantOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Entrada: ");
                string entrada = Console.ReadLine();

                MenuService menuService = new MenuService();
                Menu menu = menuService.criarMenu(entrada);
                string saida = menuService.validar(menu);

                Console.WriteLine(saida);




            }

        }

    }
}
