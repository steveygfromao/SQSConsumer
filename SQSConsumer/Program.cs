using System;
using System.Threading.Tasks;

namespace SQSConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SQSConsumer sqsConsumer = new SQSConsumer();

            await sqsConsumer.Listen();

        }
    }
}