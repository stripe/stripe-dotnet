using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_an_application_fee_refund
    {
        private static StripeCharge _charge;
        private static StripeApplicationFeeRefund _refund;

        Establish context = () =>
        {
            var customAccount = Cache.GetCustomAccountWithCard();

            // create a charge on that custom account with an application fee of 10 cents
            var chargeCreateOptions = test_data.stripe_charge_create_options.ValidToken("tok_visa");
            chargeCreateOptions.ApplicationFee = 10;

            _charge = new StripeChargeService().Create(chargeCreateOptions, 
                new StripeRequestOptions
                {
                    StripeConnectAccountId = customAccount.Id
                }
            );
        };

        Because of = () =>
            _refund = new StripeApplicationFeeRefundService().Create(_charge.ApplicationFeeId);

        It should_have_a_refund_object = () =>
            _refund.ShouldNotBeNull();

        It should_have_a_refund_amount_of_ten_cents = () =>
            _refund.Amount.ShouldEqual(10);
    }
}
