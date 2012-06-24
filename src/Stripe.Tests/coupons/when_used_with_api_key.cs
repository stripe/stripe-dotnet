using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace Stripe.Tests.coupons
{
    public class when_used_with_api_key
    {
        protected static StripeCouponCreateOptions StripeCouponCreateOptions;
        protected static StripeCoupon StripeCoupon;

        private static StripeCouponService _stripeCouponService;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService("[your api key here]");
            StripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();
        };

        Because of = () =>
            StripeCoupon = _stripeCouponService.Create(StripeCouponCreateOptions);

        Behaves_like<coupon_behaviors> behaviors;
    }
}
