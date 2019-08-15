using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWay.DIP
{
    public interface IMessage
    {
        void SendMessage();
    }

    public class Notification
    {
        private ICollection<IMessage> _messages;
        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
