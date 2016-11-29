using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_balancetransactions_for_charge
    {
        private static List<StripeBalanceTransaction> _stripeBalanceTransactionList;
        private static StripeBalanceService _stripeBalanceService;
        private static StripeBalanceTransactionListOptions _stripeBalanceTransactionListOptions;
        private static StripeCharge _stripeCharge;

        Establish context = () =>
        {
            var _stripeChargeService = new StripeChargeService();
            _stripeBalanceService = new StripeBalanceService();

            _stripeCharge = _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _stripeBalanceTransactionListOptions = new StripeBalanceTransactionListOptions
            {
                SourceId = _stripeCharge.Id,
                Type = "charge"
            };
        };

        Because of = () =>
            _stripeBalanceTransactionList = _stripeBalanceService.List(_stripeBalanceTransactionListOptions).ToList();

        It should_have_only_one_entry = () =>
            _stripeBalanceTransactionList.Count.ShouldEqual(1);

        It should_match_charge_id = () =>
            _stripeBalanceTransactionList.Single().Source.ShouldEqual(_stripeCharge.Id);

        It should_match_charge_type = () =>
            _stripeBalanceTransactionList.Single().Type.ShouldEqual("charge");

        It should_contain_one_fee = () =>
            _stripeBalanceTransactionList.Single().FeeDetails.Count().ShouldEqual(1);
    }
}