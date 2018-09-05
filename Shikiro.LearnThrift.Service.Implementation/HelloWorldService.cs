using System;
using Shikiro.LearnThrift.Service.Interface.HelloWorld;

namespace Shikiro.LearnThrift.Service.Implementation.HelloWorld
{
    public class HelloWorldService : IHelloWorldService.Iface
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
