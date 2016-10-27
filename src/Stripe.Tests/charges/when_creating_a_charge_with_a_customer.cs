using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_customer
    {
        protected static StripeChargeCreateOptions StripeChargeCreateOptions;
        protected static StripeCharge StripeCharge;
        protected static StripeCard StripeCard;

        private static StripeChargeService _stripeChargeService;
        private static StripeCustomer _stripeCustomer;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());
            
            _stripeChargeService = new StripeChargeService();
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCustomer(_stripeCustomer.Id);
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            StripeCard = _stripeCustomer.SourceList.Data.First();
        };

        It should_have_the_customerid = () =>
            StripeCharge.CustomerId.ShouldNotBeNull();

        It should_not_have_the_customer = () =>
            StripeCharge.Customer.ShouldBeNull();

        Behaves_like<charge_behaviors> behaviors;
    }
}