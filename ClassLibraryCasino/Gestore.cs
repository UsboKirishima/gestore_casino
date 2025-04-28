using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCasino
{
    public class Gestore
    {
        private static BindingList<TransazioneDenaro> transazioni = TransazioneDenaro.GetData();

        public static BindingList<TransazioneDenaro> GetTransazioni()
        {
            return transazioni;
        }
    }
}
