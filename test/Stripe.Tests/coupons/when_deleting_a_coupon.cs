using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_a_coupon
    {
        private static StripeCouponCreateOptions _stripeCouponCreateOptions;
        private static StripeCouponService _stripeCouponService;
        private static string _createdCouponId;
        private static StripeDeleted _deletedCoupon;

        Establish context = () =>
        {
            _stripeCouponService = new StripeCouponService();
            _stripeCouponCreateOptions = test_data.stripe_coupon_create_options.Valid();

            var stripeCoupon = _stripeCouponService.Create(_stripeCouponCreateOptions);
            _createdCouponId = stripeCoupon.Id;
        };

        Because of = () =>
            _deletedCoupon = _stripeCouponService.Delete(_createdCouponId);

        It should_throw_exception_when_getting = () =>
        {
            var exception = Catch.Exception(() => _stripeCouponService.Get(_createdCouponId));
            exception.Message.ShouldContain("No such coupon");
        };

        It should_have_deleted_set_to_true = () =>
            _deletedCoupon.Deleted.ShouldBeTrue();

        It should_have_the_right_id = () =>
            _deletedCoupon.Id.ShouldEqual(_createdCouponId);
    }
}