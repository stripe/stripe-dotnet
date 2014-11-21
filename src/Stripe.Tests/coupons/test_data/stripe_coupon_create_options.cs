using System;

namespace Stripe.Tests.test_data
{
    public static class stripe_coupon_create_options
    {
        public static StripeCouponCreateOptions Valid()
        {
            var stripeCouponCreateOptions = new StripeCouponCreateOptions()
            {
                Id = "test-coupon-" + Guid.NewGuid().ToString(),
                PercentOff = 5,
                Duration = "repeating",
                DurationInMonths = 3,
                MaxRedemptions = 5,
                RedeemBy = DateTime.UtcNow.AddDays(1)
            };

            return stripeCouponCreateOptions;
        }

        public static StripeCouponCreateOptions ValidAmountOff()
        {
            var stripeCouponCreateOptions = new StripeCouponCreateOptions()
            {
                Id = "test-coupon-" + Guid.NewGuid().ToString(),
                AmountOff = 10,
                Currency = "usd",
                Duration = "repeating",
                DurationInMonths = 3,
                MaxRedemptions = 5,
                RedeemBy = DateTime.UtcNow.AddDays(1)
            };

            return stripeCouponCreateOptions;
        }
    }
}
