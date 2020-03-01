using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Bot
{
    public abstract class AbstractChatBot
    {
        public abstract string Answer(string userQuestion);
    }
}
