using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCondominioDAO;

namespace SistemaCondominioBO
{
    public class tabClienteBO : tabClienteDAO
    {
        private BD_CondominioEntities model = new BD_CondominioEntities();

         public void AlteraDados(tabCliente objdado)
        {
            try
            {
                var gest = (from i in model.tabCliente where i.id == objdado.id select i).FirstOrDefault();
                objdado.id = gest.id;
                model.ApplyCurrentValues(gest.EntityKey.EntitySetName, objdado);
                model.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
