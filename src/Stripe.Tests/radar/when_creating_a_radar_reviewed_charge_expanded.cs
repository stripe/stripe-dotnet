using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_radar_reviewed_charge_expanded
    {
        private static readonly StripeChargeService _chargeService = new StripeChargeService();
        private static StripeToken _token;
        private static StripeCharge _charge;

        Establish context = () =>
        {
            _token = new StripeTokenService().Create(test_data.stripe_token_create_options.ValidForRadar());
        };

        Because of = () =>
        {
            // tell the service to expand the review (radar)
            _chargeService.ExpandReview = true;

            _charge = _chargeService.Create(test_data.stripe_charge_create_options.ValidToken(_token.Id));
        };

        It should_have_a_charge = () =>
            _charge.ShouldNotBeNull();

        It should_have_a_review_id_on_the_charge = () =>
            _charge.ReviewId.ShouldStartWith("prv_");

        It should_have_a_review = () =>
            _charge.Review.ShouldNotBeNull();

        It should_have_the_right_charge_on_the_review = () =>
            _charge.Review.ChargeId.ShouldEqual(_charge.Id);
    }
}