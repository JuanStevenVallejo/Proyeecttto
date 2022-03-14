using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Imprimir
    {
        public List<clsFactura> ListImprimeFactura { set; get; }

        public Imprimir()
        {
            ListImprimeFactura = new List<clsFactura>();
        } 
    }
}
