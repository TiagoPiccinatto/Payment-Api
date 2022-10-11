using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Context
{
    public class Vendas : DbContext
    {
        public Vendas(DbContextOptions <Vendas> options) : base(options)
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}