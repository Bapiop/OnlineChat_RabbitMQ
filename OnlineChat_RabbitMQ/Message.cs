using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat_RabbitMQ
{
    public struct Message
    {
        public string Author;
        public byte[] Text;
    }
}
