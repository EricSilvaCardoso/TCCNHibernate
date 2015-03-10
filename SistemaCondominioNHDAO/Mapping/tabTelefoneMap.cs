using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemaCondominioNHENT;

namespace SistemaCondominioNHDAO.Mapping
{
    public class tabTelefoneMap : ClassMap<tabTelefoneNH>
    {
        public tabTelefoneMap()
        {
            Id(c => c.id);
            Map(c => c.id_cliente);
            Map(c => c.telefone);
            Table("tabTelefone");
        }
    }
}
