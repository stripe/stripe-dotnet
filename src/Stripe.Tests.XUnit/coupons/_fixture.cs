using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class coupons_fixture : IDisposable
    {
        public StripeCouponCreateOptions CouponCreateOptions { get; set; }
        public StripeCouponUpdateOptions CouponUpdateOptions { get; set; }

        public StripeCoupon Coupon { get; set; }
        public StripeCoupon CouponRetrieved { get; set; }
        public StripeCoupon CouponUpdated { get; set; }
        public StripeDeleted CouponDeleted { get; set; }
        public StripeList<StripeCoupon> CouponsList { get; }

        public coupons_fixture()
        {
            CouponCreateOptions = new StripeCouponCreateOptions() {
                // Add a space at the end to ensure the ID is properly URL encoded
                // when passed in the URL for other methods
                Id = "test-coupon-" + Guid.NewGuid().ToString() + " ",
                PercentOff = 25,
                Duration = "repeating",
                DurationInMonths = 3,
            };

            CouponUpdateOptions = new StripeCouponUpdateOptions {
              Metadata = new Dictionary<string, string>{{"key_1", "value_1"}}
            };

            var service = new StripeCouponService(Cache.ApiKey);
            Coupon = service.Create(CouponCreateOptions);
            CouponRetrieved = service.Get(Coupon.Id);
            CouponUpdated = service.Update(Coupon.Id, CouponUpdateOptions);
            CouponsList = service.List();
            CouponDeleted = service.Delete(Coupon.Id);
        }

        public void Dispose() { }
    }
}
