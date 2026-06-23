namespace Stripe.Infrastructure
{
    using System;

    internal static class DateTimeUtils
    {
        // NOTE: We will use DateTime.UnixEpoch once we bump the minimum supported version to .NET
        // Standard 2.1
        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
