using ServiceRest_20190140104_EkaNovaPramudya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigRest_104_EkaNovaPramudya
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;

            try
            {
                host = new ServiceHost(typeof(TI_UMY));
                host.Open();
                Console.WriteLine("Server Siap....!");
                Console.ReadLine();
                host.Close();
            }catch(Exception e)
            {
                host = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
