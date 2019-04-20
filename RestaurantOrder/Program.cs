using System;
namespace RestaurantOrder.Classes
{

    // INICIANDO PROGRAMA KISS = KEEP IT, SIMPLE STUPID = Mantenha isso estupidamente Simples!!!
    class Program
    {
        static void Main(string[] args)
        {
            string c = "";

            {
                // INICIANDO A CONDICAO DE WHILE, ENQUANTO ELE FOR DIFERENTE DE `N`, SERA EXECUTADO
                while (c != "n")
                {
                    Console.WriteLine("Entrada: ");
                    //Lendo a entrada
                    string entrada = Console.ReadLine();

                    //INSTANCIANDO A CLASSE MenuService E trazendo o MENU CriarMENU(entrada) que leu anteriormente 
                    MenuService menuService = new MenuService();
                    Menu menu = menuService.criarMenu(entrada);

                    // Trazendo o menuService, a parte de Validar o menu
                    string saida = menuService.validar(menu);
                    Console.WriteLine(saida);
                    // Verificando se C (contador eh != N, pois se for, ele continuará executando
                    Console.WriteLine("\nDeseja continuar? sim = s, nao = n");
                    c = Console.ReadLine();
                    Console.Clear();

                }
            }

        }
    }
}
