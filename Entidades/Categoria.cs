using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Entidades
{
    public class Categoria
    {
        [Key]
        public int? Codigo { get; set; }
        public string Descricao { get; set; }

        //ICollection<Produto> diz que temos uma lista de produtos(coleção)
        public ICollection<Produto> Produtos { get; set; }
       
    }
}
