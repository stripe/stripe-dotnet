namespace Stripe.Infrastructure
{
    using System;

    internal static class EpochTime
    {
        private static DateTime epochStartDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ConvertEpochToDateTime(long seconds)
        {
            return epochStartDateTime.AddSeconds(seconds);
        }

        public static long ConvertDateTimeToEpoch(this DateTime datetime)
        {
            if (datetime < epochStartDateTime)
            {
                return 0;
            }

            return Convert.ToInt64((datetime.ToUniversalTime() - epochStartDateTime).TotalSeconds);
        }
    }
}
