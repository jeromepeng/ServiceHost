using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using WCF_PurchaseModule;

namespace WCF_Console
{
    public class Program
    {
        private static ServiceHost _ServiceHost = null;

        public static void StartService()
        {
            Uri baseAddress = new Uri("http://localhost:8080/PurchaseSystem.svc");

            //实例化ServiceHost服务器，并在构造函数中指定要发布的服务
            _ServiceHost = new ServiceHost(typeof(PurchaseSystem), baseAddress);

            //打开服务器，读取配置文件中的WCF服务的配置信息
            _ServiceHost.Open();
        }

        public static void StopService()
        {
            if (_ServiceHost.State != CommunicationState.Closed)
                _ServiceHost.Close();
        }

        public static void Main(string[] args)
        {
            StartService();
            Console.WriteLine("Server is running. Press return to exit!");
            Console.ReadLine();
            StopService();
        }

    }
}
