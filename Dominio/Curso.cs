using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Curso
    {
        public int CursoId { get; set; }    
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }  
        public byte[] FotoPortada { get; set; }

        //Relacion 1 a 1
        public Precio PrecioPromocion { get; set; }
        //Relacion 1 a n
        public ICollection<Comentario> ComentarioLista { get; set; }
        //Relacion n a n
        public ICollection<CursoInstructor> InstructorLinea { get; set; }
    
    }
}
