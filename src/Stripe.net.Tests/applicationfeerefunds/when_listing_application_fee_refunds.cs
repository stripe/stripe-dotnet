using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_listing_application_fee_refunds
    {
        private static StripeCharge _charge;
        private static StripeApplicationFeeRefund _refund1Sync;
        private static StripeApplicationFeeRefund _refund2Async;
        private static List<StripeApplicationFeeRefund> _refunds;

        Establish context = () =>
        {
            // create a managed account
            var accountOptions = test_data.stripe_account_create_options.ValidAccountWithBankAccount();
            accountOptions.Managed = true;

            var managedAccount = new StripeAccountService().Create(accountOptions);

            // since stripe will error without using a token from stripe.js, we will use the 
            // token service from stripe.net for this test. you should use stripe.js to receive
            // the token in your implementation for PCI compliance - unless you know all the rules
            // for making your server PCI compliant. Hint: you probably don't, it's a lot. use stripe.js :D
            var token = new StripeTokenService().Create(test_data.stripe_token_create_options.Valid());

            // create a charge on that managed account with an application fee of 10 cents
            var chargeCreateOptions = test_data.stripe_charge_create_options.ValidToken(token.Id);
            chargeCreateOptions.ApplicationFee = 20;

            _charge = new StripeChargeService().Create(chargeCreateOptions,
                new StripeRequestOptions
                {
                    StripeConnectAccountId = managedAccount.Id
                }
            );

            _refund1Sync = new StripeApplicationFeeRefundService().Create(_charge.ApplicationFeeId, new StripeApplicationFeeRefundCreateOptions { Amount = 7 });
            _refund2Async = new StripeApplicationFeeRefundService().CreateAsync(_charge.ApplicationFeeId, new StripeApplicationFeeRefundCreateOptions { Amount = 3 }).Result;
        };

        Because of = () =>
            _refunds = new StripeApplicationFeeRefundService().List(_charge.ApplicationFeeId).ToList();

        It should_have_a_refund_object = () =>
            _refunds.ShouldNotBeNull();

        It should_have_a_seven_cent_refund = () =>
            _refunds.ShouldContain(rf => rf.Amount == 7);

        It should_have_a_three_cent_refund = () =>
            _refunds.ShouldContain(rf => rf.Amount == 3);
    }
}
