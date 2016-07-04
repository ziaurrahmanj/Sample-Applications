using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ_Sample
{
    class Program
    {
        private const string HostName = "localhost";
        private const string UserName = "guest";
        private const string Password = "guest";
        public const string QueueName = "Module1.Sample3";
        public const string Exchange = "";
        static void Main(string[] args)
        {
            var connectionfactory = new RabbitMQ.Client.ConnectionFactory() { Password=Password,UserName=UserName,HostName=HostName };
            var connection = connectionfactory.CreateConnection();
            var model = connection.CreateModel();

            model.QueueDeclare("Module1.Sample3", true, false, false, null);
            Console.WriteLine("Queue Created");

            model.ExchangeDeclare("MyExchange", ExchangeType.Topic);
            Console.WriteLine("Exchange Created");

            model.QueueBind("Module1.Sample3", "MyExchange", "cars");
            Console.WriteLine("Exchange and Queue bound");

            //prop
            var properties = model.CreateBasicProperties();
#pragma warning disable CS0618 // Type or member is obsolete
            properties.SetPersistent(false);
#pragma warning restore CS0618 // Type or member is obsolete

            //serialize
            byte[] messageBuffer = Encoding.Default.GetBytes("this is my message");

            //send message
            model.BasicPublish(Exchange, QueueName, properties, messageBuffer);

            Console.WriteLine("Message Sent");
            Console.ReadLine();


        }
    }
}
