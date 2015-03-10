using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemaCondominioNHENT;

namespace SistemaCondominioNHDAO.Mapping
{
    public class tabClienteMap : ClassMap<tabClienteNH>
    {
        public tabClienteMap()
        {
            Id(c => c.id);
            Map(c => c.nome);
            Map(c => c.sexo);
            Map(c => c.cpf);
            Map(c => c.dt_nascimento);
            Map(c => c.email);
            Map(c => c.obs);
            Map(c => c.escolaridade);
            Map(c => c.sitOcupacional);
            Map(c => c.dt_cadastro);
            Map(c => c.user_cadastro);
            Table("tabCliente");
        }
    }
}
