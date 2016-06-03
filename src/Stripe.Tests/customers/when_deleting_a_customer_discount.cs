using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Stripe.Tests.subscriptions 
{
    public class when_deleting_a_discount 
    {
        private static StripeCustomerService _stripeCustomerService;
        private static StripeCustomer _stripeCustomer;
        private static string _createdStripeCustomerId;
        private static StripeDiscountDelete _discountDelete;

        Establish context = () => 
        {
            var _stripePlanService = new StripePlanService();
            var _stripePlan = _stripePlanService.Create(test_data.stripe_plan_create_options.Valid());

            var _stripeCouponService = new StripeCouponService();
            var _stripeCoupon = _stripeCouponService.Create(test_data.stripe_coupon_create_options.Valid());

            var _stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = _stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard(_stripePlan.Id, _stripeCoupon.Id, DateTime.UtcNow.AddDays(10)));
        };

        Because of = () => {
            _discountDelete = _stripeCustomerService.DeleteDiscount(_createdStripeCustomerId);

            It should_be_deleted_true = () => 
            {
                _discountDelete.Deleted.ShouldEqual(true);
            };
        };
    }

}
