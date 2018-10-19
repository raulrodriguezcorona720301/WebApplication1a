using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebApplication1.Models
{
    [Bind (Include = "UsuarioSup, PasswordSup, tokenId, fn, yesNo, source")]
    public class EntLoginVm
    {
        [Required(ErrorMessage = "Correo requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Formato Invalido")]
        [MinLength(1)]
        [MaxLength(250)]
        [StringLength(250, MinimumLength =1)]
        public string UsuarioSup { get; set; }

        [Required(ErrorMessage ="Password requerido")]
        [MinLength(1)]
        [MaxLength(20)]
        [StringLength(20, MinimumLength =1)]
        [RegularExpression(@"^[0-9a-zA-Z_-]*$", ErrorMessage ="Password incorrecto")]
        public string PasswordSup { get; set; }

        [Required]
        [RegularExpression(@"^[0-9a-zA-Z-]*$", ErrorMessage ="Cadena Invalida")]
        public string tokenId { get; set; }

        [Required]
        public string fn { get; set; }

        [Required]
        public string yesNo { get; set; }

        public string source { get; set; }
    }
}