using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abaco.Models
{
    [Table("Usuario")]
   public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [MaxLength (50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Apellido { get; set; }

        [MaxLength(50)]
        public string Zona { get; set; }

        [MaxLength(15)]
        public string Numero { get; set; }

        [MaxLength(50)]
        public string Password { get; set;}

        [MaxLength(50), Unique]
        public string Correo { get; set;}

        public bool Activo { get; set; }



    }
}
