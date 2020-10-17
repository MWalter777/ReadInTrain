using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInTrain
{
    interface IRead
    {
        bool canRead(int levelMin, int levelMax);
    }
}
