using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public class Pedido
    {
    
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Item { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Id_vendedor { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public StatusPedidos StatusPedido { get; set; }
    

    }
}
