using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Pedido
    {
        public Pedido(int id = 0, int clienteID = 0, char status = ' ', bool entrega = false, decimal valorTotal = 0) 
        {
            this.ID = id;
            this.ClienteID = clienteID;
            this.Status = status;
            this.Entrega = entrega;
            this.ValorTotal = valorTotal;
            this.DataPedido = DateTime.Now;
        }
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public char Status { get; set; }
        public bool Entrega { get; set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataPedido { get; set; }

    }


    public class PedidoDAO
    {
        public PedidoDAO()
        {
            
        }
    }
}
