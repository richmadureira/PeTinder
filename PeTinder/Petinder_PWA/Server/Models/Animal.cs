using System.ComponentModel.DataAnnotations;

namespace Petinder_PWA.Server.Models
{
    public class Animal : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public SexoAnimal Sexo { get; set; }

        public Porte Porte { get; set; }

        public int Idade { get; set; }
       
    }
}
