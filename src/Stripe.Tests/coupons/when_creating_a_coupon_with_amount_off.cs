using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_coupon_with_amount_off
    {
        protected static StripeCouponCreateOptions StripeCouponCreateOptions;
        protected static StripeCoupon StripeCoupon;

        private static StripeCouponService _stripeCouponService;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();
            StripeCouponCreateOptions = test_data.stripe_coupon_create_options.ValidAmountOff();
        };

        Because of = () =>
            StripeCoupon = _stripeCouponService.Create(StripeCouponCreateOptions);

        It should_have_the_correct_amount_off = () =>
            StripeCoupon.AmountOff.ShouldEqual(StripeCouponCreateOptions.AmountOff.Value);
    }
}