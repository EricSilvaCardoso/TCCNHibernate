using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using SistemaCondominioNHENT;

namespace SistemaCondominioNHDAO.Mapping
{
    public class tabAlaMap : ClassMap<tabAlaNH>
    {
        public tabAlaMap()
        {
            Id(c => c.id);
            Map(c => c.numeroAla);
            Table("tabAla");
        }
    }
}
