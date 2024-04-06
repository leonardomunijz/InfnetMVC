using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do departamento é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O local do departamento é obrigatório.")]
        public string Local { get; set; }

        // Navigation property
        public List<Funcionario> Funcionarios { get; set; }
    }
}
