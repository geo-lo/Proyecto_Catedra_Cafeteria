using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.ClasesNuevas
{
    public class ColaPedidos
    {
        public Nodo_ColaPedidos Primero;
        public Nodo_ColaPedidos Ultimo;

        public void Encolar(Pedido p)
        {
            Nodo_ColaPedidos nuevo = new Nodo_ColaPedidos(p);
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
        public Pedido Desencolar()
        {
            if (Primero == null)

                return null;
            Pedido pedidoDesencolado = Primero.PedidoGuardado;
            Primero = Primero.siguiente;
            if (Primero == null)
                Ultimo = null;
            return pedidoDesencolado;
        }
    }
}
