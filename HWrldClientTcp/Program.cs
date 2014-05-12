using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWrldClientTcp
{
    class Program
    {
        static void Main(string[] args)
        {
           // HWrldSrvcRef.
            HWrldSrvcRef.HWrldSrvcClient client = new HWrldSrvcRef.HWrldSrvcClient();
            Console.WriteLine(client.GetMsg("Dan Brown"));
        }
    }
}
