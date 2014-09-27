using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_coupons
    {
        private static List<StripeCoupon> _stripeCouponList;
        private static StripeCouponService _stripeCouponService;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();

            _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());
            _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());
            _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());
            _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());
        };

        Because of = () =>
            _stripeCouponList = _stripeCouponService.List().ToList();

        It should_have_atleast_4_entries = () =>
            _stripeCouponList.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}