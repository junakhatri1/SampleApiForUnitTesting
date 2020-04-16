using System;

namespace SampleApi.Controllers
{
    public class SystemTime : ISystemTime
    {
        DateTime ISystemTime.GetCurrent()
        {
            return DateTime.Now;
        }
    }
}
