using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_balancetransactions
    {
        private static StripeList<StripeBalanceTransaction> _stripeBalanceTransactionList;
        private static StripeBalanceService _stripeBalanceService;

        Establish context = () =>
        {
            var _stripeChargeService = new StripeChargeService();
            _stripeBalanceService = new StripeBalanceService();

            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
        };

        Because of = () =>
            _stripeBalanceTransactionList = _stripeBalanceService.List();

        It should_have_atleast_4_entries = () =>
            _stripeBalanceTransactionList.Data.Count.ShouldBeGreaterThanOrEqualTo(4);
    }
}