using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_coupon_with_an_api_key
    {
        protected static StripeCouponCreateOptions StripeCouponCreateOptions;
        protected static StripeCoupon StripeCoupon;

        private static StripeCouponService _stripeCouponService;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();
            StripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();
        };

        Because of = () =>
            StripeCoupon = _stripeCouponService.Create(StripeCouponCreateOptions);

#pragma warning disable 169, 414
        Behaves_like<coupon_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}
