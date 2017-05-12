using Machine.Specifications;
using Newtonsoft.Json;

namespace Stripe.Tests
{
    public class when_serializing_a_stripe_charge
    {
        private static StripeCharge _stripeCharge;
        private static StripeChargeService _stripeChargeService;
        private static string _serializedCharge;

        Establish context = () =>
        {
            _stripeChargeService = new StripeChargeService();
        };

        Because of = () =>
        {
            _stripeCharge = _stripeChargeService.Create(test_data.stripe_charge_create_options.ValidCard());
            _serializedCharge = JsonConvert.SerializeObject(_stripeCharge);
        };

        It should_return_a_stripe_charge = () =>
            _stripeCharge.ShouldNotBeNull();
    }
}