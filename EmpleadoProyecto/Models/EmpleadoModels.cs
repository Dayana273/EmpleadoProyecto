using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpleadoProyecto.Models
{
    public class EmpleadoModels
    {



        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(200)]
        public int Nombre { get; set; }

        [MaxLength(200)]
        public string Apellidos { get; set; }

        [MaxLength(200)]
        public string  Edad { get; set; }

        [MaxLength(20)]
        public string   Genero { get; set; }
        [MaxLength(100)]
        public string Direccion { get; set;}
        [MaxLength(12)]    
        public string Telefono { get; set; }    
    }
}
