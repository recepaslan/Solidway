using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.OCP
{
    public class InvoiceService_OCP_Good
    {
        RateCalculater _rateCalculater;
        public InvoiceService_OCP_Good()
        {
            _rateCalculater = new RateCalculater();
        }
        public double CalculateInvoiceTotal(
            Invoice invoice, 
            string level)
        {
            Rate rate = _rateCalculater.GetRate(level);
            return Total(invoice, rate);
        }
        public double Total(
            Invoice invoice, 
            Rate rate) {
            return invoice.RegularHours * rate.RegulerRate +
                invoice.OTHours * rate.OtRate +
                invoice.DTHours * rate.DTRate;
        }
    }
}
