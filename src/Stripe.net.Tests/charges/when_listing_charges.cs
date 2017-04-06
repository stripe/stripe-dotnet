using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_charges
    {
        private static StripeList<StripeCharge> _stripeChargeList;
        private static StripeChargeService _stripeChargeService;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();

            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
        };

        Because of = () =>
            _stripeChargeList = _stripeChargeService.List(new StripeChargeListOptions { IncludeTotalCount = true });

        It should_have_atleast_4_entries = () =>
            _stripeChargeList.TotalCount.ShouldBeGreaterThanOrEqualTo(4);
    }
}