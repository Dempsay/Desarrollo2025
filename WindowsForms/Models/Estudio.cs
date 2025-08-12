using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    public class Estudio
    {
        public int? id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int? ActorId { get; set; }
        public Actor Actor { get; set; }
        public bool Eliminado { get; set; }


    }
}
