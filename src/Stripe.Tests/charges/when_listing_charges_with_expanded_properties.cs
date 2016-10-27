using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_charges_with_expanded_properties
    {
        private static List<StripeCharge> _stripeChargeList;
        private static StripeChargeService _stripeChargeService;
        private static StripeChargeListOptions _listOptions;

        Establish context = () =>
        {
            var stripeCustomerService = new StripeCustomerService();
            var stripeCustomer = stripeCustomerService.Create(test_data.stripe_customer_create_options.ValidCard());

            _stripeChargeService = new StripeChargeService();
            _stripeChargeService.ExpandCustomer = true;
            _stripeChargeService.ExpandBalanceTransaction = true;

            StripeChargeCreateOptions createOptions = test_data.stripe_charge_create_options.ValidCustomer(stripeCustomer.Id);

            _stripeChargeService.Create(createOptions);
            _stripeChargeService.Create(createOptions);

            _listOptions = new StripeChargeListOptions
            {
                CustomerId = stripeCustomer.Id,
            };
        };

        Because of = () =>
            _stripeChargeList = _stripeChargeService.List(_listOptions).ToList();

        It should_have_customer_on_each_item = () =>
            _stripeChargeList.ShouldEachConformTo(c => c.Customer != null);

        It should_have_customer_id_on_each_item = () =>
            _stripeChargeList.ShouldEachConformTo(c => c.CustomerId != null);

        It should_have_balance_transaction_on_each_item = () =>
            _stripeChargeList.ShouldEachConformTo(c => c.BalanceTransaction != null);
        
        It should_have_balance_transaction_id_on_each_item = () =>
            _stripeChargeList.ShouldEachConformTo(c => c.BalanceTransactionId != null);
    }
}