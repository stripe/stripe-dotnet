using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_creating_a_charge_with_a_stripe_account
    {
        private static StripeAccount _stripeAccount;
        private static StripeCharge _stripeCharge;

        Establish context = () =>
        {
            // create a new custom account
            _stripeAccount = new StripeAccountService().Create(new StripeAccountCreateOptions()
            {
                Country = "US",
                Type = StripeAccountType.Custom
            });
        };

        Because of = () =>
        {
            // charge the customer something
            _stripeCharge = new StripeChargeService().Create(new StripeChargeCreateOptions()
            {
                Amount = 100,
                Currency = "usd",
                SourceTokenOrExistingSourceId = _stripeAccount.Id
            });
        };

        It should_have_the_right_source = () =>
            _stripeCharge.Source.Account.ShouldNotBeNull();

        It should_not_have_the_wrong_source = () =>
            _stripeCharge.Source.Card.ShouldBeNull();

        It should_have_the_right_source_type = () =>
            _stripeCharge.Source.Type.ShouldEqual(SourceType.Account);

        It should_have_the_right_id = () =>
            _stripeCharge.Source.Id.ShouldEqual(_stripeAccount.Id);

        It should_deserialize_the_account_properly = () =>
            _stripeCharge.Source.Account.Id.ShouldEqual(_stripeAccount.Id);
    }
}