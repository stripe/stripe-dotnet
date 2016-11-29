using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_application_fee_refund_async
    {
        private static StripeCharge _charge;
        private static StripeApplicationFeeRefund _refund;

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
            chargeCreateOptions.ApplicationFee = 10;

            _charge = new StripeChargeService().Create(chargeCreateOptions, 
                new StripeRequestOptions
                {
                    StripeConnectAccountId = managedAccount.Id
                }
            );
        };

        Because of = () =>
            _refund = new StripeApplicationFeeRefundService().CreateAsync(_charge.ApplicationFeeId).Result;

        It should_have_a_refund_object = () =>
            _refund.ShouldNotBeNull();

        It should_have_a_refund_amount_of_ten_cents = () =>
            _refund.Amount.ShouldEqual(10);
    }
}
