using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVendas.Entidades
{
    public class Venda
    {
        [Key]
        public int? Codigo { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey("Cliente")]//aqui especificando de aonde vem a chave estrangeira, no nosso caso, esta vindo da tabela Cliente
        public int CodigoCliente { get; set; }

        public decimal Total { get; set; }

        public Cliente Cliente { get; set; }
    }
}
