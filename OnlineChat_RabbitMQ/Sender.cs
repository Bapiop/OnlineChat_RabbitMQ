using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat_RabbitMQ
{
    class Sender
    {
        private string RabbitMQ_user;
        private IModel RabbitMQ_channel;

        public string User => RabbitMQ_user;
        public IModel Channel => RabbitMQ_channel;

        public Sender(string user)
        {
            RabbitMQ_channel = RabbitMQUtility.CreateConnection();
            RabbitMQ_user = user;
            RabbitMQ_channel.QueueDeclare(
                queue: RabbitMQ_user,
                durable: false,
                autoDelete: false,
                exclusive: false,
                arguments: null
                );
        }

        public void SendMessage(string text, string receiver)
        {
            Message message = new Message()
            {
                Author = RabbitMQ_user,
                Text = RabbitMQUtility.EncodeMessage(text)
            };
            string serializedMessage = JsonConvert.SerializeObject(message);
            byte[] body = RabbitMQUtility.EncodeMessage(serializedMessage);

            RabbitMQ_channel.BasicPublish(
                exchange: receiver,
                routingKey: RabbitMQ_user,
                basicProperties: null,
                body: body
                );
            MySQL_Connection.SaveMessageToDB(receiver, serializedMessage);
        }

    }
}
