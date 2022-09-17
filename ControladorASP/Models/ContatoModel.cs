using System.ComponentModel.DataAnnotations;

namespace ControladorASP.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o Celular")]
        [Phone(ErrorMessage = "Digite um telefone válido")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }
    }
}
