using CarShop.Api.Common.Constants;

namespace CarShop.Api.Common.Helpers;
public class TimeHelper
{
    public static DateTime GetCurrentServerTime()
    {
        var date = DateTime.UtcNow.AddHours(TimeConstants.UTC);
        return date;
    }
}
