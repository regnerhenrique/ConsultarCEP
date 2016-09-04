using System.ComponentModel.DataAnnotations;

namespace WebServiceTeste.Models
{
    public class Endereco
    {
        public string Descricao { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "Permitido apenas 9 caracteres")]
        [MinLength(9, ErrorMessage = "Permitido apenas 9 caracteres")]
        public string Cep { get; set; }
    }
}