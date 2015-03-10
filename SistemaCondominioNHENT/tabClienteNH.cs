using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCondominioNHENT
{
    public class tabClienteNH
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        //public virtual string sexo { get; set; }
        public virtual string cpf { get; set; }
        public virtual DateTime dt_nascimento { get; set; }
        public virtual string email { get; set; }
        public virtual string obs { get; set; }
        public virtual string escolaridade { get; set; }
        public virtual string sitOcupacional { get; set; }
        public virtual DateTime dt_cadastro { get; set; }
        public virtual string user_cadastro { get; set; }
    }
}
