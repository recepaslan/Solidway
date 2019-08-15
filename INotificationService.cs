using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay
{
    public interface INotificationService<T>
    {
        void Notify(T payload);
    }
}
