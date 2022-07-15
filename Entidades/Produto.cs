using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVendas.Entidades
{
    public class Produto
    {
        [Key]
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }

        public decimal Valor { get; set; }

        [ForeignKey("Categoria")]//aqui especificando de aonde vem a chave estrangeira, no nosso caso, esta vindo da tabela Categoria
        public int CodigoCategoria { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Venda> Vendas { get; set; }

    }
}
