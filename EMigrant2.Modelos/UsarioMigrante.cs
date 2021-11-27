using System;
using System.ComponentModel.DataAnnotations;

namespace EMigrant2.Modelos
{
    public class UsuarioMigrante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Tipo de documento")]
        public string TipoDeDocumento { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nro. de documento")]
        public string NumeroDeDocumento { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Pais de origen")]
        public string PaisDeOrigen { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.Date)]
        [Display(Name = "FechaDeNacimiento")]
        public DataType FechaDeNacimiento { get; set; }

        [MaxLength(50)]
        [Display(Name = "Correo electronico")]
        public string Correo { get; set; }

        [MaxLength(50)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [MaxLength(50)]
        [Display(Name = "Direccion Actual")]
        public string DireccionActual { get; set; }

        [MaxLength(50)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [MaxLength(50)]
        [Display(Name = "Situacion Laboral")]
        public string SituacionLaboral { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
