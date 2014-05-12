using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HWrldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HWrldSrvcClient client = new HWrldSrvcClient();

            Console.WriteLine(client.GetMsg("Johny Rambo"));

        }
    }
}
