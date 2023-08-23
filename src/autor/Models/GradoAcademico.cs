using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autor.Models
{
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string Nombre { get; set; }
        public string Centroacademico { get; set; }
        public Nullable<DateTime> FechaGrado { get; set; }
        public int AutorLibroId { get; set; }
        public AutorLibro AutorLibro { get; set; }
        // 
        public string GradoAcademicoGuid {get; set;}
    }
}