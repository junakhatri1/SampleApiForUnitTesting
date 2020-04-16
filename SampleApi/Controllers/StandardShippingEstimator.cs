using System;


namespace SampleApi.Controllers
{
    public class StandardShippingEstimator : IEstimateshipping
    {
        ISystemTime SystemTime;
        public StandardShippingEstimator(ISystemTime systemTime)
        {
            SystemTime = systemTime;
        }

        DateTime IEstimateshipping.GetEstimatedShipDate()
        {
            return SystemTime.GetCurrent().Hour <= 17 ?
                SystemTime.GetCurrent().Date :
                SystemTime.GetCurrent().AddDays(1).Date;

        }
    }
}
