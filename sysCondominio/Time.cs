using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sysCondominio
{
    public class Time
    {
        private DateTime Ini;
        private DateTime Fim;
        private TimeSpan Res;

        public void Iniciar()
        {
            Ini = DateTime.Now;
        }

        public TimeSpan Parar()
        {
            Fim = DateTime.Now;
            Res = Fim.Subtract(Ini);
            return Res;
        }
        
        public string Min()
        {
            return string.Format("{0:0}", Res.Minutes);
        }

        public string Segundos()
        {
            return string.Format("{0:0}", Res.Seconds);
        }

        public string Mili()
        {
            return string.Format("{0:0}", Res.Milliseconds);
        }

    }
}