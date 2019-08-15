using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.OCP
{
    public class RateCalculater
    {
        public Rate GetRate(string level) {
            Rate rate = new Rate();
            if (level == "beginner")
            {
                rate.RegulerRate = 10;
                rate.OtRate = 15;
                rate.DTRate = 20;
            }
            else if (level == "senior")
            {
                rate.RegulerRate = 20;
                rate.OtRate = 30;
                rate.DTRate = 40;
            }
            return rate;
        }
    }
}
