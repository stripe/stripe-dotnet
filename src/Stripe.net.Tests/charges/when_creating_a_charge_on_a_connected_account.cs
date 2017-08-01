using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_on_a_connected_account
    {
        private static StripeChargeService _chargeService;

        private static StripeAccount _account;
        private static StripeCharge _charge;

        Establish context = () =>
        {
            // setup a custom (connect) account
            _account = Cache.GetCustomAccountWithCard();

            // setup the charge service to expand the destination
            _chargeService = new StripeChargeService { ExpandDestination = true };
        };

        Because of = () =>
        {
            // create a charge using a token with the destination set to the custom account
            _charge = _chargeService
                .Create(test_data.stripe_charge_create_options.ValidTokenWithDestination("tok_visa", _account.Id, 100));
        };

        It should_have_the_destination = () =>
            _charge.Destination.ShouldNotBeNull();

        It should_have_the_destination_account_id_correct = () =>
            _charge.Destination.Id.ShouldEqual(_account.Id);

        //It should_have_the_destination_amount_correct = () =>
        //    _charge.Amount.ShouldEqual(100);
    }
}
