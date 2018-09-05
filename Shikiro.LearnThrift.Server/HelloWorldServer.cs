using System;
using System.Collections.Generic;
using System.Text;
using Thrift;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;
using Shikiro.LearnThrift.Service.Interface.HelloWorld;
using Shikiro.LearnThrift.Service.Implementation.HelloWorld;

namespace Shikiro.LearnThrift.Server
{
    public class HelloWorldServer
    {
        public static void Run()
        {
            TServerTransport serverTransport = new TServerSocket(8005);

            TTransportFactory transportFactory = new TTransportFactory();

            TProtocolFactory protocolFactory = new TCompactProtocol.Factory();

            var processor = new IHelloWorldService.Processor(new HelloWorldService());

            var server = new TThreadPoolServer(processor, serverTransport, transportFactory, protocolFactory);

            server.Serve();
        }
    }
}
