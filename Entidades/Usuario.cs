using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Entidades
{
    public class Usuario
    {
        // na pasta entidades é onde fica a nossas classes de negocios

        // key
        [Key]
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
