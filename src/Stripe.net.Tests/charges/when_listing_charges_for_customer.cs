using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_charges_for_customer
    {
        private static StripeList<StripeCharge> _stripeChargeList;
        private static StripeChargeService _stripeChargeService;
        private static StripeCustomer _stripeCustomer;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            _stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeChargeService = new StripeChargeService();

            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCustomer(_stripeCustomer.Id));
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCustomer(_stripeCustomer.Id));
        };

        Because of = () =>
            _stripeChargeList = _stripeChargeService.List(new StripeChargeListOptions
            {
                CustomerId = _stripeCustomer.Id,
                IncludeTotalCount = true
            });

        It should_have_only_2_entries = () =>
            _stripeChargeList.TotalCount.ShouldEqual(2);
    }
}