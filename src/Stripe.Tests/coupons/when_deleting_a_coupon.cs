using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_a_coupon
    {
        private static StripeCouponCreateOptions _stripeCouponCreateOptions;
        private static StripeCouponService _stripeCouponService;
        private static string _createdCouponId;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();
            _stripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();

            var stripeCoupon = _stripeCouponService.Create(_stripeCouponCreateOptions);
            _createdCouponId = stripeCoupon.Id;
        };

        Because of = () =>
            _stripeCouponService.Delete(_createdCouponId);

        It should_throw_exception_when_getting = () =>
        {
            var exception = Catch.Exception(() => _stripeCouponService.Get(_createdCouponId));
            exception.Message.ShouldContain("No such coupon");
        };
    }
}