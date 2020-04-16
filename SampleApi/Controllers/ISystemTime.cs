using System;

namespace SampleApi.Controllers
{
    public interface ISystemTime
    {
        DateTime GetCurrent();
    }
}
