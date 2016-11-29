using System.Collections.Generic;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_refunding_and_setting_fraud_details
    {
        private static StripeChargeCreateOptions _stripeChargeCreateOptions;
        private static StripeCharge _stripeCharge;
        private static StripeChargeService _stripeChargeService;
        private static StripeChargeUpdateOptions _stripeChargeUpdateOptions;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
            _stripeChargeCreateOptions = test_data.stripe_charge_create_options.ValidCard();

            // create a charge
            _stripeCharge = _stripeChargeService.Create(_stripeChargeCreateOptions);

            // refund the charge
            new StripeRefundService().Create(_stripeCharge.Id);

            // create charge update options to set the charge as fradulent
            _stripeChargeUpdateOptions = new StripeChargeUpdateOptions
            {
                FraudDetails = new Dictionary<string, string>
                {
                    { "user_report", "fraudulent" }
                }
            };
        };

        Because of = () =>
            _stripeCharge = _stripeChargeService.Update(_stripeCharge.Id, _stripeChargeUpdateOptions);

        It should_have_fraud_details = () =>
            _stripeCharge.FraudDetails.ShouldEqual(_stripeChargeUpdateOptions.FraudDetails);
    }
}