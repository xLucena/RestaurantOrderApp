using System.Collections;
namespace RestaurantOrder
{
    class Menu
    {
        private ArrayList itens = new ArrayList();
        public ArrayList Itens
        {
            get { return itens; }

            set { itens = value; }

        }

        private string horario;
        public string Horario
        {

            get { return horario; }

            set { horario = value; }
        }
    }

}
