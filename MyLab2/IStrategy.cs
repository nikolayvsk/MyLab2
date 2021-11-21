using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab2
{
    interface IStrategy
    {
        List<Scientific_works> AnalyseFile(Scientific_works sci_works, string path);
    }
}
