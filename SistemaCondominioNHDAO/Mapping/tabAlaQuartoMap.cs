using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemaCondominioNHENT;

namespace SistemaCondominioNHDAO.Mapping
{
    public class tabAlaQuartoMap : ClassMap<tabAlaQuartoNH>
    {
        public tabAlaQuartoMap()
        {
            Id(c => c.id);
            Map(c => c.id_ala);
            Map(c => c.Nquarto);
            Table("tabAlaQuarto");
        }
    }
}
