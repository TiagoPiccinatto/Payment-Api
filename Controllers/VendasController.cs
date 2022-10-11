using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers
{
    [Route("[controller]")]
    public class VendasController : Controller
    {
        private readonly Vendas _context;

        public VendasController(Vendas context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Incluir(Pedido venda)
        {
            if(venda.Item==0)

            return BadRequest(new { Erro = "O pedido precisa ter pelo menos um item" });


            _context.Add(venda);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, venda);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var Pedido = _context.Pedidos.Find(id);

            if(Pedido == null)

                return NotFound();

            return Ok(Pedido);

        }

        [HttpPatch("{id}")]
        public IActionResult Atualizar(int id, Pedido venda )
        {
            var vendaBanco = _context.Pedidos.Find(id);

            if(vendaBanco == null)
                return NotFound();

            vendaBanco.StatusPedido = venda.StatusPedido;

            _context.Pedidos.Update(vendaBanco);
            _context.SaveChanges();

            return Ok(vendaBanco);
        }




    }
}