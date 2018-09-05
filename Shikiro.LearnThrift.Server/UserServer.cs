using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;
using Thrift.Transport;
using Thrift.Server;
using Shikiro.LearnThrift.Service.Interface.User;
using Shikiro.LearnThrift.Service.Implementation.User;

namespace Shikiro.LearnThrift.Server
{
    public class UserServer
    {
        public static void Run()
        {
            TServerTransport serverTransport = new TServerSocket(8005);

            TTransportFactory transportFactory = new TTransportFactory();

            TProtocolFactory protocolFactory = new TCompactProtocol.Factory();

            var processor = new IUserService.Processor(new UserService());

            var server = new TThreadPoolServer(processor, serverTransport, transportFactory, protocolFactory);

            server.Serve();
        }
    }
}
