
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercício_C_
{
    internal class Classe_Usuario
    {
        public class Usuario
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Required]
            public string Nome { get; set; } = string.Empty;
            [Required]
            public string Email { get; set; } = string.Empty;
            [Required]
            public string Senha { get; set; } = string.Empty;
        }
    }
}
