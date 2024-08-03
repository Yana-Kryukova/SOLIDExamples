using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRExamples.Examples2.MobileStore.Good.Interfaces
{
    internal interface IPhoneBinder
    {
        Phone CreatePhone(string?[] data);
    }
}
