using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Precio
    {
        public int PrecioId { get; set; }   
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set;}
        public int CursoId { get; set; }
        //Relacion 1 a 1
        public Curso Curso { get; set; }    


    }
}
