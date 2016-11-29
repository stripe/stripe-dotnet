using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_on_a_connected_account
    {
        private static StripeChargeService _chargeService;

        private static StripeAccount _account;
        private static StripeToken _token;
        private static StripeCharge _charge;

        private Establish context = () =>
        {
            // setup a managed (connect) account
            _account = new StripeAccountService()
                .Create(new StripeAccountCreateOptions { Email = "west@" + Guid.NewGuid() + "world.com", Managed = true });

            // create a token (not on the connected account)
            _token = new StripeTokenService().Create(test_data.stripe_token_create_options.Valid());

            // setup the charge service to expand the destination
            _chargeService = new StripeChargeService { ExpandDestination = true };
        };

        Because of = () =>
        {
            // create a charge using a token with the destination set to the managed account
            _charge = _chargeService
                .Create(test_data.stripe_charge_create_options.ValidTokenWithDestination(_token.Id, _account.Id));
        };

        It should_have_the_destination = () =>
            _charge.Destination.ShouldNotBeNull();

        It should_have_the_destination_account_id_correct = () =>
            _charge.Destination.Id.ShouldEqual(_account.Id);

        It should_have_the_destination_id = () =>
            _charge.DestinationId.ShouldNotBeNull();
    }
}
