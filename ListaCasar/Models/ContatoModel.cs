using System.ComponentModel.DataAnnotations;

namespace ListaCasar.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do convidado")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do convidado")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do convidado")]
        [Phone(ErrorMessage = "O celular informado não é válido!")]
        public string Celular { get; set; }
    }
}
