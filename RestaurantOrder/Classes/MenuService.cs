using System;
using System.Collections;
namespace RestaurantOrder.Classes
{
    class MenuService
    {
        public Menu criarMenu(string entrada)
        {
            string[] valores = entrada.Split(",");

            Menu menu = new Menu();
            menu.Horario = valores[0];

            menu.Itens = new ArrayList();
            for (int i = 0; i < valores.Length - 1; i++)
            {
                menu.Itens.Add(Int32.Parse(valores[i + 1]));
            }

            return menu;
        }

        public string validar(Menu menu)
        {
            string horario = menu.Horario;
            int qtdeCafe = 0;
            int qtdBatata = 0;
            string entrada = "";
            string bebida = "";
            string sobremesa = "";
            string lado = "";

            foreach (int item in menu.Itens)
            {
                switch (item)
                {
                    case 1:
                        if (entrada != "")
                        {
                            entrada = "Erro";
                            break;
                        }
                        entrada = horario == "manhã" ? "ovo" : "bife";
                        break;
                    case 2:
                        if (horario == "noite" && qtdBatata > 1)
                        {
                            lado = "Erro";
                            break;
                        }

                        if (horario == "manhã")
                        {
                            lado = "Torrada";
                        }
                        else
                        {
                            lado = "batata";
                            qtdBatata++;
                        }
                        break;
                    case 3:
                        if (horario != "manhã" && qtdeCafe > 1)
                        {
                            bebida = "Erro";
                            break;
                        }

                        if (horario == "noite")
                        {
                            bebida = "Vinho";
                        }
                        else
                        {
                            bebida = "Café";
                            qtdeCafe++;
                        }
                        break;
                    case 4:
                        sobremesa = horario == "manhã" ? "Erro" : "bolo";
                        break;
                }
            }
            // está sendo utilizado no Program, para chamar a condições
            string saida = entrada;

            saida = saida + ", " + lado;
            if (lado == "batata" && qtdBatata > 1)
            {
                saida = saida + "(" + qtdBatata + "x)";
            }

            if (bebida != "")
            {
                saida = saida + ", " + bebida;
                if (bebida == "Café" && qtdeCafe > 1)
                {
                    saida = saida + "(" + qtdeCafe + "x)";
                }
            }


            if (sobremesa != "")
                saida = saida + ", " + sobremesa;


            return saida;
        }
    }
}

