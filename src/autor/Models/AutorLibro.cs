using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace autor.Models
{
    public class AutorLibro
    {
        public int AutorLibroId {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public Nullable<DateTime> FechaNacimiento {get; set;}
        // Un autor puede tener 1 o varios grados academicos
        public ICollection<GradoAcademico> ListaGradoAcademico {get; set;}
        // 
        public string AutorLibroGuid {get; set;}
    }
}