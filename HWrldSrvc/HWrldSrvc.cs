using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFService
{
    public class HWrldSrvc : IHWrldSrvc
    {
        public string GetMsg(string name)
        {
            return "Hello " + name + "!!!";
        }
    }
}
