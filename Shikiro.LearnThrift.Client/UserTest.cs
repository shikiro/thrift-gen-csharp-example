using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;
using Shikiro.LearnThrift.Service.Interface.User;

namespace Shikiro.LearnThrift.Client
{
    public class UserTest
    {
        public static void Run(int times)
        {
            Parallel.For(0, times, i =>
            {
                using (TSocket socket = new TSocket("localhost", 8005))
                {
                    using (TTransport transport = new TBufferedTransport(socket))
                    {
                        using (TProtocol protocol = new TCompactProtocol(transport))
                        {
                            using (var client = new IUserService.Client(protocol))
                            {
                                transport.Open();
                                var list = client.GetAll();
                            }
                        }
                    }
                }
            });
        }
    }
}
