using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public enum StatusPedidos
    {

        Pagamento_Aprovado,
        Aguardando_Pagamento,
        Entregue,
        Enviado_Para_Transportadora,
        Cancelado

    }
}