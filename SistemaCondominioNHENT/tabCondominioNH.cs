using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCondominioNHENT
{
    public class tabCondominioNH
    {
        public virtual int id { get; set; }
        public virtual int id_Cliente { get; set; }
        public virtual int id_AlaQ { get; set; }
        public virtual DateTime dataEntrada { get; set; }
        public virtual string tempo { get; set; }
        public virtual DateTime dt_Cadastro { get; set; }
        public virtual string user_cadastro { get; set; }
    }
}
