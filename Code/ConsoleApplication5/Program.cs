using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ConsoleApplication5.Encryption;
using ExampPrep.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checked.Checked.Wrapped(10);

            //PLINQ.AsParallel();

            //PLINQ.AsOrdered();

            //Hashing.HashStuff();
        }
    }

    public  class DocumentServiceResponse  
    {
    }


    public class DocumentServiceRequest 
    {
        public List<Widgets> Widgets { get; set; }

        public Response<bool, string> DoShit(DocumentServiceRequest request)
        {
            var response = new Response<bool, string>(true, "its amazing");

            return response;
        }
    }

    public class Response<TResult, TMessage>
    {
        public Response()
        {
           
        }

        public Response(TResult result, TMessage message) : this()
        {
            Result = result;
            Message = message;
        }

        public TResult Result { get; set; }
        public TMessage Message { get; set; }
    }

    public class Widgets
    {
    }
}
