using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.OCP
{
    public class InvoiceService_OCP_Bad
    {

        public double CalculateInvoiceTotal(
            Invoice invoice, 
            string level)
        {
            Rate rate = new Rate();
            if (level == "beginner")
            {
                rate.RegulerRate = 10;
                rate.OtRate = 15;
                rate.DTRate = 20;
            }
            else if (level == "senior") {
                rate.RegulerRate = 20;
                rate.OtRate = 30;
                rate.DTRate = 40;
            }
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
