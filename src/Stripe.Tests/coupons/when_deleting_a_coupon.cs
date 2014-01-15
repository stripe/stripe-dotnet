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

            StripeCoupon stripeCoupon = _stripeCouponService.Create(_stripeCouponCreateOptions).Await();
			_createdCouponId = stripeCoupon.Id;
		};

		Because of = () =>
            _stripeCouponService.Delete(_createdCouponId).Await();

		It should_throw_exception_when_getting = () =>
		{
            var exception = Catch.Exception(() => _stripeCouponService.Get(_createdCouponId).Await());
			exception.Message.ShouldContain("No such coupon");
		};
	}
}