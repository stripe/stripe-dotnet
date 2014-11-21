using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_coupon
    {
        protected static StripeCouponCreateOptions StripeCouponCreateOptions;
        protected static StripeCoupon StripeCoupon;

        private static StripeCouponService _stripeCouponService;
        private static string _createdCouponId;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();
            StripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();

            var stripeCoupon = _stripeCouponService.Create(StripeCouponCreateOptions);
            _createdCouponId = stripeCoupon.Id;
        };

        Because of = () =>
            StripeCoupon = _stripeCouponService.Get(_createdCouponId);

        Behaves_like<coupon_behaviors> behaviors;
    }
}