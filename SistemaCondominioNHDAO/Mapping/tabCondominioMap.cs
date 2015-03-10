using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemaCondominioNHENT;

namespace SistemaCondominioNHDAO.Mapping
{
    public class tabCondominioMap : ClassMap<tabCondominioNH>
    {
        public tabCondominioMap()
        {
            Id(c => c.id);
            Map(c => c.id_Cliente);
            Map(c => c.id_AlaQ);
            Map(c => c.dataEntrada);
            Map(c => c.tempo);
            Map(c => c.dt_Cadastro);
            Map(c => c.user_cadastro);
            Table("tabCondominio");
        }
    }
}
