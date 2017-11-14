using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExampPrep.Threads.UI.ConsoleApp
{
    class Listing196
    {
        internal static void RethrowExceptionThatPointsToOriginalDemo()
        {
            try
            {
                ProcessOrder();
            }
            catch (MessageQueueException ex)
            {
                //original exception is preserved, including the stack trace and a new exception with extra info is added.
                throw new OrderProcessingException("Error while processing order", ex);
            }
        }

        private static void ProcessOrder()
        {
            throw new MessageQueueException();
        }
    }

    [Serializable]
    internal class OrderProcessingException : Exception
    {
        public OrderProcessingException()
        {
        }

        public OrderProcessingException(string message) : base(message)
        {
        }

        public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class MessageQueueException : Exception
    {
        public MessageQueueException()
        {
        }

        public MessageQueueException(string message) : base(message)
        {
        }

        public MessageQueueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MessageQueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
