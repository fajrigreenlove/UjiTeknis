using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DTO
{
    internal class applicationDto
    {
        public protectedData Protected { get; set; }
    }

    public class protectedData
{
       public string ShieldLastRun { get; set; }
    }
}
