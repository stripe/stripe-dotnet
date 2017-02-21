using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_deleting_a_discount_from_a_subscription
    {
        private static StripeDiscountService _discountService;
        private static StripeCustomer _customer;
        private static StripeSubscription _subscription;
        private static StripeDeleted _deleted;

        Establish context = () =>
        {
            _discountService = new StripeDiscountService();

            var planService = new StripePlanService();
            var plan = planService.Create(test_data.stripe_plan_create_options.Valid());

            var couponService = new StripeCouponService();
            var coupon = couponService.Create(test_data.stripe_coupon_create_options.Valid());

            var customerService = new StripeCustomerService();
            _customer = customerService.Create(test_data.stripe_customer_create_options.ValidCard(plan.Id));

            _subscription = new StripeSubscriptionService().Update( 
                _customer.Subscriptions.Data[0].Id,
                new StripeSubscriptionUpdateOptions()
                {
                    CouponId = coupon.Id
                }
            );
        };

        Because of = () =>
            _deleted = _discountService.DeleteSubscriptionDiscount(_subscription.Id);

        It should_return_stripe_deleted = () =>
            _deleted.ShouldNotBeNull();

        It should_return_stripe_deleted_as_true = () =>
            _deleted.Deleted.ShouldEqual(true);
    }
}