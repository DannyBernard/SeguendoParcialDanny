using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialDanny.Entidades
{
   public class Meta
    {
        public int MetaId { get; set; }
        public string Descripcion { get; set; }
        public float Cuotas { get; set; }

        public Meta()
        {
            MetaId = 0;
            Descripcion = string.Empty;
            Cuotas = 0;
        }
    }
}
