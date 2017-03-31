using System;

namespace Stripe.Infrastructure
{
    internal static class EpochTime
    {
        private static DateTime _epochStartDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ConvertEpochToDateTime(long seconds)
        {
            return _epochStartDateTime.AddSeconds(seconds);
        }

        public static long ConvertDateTimeToEpoch(this DateTime datetime)
        {
            if (datetime < _epochStartDateTime) return 0;

            return Convert.ToInt64((datetime.ToUniversalTime() - _epochStartDateTime).TotalSeconds);
        }
    }
}