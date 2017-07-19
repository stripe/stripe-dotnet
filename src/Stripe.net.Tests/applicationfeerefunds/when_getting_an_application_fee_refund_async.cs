using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_an_application_fee_refund_async
    {
        private static StripeCharge _charge;
        private static StripeApplicationFeeRefund _createdRefund;
        private static StripeApplicationFeeRefund _retrievedRefund;

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

            _createdRefund = new StripeApplicationFeeRefundService().CreateAsync(_charge.ApplicationFeeId).Result;
        };

        Because of = () =>
            _retrievedRefund = new StripeApplicationFeeRefundService().GetAsync(_charge.ApplicationFeeId, _createdRefund.Id).Result;

        It should_have_a_refund_object = () =>
            _retrievedRefund.ShouldNotBeNull();

        It should_have_the_right_id = () =>
            _retrievedRefund.Id.ShouldEqual(_createdRefund.Id);

        It should_have_a_refund_amount_of_ten_cents = () =>
            _retrievedRefund.Amount.ShouldEqual(10);
    }
}
