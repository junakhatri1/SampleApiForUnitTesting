using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    public class DevelopmentSystemTime: ISystemTime
    {
        DateTime ISystemTime.GetCurrent()
        {
            return new DateTime(1989, 4, 20, 23, 59, 59);
        }
    }

}
