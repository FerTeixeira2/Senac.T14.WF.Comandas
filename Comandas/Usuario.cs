using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;

namespace Comandas
{
    public class Usuario
    {
        //propriedades da classe 
        //counas da tabela Uusuario
        [Key] //chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //significa auto incremento
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
