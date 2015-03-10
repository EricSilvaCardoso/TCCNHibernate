using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCondominioNHENT
{
    public class tabTelefoneNH
    {
        public virtual int id { get; set; }
        public virtual int id_cliente { get; set; }
        public virtual string telefone { get; set; }
    }
}
