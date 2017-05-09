using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_customer_expanded
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
            _stripeChargeService.ExpandCustomer = true;
            StripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCustomer(_stripeCustomer.Id);
        };

        Because of = () =>
        {
            StripeCharge = _stripeChargeService.Create(StripeChargeCreateOptions);
            StripeCard = _stripeCustomer.Sources.Data.First().Card;
        };

        It should_have_the_customerid = () =>
            StripeCharge.CustomerId.ShouldNotBeNull();

        It should_have_the_customer = () =>
            StripeCharge.Customer.ShouldNotBeNull();

#pragma warning disable 169, 414
        Behaves_like<charge_behaviors> behaviors;
#pragma warning restore 169, 414

    }
}