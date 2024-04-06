using System.ComponentModel.DataAnnotations;

namespace InfnetMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve conter de 10 a 11 dígitos numéricos.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de email inválido.")]
        public string Email { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        // Foreign key
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "O departamento é obrigatório.")]
        public int DepartamentoId { get; set; }

        // Navigation property
        public Departamento Departamento { get; set; }
    }
}
