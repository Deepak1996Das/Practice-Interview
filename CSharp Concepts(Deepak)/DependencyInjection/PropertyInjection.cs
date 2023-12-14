using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface INofificationAction
    {
        void ActOnNotification(string message);
    }
    public class PropertyInjection
    {
        INofificationAction task = null;
        public void notify(INofificationAction at, string messages)
        {
            this.task = at;
            task.ActOnNotification(messages);
        }
    }
    class EventLogWriter : INofificationAction
    {
        public void ActOnNotification(string message)
        {
            // Write to event log here
        }
    }
}
