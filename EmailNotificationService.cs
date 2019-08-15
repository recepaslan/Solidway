using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay
{
    public class EmailNotificationService : INotificationService<Employee>
    {
        public void Notify(Employee payload)
        {
            //send email
        }
    }
}
