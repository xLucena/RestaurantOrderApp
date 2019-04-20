using System;
using System.Collections;
namespace RestaurantOrder.Classes
{
    class MenuService
    {
        //Criando o metodo da classe MenuService
        public Menu criarMenu(string entrada)
        {
            string[] valores = entrada.Split(",");

            //Instanciando Classe e informando que vamos  utilizar um array de valores começando do 0
            Menu menu = new Menu();
            menu.Horario = valores[0];
            //instanciando o menu e utilizando o array e no for esta informando que os valores digitados, utilizando o Length para descobrir quantos elementos o array possui
            menu.Itens = new ArrayList();
            for (int i = 0; i < valores.Length - 1; i++)
            {
                //add os itens com i+1 por conta do periodo na posicao que vai ficar 0, serao convertidos o que o usuario digitou e colocado na array

                menu.Itens.Add(Int32.Parse(valores[i + 1]));
            }
            // retornando o menu
            return menu;
        }
        //Metodo construtor da classe Menu
        public string validar(Menu menu)
        {
            string horario = menu.Horario;
            int qtdeCafe = 0;
            int qtdBatata = 0;
            string entrada = "";
            string bebida = "";
            string sobremesa = "";
            string lado = "";
            //int item in menu.Itens é do Array, e dependendo d
            foreach (int item in menu.Itens)
            {
                switch (item)
                {
                    case 1:
                        if (entrada != "" || entrada != "manhã" || entrada != "noite")
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

            // está sendo utilizado no Program, para chamar a condições de saida(do que vai imprimir na tela)
            string saida = entrada;
            // se a qtde batata >1 entao vai imprimir entre (qtde x) pro cafe tambem
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

