using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_radar_reviewed_charge
    {
        private static readonly StripeChargeService _chargeService = new StripeChargeService();
        private static StripeCharge _charge;

        Because of = () =>
        {
            _charge = _chargeService.Create(test_data.stripe_charge_create_options.ValidToken("tok_riskLevelElevated"));
        };

        It should_have_a_charge = () =>
            _charge.ShouldNotBeNull();

        It should_have_a_review_id_on_the_charge = () =>
            _charge.ReviewId.ShouldStartWith("prv_");
    }
}